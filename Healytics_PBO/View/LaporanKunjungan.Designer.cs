namespace Healytics_PBO.View
{
    partial class LaporanKunjungan
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtTanggal;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtDesa;
        private System.Windows.Forms.TextBox txtKeterangan;
        private System.Windows.Forms.TextBox txtKeluhan;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.DataGridView dgv;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtTanggal = new TextBox();
            txtNama = new TextBox();
            txtDesa = new TextBox();
            txtKeterangan = new TextBox();
            txtKeluhan = new TextBox();
            btnTambah = new Button();
            dgv = new DataGridView();
            tanggal_laporan = new DataGridViewTextBoxColumn();
            nama_pasien = new DataGridViewTextBoxColumn();
            desa = new DataGridViewTextBoxColumn();
            keluhan = new DataGridViewTextBoxColumn();
            keterangan = new DataGridViewTextBoxColumn();
            btnSearch = new Button();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // txtTanggal
            // 
            txtTanggal.Location = new Point(480, 148);
            txtTanggal.Margin = new Padding(2);
            txtTanggal.Name = "txtTanggal";
            txtTanggal.PlaceholderText = "Tanggal";
            txtTanggal.Size = new Size(120, 31);
            txtTanggal.TabIndex = 2;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(730, 148);
            txtNama.Margin = new Padding(2);
            txtNama.Name = "txtNama";
            txtNama.PlaceholderText = "Nama Pasien";
            txtNama.Size = new Size(120, 31);
            txtNama.TabIndex = 3;
            // 
            // txtDesa
            // 
            txtDesa.Location = new Point(102, 212);
            txtDesa.Margin = new Padding(2);
            txtDesa.Name = "txtDesa";
            txtDesa.PlaceholderText = "Desa";
            txtDesa.Size = new Size(120, 31);
            txtDesa.TabIndex = 4;
            // 
            // txtKeterangan
            // 
            txtKeterangan.Location = new Point(355, 212);
            txtKeterangan.Margin = new Padding(2);
            txtKeterangan.Name = "txtKeterangan";
            txtKeterangan.PlaceholderText = "Keterangan";
            txtKeterangan.Size = new Size(120, 31);
            txtKeterangan.TabIndex = 5;
            // 
            // txtKeluhan
            // 
            txtKeluhan.Location = new Point(76, 158);
            txtKeluhan.Margin = new Padding(2);
            txtKeluhan.Name = "txtKeluhan";
            txtKeluhan.PlaceholderText = "Keluhan";
            txtKeluhan.Size = new Size(120, 31);
            txtKeluhan.TabIndex = 6;
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(252, 160);
            btnTambah.Margin = new Padding(2);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(100, 31);
            btnTambah.TabIndex = 7;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += BtnTambah_Click;
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.BackgroundColor = Color.FromArgb(184, 237, 248);
            dgv.ColumnHeadersHeight = 29;
            dgv.Columns.AddRange(new DataGridViewColumn[] { tanggal_laporan, nama_pasien, desa, keluhan, keterangan });
            dgv.Location = new Point(400, 259);
            dgv.Margin = new Padding(2);
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(1003, 1080);
            dgv.TabIndex = 8;
            // 
            // tanggal_laporan
            // 
            tanggal_laporan.HeaderText = "Tanggal";
            tanggal_laporan.MinimumWidth = 8;
            tanggal_laporan.Name = "tanggal_laporan";
            tanggal_laporan.ReadOnly = true;
            // 
            // nama_pasien
            // 
            nama_pasien.HeaderText = "Nama Pasien";
            nama_pasien.MinimumWidth = 8;
            nama_pasien.Name = "nama_pasien";
            nama_pasien.ReadOnly = true;
            // 
            // desa
            // 
            desa.HeaderText = "Desa";
            desa.MinimumWidth = 8;
            desa.Name = "desa";
            desa.ReadOnly = true;
            // 
            // keluhan
            // 
            keluhan.HeaderText = "Keluhan";
            keluhan.MinimumWidth = 8;
            keluhan.Name = "keluhan";
            keluhan.ReadOnly = true;
            // 
            // keterangan
            // 
            keterangan.HeaderText = "Keterangan";
            keterangan.MinimumWidth = 8;
            keterangan.Name = "keterangan";
            keterangan.ReadOnly = true;
            // 
            // btnSearch
            // 
            btnSearch.FlatAppearance.BorderColor = Color.SteelBlue;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.SteelBlue;
            btnSearch.Location = new Point(1338, 194);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(65, 30);
            btnSearch.TabIndex = 14;
            btnSearch.Text = "search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(120, 195, 233);
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(1052, 194);
            txtSearch.Margin = new Padding(2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(350, 30);
            txtSearch.TabIndex = 13;
            // 
            // LaporanKunjungan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg;
            ClientSize = new Size(1440, 1024);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(txtTanggal);
            Controls.Add(txtNama);
            Controls.Add(txtDesa);
            Controls.Add(txtKeterangan);
            Controls.Add(txtKeluhan);
            Controls.Add(btnTambah);
            Controls.Add(dgv);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "LaporanKunjungan";
            Text = "LaporanKunjungan";
            Load += LaporanKunjungan_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private DataGridViewTextBoxColumn tanggal_laporan;
        private DataGridViewTextBoxColumn nama_pasien;
        private DataGridViewTextBoxColumn desa;
        private DataGridViewTextBoxColumn keluhan;
        private DataGridViewTextBoxColumn keterangan;
        private Button btnSearch;
        private TextBox txtSearch;
    }
}