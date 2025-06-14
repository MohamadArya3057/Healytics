using Healytics_PBO.Controller;
using Healytics_PBO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Healytics_PBO.View
{
    public partial class RiwayatKunjungan : Form
    {
        private RiwayatKunjunganController controller = new RiwayatKunjunganController();
        private List<RiwayatKunjunganModel> semuaKunjungan;
        private int idPasienFilter = -1;

        public RiwayatKunjungan()
        {
            InitializeComponent();
        }

        private string nama_pasien;
        private string nama_desa;

        public RiwayatKunjungan(int no_register, string nama_pasien, string nama_desa) : this()
        {
            idPasienFilter = no_register;
            nama_pasien = nama_pasien;
            nama_desa = nama_desa;

            labelPasien.Text = "Nama: " + nama_pasien;
            labelDesa.Text = "Desa: " + nama_desa;
        }

        private void RiwayatKunjungan_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            semuaKunjungan = controller.GetAll();
            if (idPasienFilter != -1)
            {
                semuaKunjungan = semuaKunjungan
                    .Where(k => k.no_register == idPasienFilter)
                    .ToList();
            }

            dgKunjungan.Rows.Clear();
            foreach (var r in semuaKunjungan)
            {
                dgKunjungan.Rows.Add(r.ID, r.tanggal.ToShortDateString(), r.catatan);
            }
            dgKunjungan.Height = dgKunjungan.ColumnHeadersHeight + (dgKunjungan.Rows.Count * dgKunjungan.RowTemplate.Height);
            dgGejala.Height = dgGejala.ColumnHeadersHeight + (dgGejala.Rows.Count * dgGejala.RowTemplate.Height);
            dgObat.Height = dgObat.ColumnHeadersHeight + (dgObat.Rows.Count * dgObat.RowTemplate.Height);
        }

        private void dgKunjungan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < semuaKunjungan.Count)
            {
                int id = Convert.ToInt32(dgKunjungan.Rows[e.RowIndex].Cells["ID"].Value);
                var riwayat = semuaKunjungan.FirstOrDefault(r => r.ID == id);

                if (riwayat != null)
                {
                    labelPasien.Text = "Nama: " + riwayat.nama_pasien;
                    labelDesa.Text = "Desa: " + riwayat.nama_desa;

                    dgGejala.Rows.Clear();
                    foreach (var gejala in controller.GetGejalaByRiwayat(riwayat.ID))
                    {
                        dgGejala.Rows.Add(gejala.nama_gejala);
                    }

                    dgObat.Rows.Clear();
                    foreach (var obat in controller.GetObatByRiwayat(riwayat.ID))
                    {
                        dgObat.Rows.Add(obat.nama_obat);
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.ToLower();
            var hasil = semuaKunjungan
                .Where(r => r.nama_pasien.ToLower().Contains(keyword) ||
                            r.nama_desa.ToLower().Contains(keyword))
                .ToList();

            dgKunjungan.Rows.Clear();
            foreach (var r in hasil)
            {
                dgKunjungan.Rows.Add(r.ID, r.tanggal.ToShortDateString(), r.catatan);
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            TambahEditRiwayat form = new TambahEditRiwayat(idPasienFilter, nama_pasien, nama_desa);
            form.MdiParent = this.MdiParent;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

    }
}
