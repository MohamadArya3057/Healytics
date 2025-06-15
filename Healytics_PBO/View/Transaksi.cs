using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Healytics_PBO.Controller;
using Healytics_PBO.Model;

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

        private void Transaksi_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void TbTransaksi_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var id = Convert.ToInt32(tbTransaksi.Rows[e.RowIndex].Cells["ID"].Value);

            if (tbTransaksi.Columns[e.ColumnIndex].Name == "DeleteButton")
            {
                if (MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controller.Delete(id);
                    LoadData();
                }
            }
        }

        private void LoadData()
        {
            var data = controller.GetAll();
            tbTransaksi.DataSource = null;
            tbTransaksi.Columns.Clear();

            tbTransaksi.AutoGenerateColumns = false;
            tbTransaksi.Columns.Add(new DataGridViewTextBoxColumn { Name = "ID", DataPropertyName = "ID", Visible = false });
            tbTransaksi.Columns.Add(new DataGridViewTextBoxColumn { Name = "Tanggal", HeaderText = "Tanggal", DataPropertyName = "tanggal", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            tbTransaksi.Columns.Add(new DataGridViewTextBoxColumn { Name = "Pasien", HeaderText = "Nama Pasien", DataPropertyName = "nama_pasien", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            tbTransaksi.Columns.Add(new DataGridViewTextBoxColumn { Name = "Harga", HeaderText = "Harga", DataPropertyName = "harga", AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells });
            tbTransaksi.Columns.Add(new DataGridViewTextBoxColumn { Name = "Jumlah", HeaderText = "Jumlah", DataPropertyName = "jumlah", AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells });
            tbTransaksi.Columns.Add(new DataGridViewTextBoxColumn { Name = "Total", HeaderText = "Total", DataPropertyName = "total", AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells });

            var deleteButton = new DataGridViewButtonColumn
            {
                Name = "DeleteButton",
                HeaderText = "Action",
                Text = "Delete",
                UseColumnTextForButtonValue = true
            };
            tbTransaksi.Columns.Add(deleteButton);

            tbTransaksi.DataSource = data;

            tbTransaksi.Height = tbTransaksi.ColumnHeadersHeight + tbTransaksi.Rows.Count * tbTransaksi.RowTemplate.Height + 10;
        }
    }
}
