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
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnSearch;
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
            txtSearch = new TextBox();
            btnSearch = new Button();
            txtTanggal = new TextBox();
            txtNama = new TextBox();
            txtDesa = new TextBox();
            txtKeterangan = new TextBox();
            txtKeluhan = new TextBox();
            btnTambah = new Button();
            dgv = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(1198, 79);
            txtSearch.Margin = new Padding(2, 2, 2, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Cari Nama Pasien";
            txtSearch.Size = new Size(121, 27);
            txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(1323, 79);
            btnSearch.Margin = new Padding(2, 2, 2, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(64, 25);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Cari";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += BtnSearch_Click;
            // 
            // txtTanggal
            // 
            txtTanggal.Location = new Point(404, 124);
            txtTanggal.Margin = new Padding(2, 2, 2, 2);
            txtTanggal.Name = "txtTanggal";
            txtTanggal.PlaceholderText = "Tanggal";
            txtTanggal.Size = new Size(97, 27);
            txtTanggal.TabIndex = 2;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(584, 125);
            txtNama.Margin = new Padding(2, 2, 2, 2);
            txtNama.Name = "txtNama";
            txtNama.PlaceholderText = "Nama Pasien";
            txtNama.Size = new Size(97, 27);
            txtNama.TabIndex = 3;
            // 
            // txtDesa
            // 
            txtDesa.Location = new Point(756, 126);
            txtDesa.Margin = new Padding(2, 2, 2, 2);
            txtDesa.Name = "txtDesa";
            txtDesa.PlaceholderText = "Desa";
            txtDesa.Size = new Size(97, 27);
            txtDesa.TabIndex = 4;
            // 
            // txtKeterangan
            // 
            txtKeterangan.Location = new Point(963, 125);
            txtKeterangan.Margin = new Padding(2, 2, 2, 2);
            txtKeterangan.Name = "txtKeterangan";
            txtKeterangan.PlaceholderText = "Keterangan";
            txtKeterangan.Size = new Size(97, 27);
            txtKeterangan.TabIndex = 5;
            // 
            // txtKeluhan
            // 
            txtKeluhan.Location = new Point(1145, 126);
            txtKeluhan.Margin = new Padding(2, 2, 2, 2);
            txtKeluhan.Name = "txtKeluhan";
            txtKeluhan.PlaceholderText = "Keluhan";
            txtKeluhan.Size = new Size(97, 27);
            txtKeluhan.TabIndex = 6;
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(1293, 126);
            btnTambah.Margin = new Padding(2, 2, 2, 2);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(80, 25);
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
            dgv.Location = new Point(389, 170);
            dgv.Margin = new Padding(2, 2, 2, 2);
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(1010, 843);
            dgv.TabIndex = 8;
            // 
            // LaporanKunjungan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg;
            ClientSize = new Size(1440, 1024);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(txtTanggal);
            Controls.Add(txtNama);
            Controls.Add(txtDesa);
            Controls.Add(txtKeterangan);
            Controls.Add(txtKeluhan);
            Controls.Add(btnTambah);
            Controls.Add(dgv);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 2, 2, 2);
            Name = "LaporanKunjungan";
            Text = "LaporanKunjungan";
            Load += LaporanKunjungan_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}