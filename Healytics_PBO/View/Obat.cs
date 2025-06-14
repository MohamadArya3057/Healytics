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
    public partial class Obat : Form
    {
        private ObatController controller = new ObatController();
        private List<ObatModel> semuaObat;

        public Obat()
        {
            InitializeComponent();
        }

        private void Obat_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            semuaObat = controller.GetAll();
            TampilkanData(semuaObat);
            tbObat.Height = tbObat.ColumnHeadersHeight + (tbObat.Rows.Count * tbObat.RowTemplate.Height);
        }

        private void TampilkanData(List<ObatModel> data)
        {
            tbObat.Rows.Clear();
            foreach (var o in data)
            {
                tbObat.Rows.Add(o.ID, o.nama_obat, o.nama_kategori, o.stock, o.harga);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.ToLower();
            var hasil = semuaObat.Where(o => o.nama_obat.ToLower().Contains(keyword)).ToList();
            TampilkanData(hasil);
        }

        private void tbObat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(tbObat.Rows[e.RowIndex].Cells["ID"].Value);

                if (tbObat.Columns[e.ColumnIndex].Name == "btnUpdate")
                {
                    ObatModel o = semuaObat.First(x => x.ID == id);
                    TambahEditObat form = new TambahEditObat("Update");
                    form.obat = o;
                    form.ShowDialog();
                    LoadData();
                }
                else if (tbObat.Columns[e.ColumnIndex].Name == "btnDelete")
                {
                    var result = MessageBox.Show("Apakah anda yakin ingin menghapus data?", "Konfirmasi", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        new ObatController().Delete(id);
                        LoadData();
                    }
                }
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            TambahEditObat form = new TambahEditObat("Tambah");
            form.MdiParent = this.MdiParent;
            form.Dock = DockStyle.Fill;
            form.Show();
        }
    }
}
