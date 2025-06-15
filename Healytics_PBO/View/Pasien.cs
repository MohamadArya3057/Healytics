using Healytics_PBO.Controller;
using Healytics_PBO.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Healytics_PBO.View
{
    public partial class Pasien : Form
    {
        private PasienController controller = new PasienController();
        private List<PasienModel> semuaPasien;

        public Pasien()
        {
            InitializeComponent();
        }

        private void Pasien_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            semuaPasien = controller.GetAll();
            TampilkanData(semuaPasien);
            tbPasien.Height = tbPasien.ColumnHeadersHeight + (tbPasien.Rows.Count * tbPasien.RowTemplate.Height);
        }

        private void TampilkanData(List<PasienModel> data)
        {
            tbPasien.Rows.Clear();
            foreach (var p in data)
            {
                tbPasien.Rows.Add(p.ID, p.nama_pasien, p.umur, p.nama_desa);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.ToLower();
            var hasil = semuaPasien.Where(p => p.nama_pasien.ToLower().Contains(keyword)).ToList();
            TampilkanData(hasil);
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            TambahEditPasien form = new TambahEditPasien("Tambah");
            form.MdiParent = this.MdiParent;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void tbPasien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(tbPasien.Rows[e.RowIndex].Cells["ID"].Value);
                var pasien = semuaPasien.FirstOrDefault(p => p.ID == id);

                if (tbPasien.Columns[e.ColumnIndex].Name == "btnUpdate")
                {
                    TambahEditPasien form = new TambahEditPasien("Update");
                    form.pasien = pasien;
                    form.ShowDialog();
                    LoadData();
                }
                else if (tbPasien.Columns[e.ColumnIndex].Name == "btnDelete")
                {
                    var result = MessageBox.Show("Apakah yakin ingin menghapus data?", "Konfirmasi", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        controller.Delete(id);
                        LoadData();
                    }
                }
                else if (tbPasien.Columns[e.ColumnIndex].Name == "riwayat")
                {
                    if (pasien != null)
                    {
                        RiwayatKunjungan form = new RiwayatKunjungan(pasien.ID, pasien.nama_pasien, pasien.nama_desa);
                        form.MdiParent = this.MdiParent;
                        form.Dock = DockStyle.Fill;
                        form.Show();
                    }
                }
            }
        }
    }
}
