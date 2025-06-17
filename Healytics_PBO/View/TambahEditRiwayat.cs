using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Healytics_PBO.Controller;
using Healytics_PBO.Model;

namespace Healytics_PBO.View
{
    public partial class TambahEditRiwayat : Form
    {
        private int no_register;
        private string nama_pasien;
        private string nama_desa;

        private RiwayatKunjunganController controller = new RiwayatKunjunganController();
        private GejalaController gejalaController = new GejalaController();
        private ObatController obatController = new ObatController();
        private DetailRiwayatController detailRiwayatController = new DetailRiwayatController();
        private TransaksiController transaksiController = new TransaksiController();

        private List<GejalaModel> semuaGejala;
        private List<ObatModel> semuaObat;

        private RiwayatKunjunganModel modelUpdate;

        private bool isUpdate = false;

        public TambahEditRiwayat(int no_register, string nama_pasien, string nama_desa)
        {
            InitializeComponent();
            this.no_register = no_register;
            this.nama_pasien = nama_pasien;
            this.nama_desa = nama_desa;
            this.Dock = DockStyle.Fill;
            this.Load += TambahEditRiwayat_Load;
            btnSimpan.Click += btnSimpan_Click;
        }

        public TambahEditRiwayat(RiwayatKunjunganModel model, string nama_pasien, string nama_desa)
        : this(model.no_register, nama_pasien, nama_desa)
        {

            this.modelUpdate = model;
            this.isUpdate = true;
        }

        private void TambahEditRiwayat_Load(object sender, EventArgs e)
        {
            semuaGejala = gejalaController.GetAll();
            semuaObat = obatController.GetAll();

            clbGejala.Items.Clear();
            foreach (var g in semuaGejala)
                clbGejala.Items.Add(g);
            clbGejala.DisplayMember = "nama_gejala";

            var combo = (DataGridViewComboBoxColumn)dgvObat.Columns["colObat"];
            combo.DataSource = semuaObat;
            combo.DisplayMember = "nama_obat";
            combo.ValueMember = "ID";

            if (isUpdate && modelUpdate != null)
            {
                dtTanggal.Value = modelUpdate.tanggal;
                txtCatatan.Text = modelUpdate.catatan;

                var selectedGejala = detailRiwayatController.GetByRiwayat(modelUpdate.ID)
                                    .Select(d => d.id_gejala).ToHashSet();

                for (int i = 0; i < clbGejala.Items.Count; i++)
                {
                    var g = clbGejala.Items[i] as GejalaModel;
                    if (g != null && selectedGejala.Contains(g.ID))
                        clbGejala.SetItemChecked(i, true);
                }

                var detailObat = transaksiController.GetDetailByTransaksi(
                    transaksiController.GetAll()
                        .FirstOrDefault(t => t.id_riwayat == modelUpdate.ID)?.ID ?? -1);

                foreach (var dt in detailObat)
                {
                    dgvObat.Rows.Add(dt.id_obat, dt.jumlah);
                }
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCatatan.Text))
            {
                MessageBox.Show("Catatan tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            RiwayatKunjunganModel r = new RiwayatKunjunganModel
            {
                tanggal = dtTanggal.Value,
                no_register = no_register,
                catatan = txtCatatan.Text
            };

            int idRiwayat;
            if (isUpdate)
            {
                r.ID = modelUpdate.ID;
                controller.Update(r);
                detailRiwayatController.DeleteByRiwayat(r.ID);
                idRiwayat = r.ID;
            }
            else
            {
                idRiwayat = controller.InsertReturnId(r);
            }

            foreach (var item in clbGejala.CheckedItems)
            {
                if (item is GejalaModel g)
                {
                    foreach (DataGridViewRow row in dgvObat.Rows)
                    {
                        if (row.IsNewRow) continue;
                        if (row.Cells["colObat"].Value == null) continue;

                            int idObat = Convert.ToInt32(row.Cells["colObat"].Value);

                        var detail = new DetailRiwayatModel
                        {
                            id_riwayat = idRiwayat,
                            id_gejala = g.ID,
                            id_obat = idObat
                        };
                        detailRiwayatController.Insert(detail);
                    }
                }
            }

            List<DetailTransaksiModel> detailItems = new List<DetailTransaksiModel>();
            decimal total = 0;

            foreach (DataGridViewRow row in dgvObat.Rows)
            {
                if (row.IsNewRow) continue;
                if (row.Cells["colObat"].Value == null || row.Cells["colJumlah"].Value == null) continue;

                int idObat = Convert.ToInt32(row.Cells["colObat"].Value);
                int jumlah = Convert.ToInt32(row.Cells["colJumlah"].Value);
                var obat = semuaObat.FirstOrDefault(o => o.ID == idObat);
                if (obat == null) continue;

                decimal subtotal = obat.harga * jumlah;
                total += subtotal;

                detailItems.Add(new DetailTransaksiModel
                {
                    id_obat = idObat,
                    jumlah = jumlah,
                    harga = obat.harga,
                    nama_obat = obat.nama_obat,
                    catatan = ""
                });
            }

            if (!isUpdate)
            {
                transaksiController.InsertReturnId(new TransaksiModel
                {
                    tanggal = dtTanggal.Value,
                    id_riwayat = idRiwayat,
                    total = total,
                    DetailItems = detailItems
                });
            }

            MessageBox.Show(isUpdate ? "Data berhasil diperbarui." : "Data berhasil ditambahkan.", "Informasi", MessageBoxButtons.OK);
            this.Close();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}