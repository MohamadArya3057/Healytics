using NEW_PROJEKAN_PBO.Controller;
using NEW_PROJEKAN_PBO.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEW_PROJEKAN_PBO
{
    public partial class Transaksi : Form
    {
        private IController<TransaksiModel> controller;
        public Transaksi()
        {
            InitializeComponent();
            controller = new TransaksiController();

            this.Load += Transaksi_Load;
            dataGridView1.CellContentClick += DataGridView1_CellContentClick;
        }

        private void DataGridView1_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);

            if (dataGridView1.Columns[e.ColumnIndex].Name == "UpdateButton")
            {
                string keluhan = dataGridView1.Rows[e.RowIndex].Cells["Keluhan"].Value.ToString();
                int jumlah = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Jumlah"].Value);
                decimal total = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["Total"].Value);

                if (MessageBox.Show("Update data ini?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controller.Update(id, keluhan, jumlah, total);
                    LoadData();
                }
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "DeleteButton")
            {
                if (MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controller.Delete(id);
                    LoadData();
                }
            }
        }

        private void Transaksi_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var data = controller.GetAll();
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = data;

            var updateButton = new DataGridViewButtonColumn
            {
                Name = "UpdateButton",
                HeaderText = "",
                Text = "Update",
                UseColumnTextForButtonValue = true
            };
            dataGridView1.Columns.Add(updateButton);

            var deleteButton = new DataGridViewButtonColumn
            {
                Name = "DeleteButton",
                HeaderText = "",
                Text = "Delete",
                UseColumnTextForButtonValue = true
            };
            dataGridView1.Columns.Add(deleteButton);
        }
    }
}
