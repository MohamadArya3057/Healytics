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
    public partial class Alat : Form
    {
        private AlatController controller = new AlatController();
        private List<AlatModel> semuaAlat;

        public Alat()
        {
            InitializeComponent();
        }

        private void Alat_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            semuaAlat = controller.GetAll();
            TampilkanData(semuaAlat);
            tbAlat.Height = tbAlat.ColumnHeadersHeight + (tbAlat.Rows.Count * tbAlat.RowTemplate.Height) + 10;
        }

        private void TampilkanData(List<AlatModel> data)
        {
            tbAlat.Rows.Clear();
            foreach (var a in data)
            {
                tbAlat.Rows.Add(a.ID, a.nama_alat, a.stock);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.ToLower();
            var hasil = semuaAlat.Where(a => a.nama_alat.ToLower().Contains(keyword)).ToList();
            TampilkanData(hasil);
        }

        private void tbAlat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(tbAlat.Rows[e.RowIndex].Cells["ID"].Value);

                if (tbAlat.Columns[e.ColumnIndex].Name == "btnUpdate")
                {
                    AlatModel alat = semuaAlat.First(x => x.ID == id);
                    TambahEditAlat form = new TambahEditAlat("Update");
                    form.alat = alat;
                    form.MdiParent = this.MdiParent;
                    form.Dock = DockStyle.Fill;
                    form.FormClosed += (s, args) => LoadData();
                    form.Show();
                }
                else if (tbAlat.Columns[e.ColumnIndex].Name == "btnDelete")
                {
                    var result = MessageBox.Show("Apakah anda yakin ingin menghapus data?", "Konfirmasi", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        controller.Delete(id);
                        LoadData();
                    }
                }
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            TambahEditAlat form = new TambahEditAlat("Tambah");
            form.MdiParent = this.MdiParent;
            form.Dock = DockStyle.Fill;
            form.FormClosed += (s, args) => LoadData();
            form.Show();
        }
    }
}
