namespace NEW_PROJEKAN_PBO
{
    partial class formPasien2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textNama = new TextBox();
            textAlamat = new TextBox();
            cmbJenisKelamin = new ComboBox();
            btnTambah = new Button();
            btnUbah = new Button();
            btnHapus = new Button();
            dgvDataPasien = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDataPasien).BeginInit();
            SuspendLayout();
            // 
            // textNama
            // 
            textNama.Location = new Point(425, 152);
            textNama.Name = "textNama";
            textNama.Size = new Size(382, 23);
            textNama.TabIndex = 0;
            // 
            // textAlamat
            // 
            textAlamat.Location = new Point(425, 244);
            textAlamat.Name = "textAlamat";
            textAlamat.Size = new Size(382, 23);
            textAlamat.TabIndex = 1;
            // 
            // cmbJenisKelamin
            // 
            cmbJenisKelamin.FormattingEnabled = true;
            cmbJenisKelamin.Location = new Point(425, 302);
            cmbJenisKelamin.Name = "cmbJenisKelamin";
            cmbJenisKelamin.Size = new Size(174, 23);
            cmbJenisKelamin.TabIndex = 2;
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(524, 379);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(75, 23);
            btnTambah.TabIndex = 3;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += btnTambah_Click;
            // 
            // btnUbah
            // 
            btnUbah.Location = new Point(505, 464);
            btnUbah.Name = "btnUbah";
            btnUbah.Size = new Size(75, 23);
            btnUbah.TabIndex = 4;
            btnUbah.Text = "Ubah";
            btnUbah.UseVisualStyleBackColor = true;
            btnUbah.Click += btnUbah_Click;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(348, 419);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(75, 23);
            btnHapus.TabIndex = 5;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            btnHapus.Click += btnHapus_Click;
            // 
            // dgvDataPasien
            // 
            dgvDataPasien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDataPasien.Location = new Point(833, 90);
            dgvDataPasien.Name = "dgvDataPasien";
            dgvDataPasien.Size = new Size(644, 518);
            dgvDataPasien.TabIndex = 6;
            dgvDataPasien.CellContentClick += dgvDataPasien_CellContentClick;
            // 
            // formPasien2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1670, 1000);
            Controls.Add(dgvDataPasien);
            Controls.Add(btnHapus);
            Controls.Add(btnUbah);
            Controls.Add(btnTambah);
            Controls.Add(cmbJenisKelamin);
            Controls.Add(textAlamat);
            Controls.Add(textNama);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formPasien2";
            Text = "Pasien2";
            Load += pasien2form;
            ((System.ComponentModel.ISupportInitialize)dgvDataPasien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textNama;
        private TextBox textAlamat;
        private ComboBox cmbJenisKelamin;
        private Button btnTambah;
        private Button btnUbah;
        private Button btnHapus;
        private DataGridView dgvDataPasien;
    }
}