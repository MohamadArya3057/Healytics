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
        private string nama_pasien;
        private string nama_desa;

        public RiwayatKunjungan()
        {
            InitializeComponent();
        }

        public RiwayatKunjungan(int no_register, string nama_pasien, string nama_desa) : this()
        {
            idPasienFilter = no_register;
            this.nama_pasien = nama_pasien;
            this.nama_desa = nama_desa;

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
                var gejalaList = controller.GetGejalaByRiwayat(r.ID).Select(g => g.nama_gejala);
                var obatList = controller.GetObatByRiwayat(r.ID).Select(o => o.nama_obat);

                dgKunjungan.Rows.Add(
                    r.ID,
                    r.tanggal.ToShortDateString(),
                    r.catatan,
                    string.Join(", ", gejalaList),
                    string.Join(", ", obatList)
                );
            }

            dgKunjungan.Height = dgKunjungan.ColumnHeadersHeight + (dgKunjungan.Rows.Count * dgKunjungan.RowTemplate.Height);
        }

        private void dgKunjungan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var selectedRow = dgKunjungan.Rows[e.RowIndex];
                int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                var riwayat = semuaKunjungan.FirstOrDefault(r => r.ID == id);

                if (dgKunjungan.Columns[e.ColumnIndex].Name == "btnUpdate" && riwayat != null)
                {
                    var form = new TambahEditRiwayat(riwayat, nama_pasien, nama_desa);
                    form.MdiParent = this.MdiParent;
                    form.Dock = DockStyle.Fill;
                    form.FormClosed += (s, args) => LoadData();
                    form.Show();
                }
                else if (dgKunjungan.Columns[e.ColumnIndex].Name == "btnDelete")
                {
                    var result = MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        controller.Delete(id);
                        LoadData();
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
                var gejalaList = controller.GetGejalaByRiwayat(r.ID).Select(g => g.nama_gejala);
                var obatList = controller.GetObatByRiwayat(r.ID).Select(o => o.nama_obat);

                dgKunjungan.Rows.Add(
                    r.ID,
                    r.tanggal.ToShortDateString(),
                    r.catatan,
                    string.Join(", ", gejalaList),
                    string.Join(", ", obatList)
                );
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            var form = new TambahEditRiwayat(idPasienFilter, nama_pasien, nama_desa);
            form.MdiParent = this.MdiParent;
            form.Dock = DockStyle.Fill;
            form.FormClosed += (s, args) => LoadData();
            form.Show();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}