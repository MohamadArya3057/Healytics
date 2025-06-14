using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Healytics_PBO.Model;
using Healytics_PBO.Controller;

namespace Healytics_PBO.View
{
    public partial class Transaksi : Form
    {
        private IRepository<TransaksiModel> controller;
        public Transaksi()
        {
            InitializeComponent();
            controller = new TransaksiController();

            this.Load += Transaksi_Load;
            tbTransaksi.CellContentClick += TbTransaksi_CellContentClick;
        }

        private void TbTransaksi_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var id = Convert.ToInt32(tbTransaksi.Rows[e.RowIndex].Cells["Id"].Value);

            if (tbTransaksi.Columns[e.ColumnIndex].Name == "Update")
            {
                string keluhan = tbTransaksi.Rows[e.RowIndex].Cells["Keluhan"].Value.ToString();
                int jumlah = Convert.ToInt32(tbTransaksi.Rows[e.RowIndex].Cells["Jumlah"].Value);
                decimal total = Convert.ToDecimal(tbTransaksi.Rows[e.RowIndex].Cells["Total"].Value);

                if (MessageBox.Show("Update data ini?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controller.Update(id, keluhan, jumlah, total);
                    LoadData();
                }
            }
            else if (tbTransaksi.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
            tbTransaksi.DataSource = null;
            tbTransaksi.Columns.Clear();
            tbTransaksi.DataSource = data;

            var updateButton = new DataGridViewButtonColumn
            {
                Name = "UpdateButton",
                HeaderText = "",
                Text = "Update",
                UseColumnTextForButtonValue = true
            };
            tbTransaksi.Columns.Add(updateButton);

            var deleteButton = new DataGridViewButtonColumn
            {
                Name = "DeleteButton",
                HeaderText = "",
                Text = "Delete",
                UseColumnTextForButtonValue = true
            };
            tbTransaksi.Columns.Add(deleteButton);
        }
    }
}
