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

        private readonly RiwayatKunjunganController controller = new RiwayatKunjunganController();
        private readonly GejalaController gejalaController = new GejalaController();
        private readonly ObatController obatController = new ObatController();
        private readonly DetailRiwayatController detailRiwayatController = new DetailRiwayatController();
        private readonly DetailTransaksiController detailTransaksiController = new DetailTransaksiController();

        private List<GejalaModel> semuaGejala = new List<GejalaModel>();
        private List<ObatModel> semuaObat = new List<ObatModel>();

        public TambahEditRiwayat(int no_register, string nama_pasien, string nama_desa)
        {
            InitializeComponent();
            this.no_register = no_register;
            this.nama_pasien = nama_pasien;
            this.nama_desa = nama_desa;

            this.Load += TambahEditRiwayat_Load;
            btnSimpan.Click += btnSimpan_Click;
            btnBatal.Click += (s, e) => this.Close();

            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
        }

        private void TambahEditRiwayat_Load(object? sender, EventArgs e)
        {
            semuaGejala = gejalaController.GetAll();
            clbGejala.Items.Clear();
            foreach (var g in semuaGejala)
                clbGejala.Items.Add(g, false);
            clbGejala.DisplayMember = "nama_gejala";

            semuaObat = obatController.GetAll();
            var combo = dgvObat.Columns["colObat"] as DataGridViewComboBoxColumn;
            if (combo != null)
            {
                combo.DataSource = semuaObat;
                combo.DisplayMember = "nama_obat";
                combo.ValueMember = "ID";
            }

            dgvObat.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void btnSimpan_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCatatan.Text))
            {
                MessageBox.Show("Catatan tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var riwayat = new RiwayatKunjunganModel
            {
                tanggal = dtTanggal.Value,
                no_register = no_register,
                catatan = txtCatatan.Text
            };

            int idRiwayat = controller.InsertReturnId(riwayat);

            foreach (var item in clbGejala.CheckedItems)
            {
                if (item is GejalaModel g)
                {
                    var detail = new DetailRiwayatModel
                    {
                        id_riwayat = idRiwayat,
                        id_gejala = g.ID
                    };
                    detailRiwayatController.Insert(detail);
                }
            }

            foreach (DataGridViewRow row in dgvObat.Rows)
            {
                if (row.IsNewRow) continue;
                if (row.Cells["colObat"].Value == null || row.Cells["colJumlah"].Value == null) continue;

                int idObat = Convert.ToInt32(row.Cells["colObat"].Value);
                int jumlah = Convert.ToInt32(row.Cells["colJumlah"].Value);
                var obat = semuaObat.FirstOrDefault(o => o.ID == idObat);
                if (obat == null) continue;

                var dt = new DetailTransaksiModel
                {
                    id_transaksi = idRiwayat,
                    id_obat = idObat,
                    nama_obat = obat.nama_obat,
                    harga = obat.harga,
                    jumlah = jumlah,
                    catatan = ""
                };
                detailTransaksiController.Insert(dt);
            }

            MessageBox.Show("Riwayat kunjungan berhasil ditambahkan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}