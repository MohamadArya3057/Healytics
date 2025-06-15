using System;
using System.Data;
using System.Windows.Forms;

namespace Healytics_PBO.View
{
    public partial class LaporanKunjungan : Form
    {
        private DataTable dt;
        private int nomorUrut = 1;

        public LaporanKunjungan()
        {
            InitializeComponent();
        }

        private void LaporanKunjungan_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;

            dt = new DataTable();
            dt.Columns.Add("Nomor");
            dt.Columns.Add("Tanggal");
            dt.Columns.Add("Nama Pasien");
            dt.Columns.Add("Desa");
            dt.Columns.Add("Keterangan");
            dt.Columns.Add("Keluhan");

            dgv.DataSource = dt;
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTanggal.Text) &&
                !string.IsNullOrWhiteSpace(txtNama.Text) &&
                !string.IsNullOrWhiteSpace(txtDesa.Text) &&
                !string.IsNullOrWhiteSpace(txtKeterangan.Text) &&
                !string.IsNullOrWhiteSpace(txtKeluhan.Text))
            {
                dt.Rows.Add(nomorUrut++, txtTanggal.Text, txtNama.Text, txtDesa.Text, txtKeterangan.Text, txtKeluhan.Text);

                txtTanggal.Text = "";
                txtNama.Text = "";
                txtDesa.Text = "";
                txtKeterangan.Text = "";
                txtKeluhan.Text = "";
            }
            else
            {
                MessageBox.Show("Lengkapi semua kolom!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            if (!string.IsNullOrEmpty(keyword))
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = $"[Nama Pasien] LIKE '%{keyword}%'";
                dgv.DataSource = dv;
            }
            else
            {
                dgv.DataSource = dt;
            }
        }
    }
}