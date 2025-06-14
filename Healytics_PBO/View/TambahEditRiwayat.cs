using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private DetailTransaksiController detailTransaksiController = new DetailTransaksiController();

        private List<GejalaModel> semuaGejala;
        private List<ObatModel> semuaObat;

        public TambahEditRiwayat(int no_register, string nama_pasien, string nama_desa)
        {
            InitializeComponent();
            this.no_register = no_register;
            this.nama_pasien = nama_pasien;
            this.nama_desa = nama_desa;

            btnSimpan.Click += btnSimpan_Click;
            this.Load += TambahEditRiwayat_Load;

            this.Dock = DockStyle.Fill;
        }


        private void TambahEditRiwayat_Load(object sender, EventArgs e)
        {
            semuaGejala = gejalaController.GetAll();
            clbGejala.Items.Clear();
            foreach (var g in semuaGejala)
            {
                clbGejala.Items.Add(g);
            }
            clbGejala.DisplayMember = "nama_gejala";

            semuaObat = obatController.GetAll();
            var combo = (DataGridViewComboBoxColumn)dgvObat.Columns["colObat"];
            combo.DataSource = semuaObat;
            combo.DisplayMember = "nama_obat";
            combo.ValueMember = "ID";
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (txtCatatan.Text.Trim() == "")
            {
                MessageBox.Show("Catatan tidak boleh kosong.");
                return;
            }

            RiwayatKunjunganModel r = new RiwayatKunjunganModel
            {
                tanggal = dtTanggal.Value,
                no_register = no_register,
                catatan = txtCatatan.Text
            };

            int idRiwayat = controller.InsertReturnId(r);

            foreach (var item in clbGejala.CheckedItems)
            {
                GejalaModel g = item as GejalaModel;
                if (g == null) continue;

            foreach (DataGridViewRow row in dgvObat.Rows)
                {
                    if (row.IsNewRow) continue;
                    if (row.Cells["colObat"].Value == null || row.Cells["colJumlah"].Value == null) continue;

                    int idObat = Convert.ToInt32(row.Cells["colObat"].Value);

                    DetailRiwayatModel d = new DetailRiwayatModel
                    {
                        id_riwayat = idRiwayat,
                        id_gejala = g.ID,
                        id_obat = idObat
                    };

                    detailRiwayatController.Insert(d);
                }
            }

            MessageBox.Show("Riwayat kunjungan berhasil ditambahkan.", "Sukses");
            this.Close();
        }
    }
}
