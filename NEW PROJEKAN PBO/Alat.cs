using NEW_PROJEKAN_PBO.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NEW_PROJEKAN_PBO.Model;
using NEW_PROJEKAN_PBO.View;
using Npgsql;

namespace NEW_PROJEKAN_PBO
{
    public partial class Alat : Form
    {
        private readonly AlatController controller = new AlatController();
        private int selectedId = -1;

        public Alat()
        {
            InitializeComponent();
            dgvAlat.CellContentClick -= dgvAlat_CellContentClick; 
            dgvAlat.CellContentClick += dgvAlat_CellContentClick;
            LoadData();
        }

        private void LoadData()
        {
            var alatList = controller.GetAll();

            dgvAlat.Columns.Clear();
            dgvAlat.Rows.Clear();

            dgvAlat.Columns.Add("Id_alat", "ID");
            dgvAlat.Columns.Add("Nama_alat", "Nama Alat");
            dgvAlat.Columns.Add("Stock", "Stock");

            dgvAlat.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "Update",
                HeaderText = "",
                Text = "Update",
                UseColumnTextForButtonValue = true
            });
            dgvAlat.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "Delete",
                HeaderText = "",
                Text = "Delete",
                UseColumnTextForButtonValue = true
            });

            foreach (var alat in alatList)
            {
                dgvAlat.Rows.Add(alat.Id_alat, alat.Nama_alat, alat.Stock);
            }
        }

        private void dgvAlat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var id = Convert.ToInt32(dgvAlat.Rows[e.RowIndex].Cells["Id_alat"].Value);
            var nama = dgvAlat.Rows[e.RowIndex].Cells["Nama_alat"].Value.ToString();
            var stock = Convert.ToInt32(dgvAlat.Rows[e.RowIndex].Cells["Stock"].Value);

            if (dgvAlat.Columns[e.ColumnIndex].Name == "Update")
            {
                var data = new DaftarAlat
                {
                    Id_alat = id,
                    Nama_alat = nama,
                    Stock = stock
                };

                var updateDataAlat = new UpdateDataAlat (data);
                if (updateDataAlat.ShowDialog() == DialogResult.OK)
                {
                    controller.Update(updateDataAlat.AlatData);
                    LoadData();
                }
            }
            else if (dgvAlat.Columns[e.ColumnIndex].Name == "Delete")
            {
                var confirm = MessageBox.Show("Yakin hapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    controller.Delete(id);
                    LoadData();
                    ClearForm();
                }
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            var updateDataAlat = new UpdateDataAlat();
            if (updateDataAlat.ShowDialog() == DialogResult.OK)
            {
                controller.Add(updateDataAlat.AlatData);
                LoadData();
            }
        }

        private void ClearForm()
        {
            textNama.Clear();
            numStock.Value = 0;
            selectedId = -1;
        }
    }
}
