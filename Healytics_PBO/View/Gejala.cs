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
    public partial class Gejala : Form
    {
        private GejalaController controller = new GejalaController();
        private List<GejalaModel> semuaGejala;

        public Gejala()
        {
            InitializeComponent();
        }

        private void Gejala_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            semuaGejala = controller.GetAll();
            TampilkanData(semuaGejala);
            tbGejala.Height = tbGejala.ColumnHeadersHeight + (tbGejala.Rows.Count * tbGejala.RowTemplate.Height) + 10;
        }

        private void TampilkanData(List<GejalaModel> data)
        {
            tbGejala.Rows.Clear();
            foreach (var a in data)
            {
                tbGejala.Rows.Add(a.ID, a.nama_gejala);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.ToLower();
            var hasil = semuaGejala.Where(a => a.nama_gejala.ToLower().Contains(keyword)).ToList();
            TampilkanData(hasil);
        }

        private void tbGejala_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(tbGejala.Rows[e.RowIndex].Cells["ID"].Value);

                if (tbGejala.Columns[e.ColumnIndex].Name == "btnUpdate")
                {
                    GejalaModel gejala = semuaGejala.First(x => x.ID == id);
                    TambahEditGejala form = new TambahEditGejala("Update");
                    form.gejala = gejala;
                    form.MdiParent = this.MdiParent;
                    form.Dock = DockStyle.Fill;
                    form.FormClosed += (s, args) => LoadData();
                    form.Show();
                }
                else if (tbGejala.Columns[e.ColumnIndex].Name == "btnDelete")
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
            TambahEditGejala form = new TambahEditGejala("Tambah");
            form.MdiParent = this.MdiParent;
            form.Dock = DockStyle.Fill;
            form.FormClosed += (s, args) => LoadData();
            form.Show();
        }
    }
}
