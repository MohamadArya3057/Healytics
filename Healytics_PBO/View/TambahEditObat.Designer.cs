namespace Healytics_PBO.View
{
    partial class TambahEditObat
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
            txtNamaObat = new TextBox();
            comboKategori = new ComboBox();
            btnSimpan = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtStok = new TextBox();
            txtHarga = new TextBox();
            btnBatal = new Button();
            SuspendLayout();
            // 
            // txtNamaObat
            // 
            txtNamaObat.BackColor = Color.FromArgb(196, 227, 242);
            txtNamaObat.BorderStyle = BorderStyle.FixedSingle;
            txtNamaObat.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNamaObat.ForeColor = Color.SteelBlue;
            txtNamaObat.Location = new Point(759, 346);
            txtNamaObat.Name = "txtNamaObat";
            txtNamaObat.Size = new Size(500, 41);
            txtNamaObat.TabIndex = 0;
            // 
            // comboKategori
            // 
            comboKategori.BackColor = Color.FromArgb(196, 227, 242);
            comboKategori.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboKategori.ForeColor = Color.SteelBlue;
            comboKategori.FormattingEnabled = true;
            comboKategori.Location = new Point(759, 436);
            comboKategori.Name = "comboKategori";
            comboKategori.Size = new Size(500, 42);
            comboKategori.TabIndex = 4;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.ForestGreen;
            btnSimpan.FlatAppearance.BorderColor = Color.ForestGreen;
            btnSimpan.FlatAppearance.BorderSize = 3;
            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnSimpan.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSimpan.ForeColor = Color.Honeydew;
            btnSimpan.Location = new Point(563, 761);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(120, 45);
            btnSimpan.TabIndex = 5;
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold", 30F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(19, 62, 135);
            label1.Location = new Point(434, 167);
            label1.Name = "label1";
            label1.Size = new Size(331, 72);
            label1.TabIndex = 6;
            label1.Text = "DATA OBAT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Bahnschrift SemiBold", 18F, FontStyle.Bold);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(434, 346);
            label2.Name = "label2";
            label2.Size = new Size(197, 43);
            label2.TabIndex = 7;
            label2.Text = "Nama Obat";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Bahnschrift SemiBold", 18F, FontStyle.Bold);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(434, 436);
            label3.Name = "label3";
            label3.Size = new Size(155, 43);
            label3.TabIndex = 8;
            label3.Text = "Kategori";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Bahnschrift SemiBold", 18F, FontStyle.Bold);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(434, 526);
            label4.Name = "label4";
            label4.Size = new Size(115, 43);
            label4.TabIndex = 9;
            label4.Text = "Harga";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Bahnschrift SemiBold", 18F, FontStyle.Bold);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(434, 616);
            label5.Name = "label5";
            label5.Size = new Size(110, 43);
            label5.TabIndex = 10;
            label5.Text = "Stock";
            // 
            // txtStok
            // 
            txtStok.BackColor = Color.FromArgb(196, 227, 242);
            txtStok.BorderStyle = BorderStyle.FixedSingle;
            txtStok.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStok.ForeColor = Color.SteelBlue;
            txtStok.Location = new Point(759, 616);
            txtStok.Name = "txtStok";
            txtStok.Size = new Size(500, 41);
            txtStok.TabIndex = 11;
            // 
            // txtHarga
            // 
            txtHarga.BackColor = Color.FromArgb(196, 227, 242);
            txtHarga.BorderStyle = BorderStyle.FixedSingle;
            txtHarga.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHarga.ForeColor = Color.SteelBlue;
            txtHarga.Location = new Point(759, 526);
            txtHarga.Name = "txtHarga";
            txtHarga.Size = new Size(500, 41);
            txtHarga.TabIndex = 12;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.Gray;
            btnBatal.FlatAppearance.BorderColor = Color.Gray;
            btnBatal.FlatAppearance.BorderSize = 3;
            btnBatal.FlatStyle = FlatStyle.Flat;
            btnBatal.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBatal.ForeColor = SystemColors.ButtonFace;
            btnBatal.Location = new Point(428, 761);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(108, 45);
            btnBatal.TabIndex = 13;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = false;
            btnBatal.Click += btnBatal_Click;
            // 
            // TambahEditObat
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.bg;
            ClientSize = new Size(1440, 1024);
            Controls.Add(btnBatal);
            Controls.Add(txtHarga);
            Controls.Add(txtStok);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSimpan);
            Controls.Add(comboKategori);
            Controls.Add(txtNamaObat);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TambahEditObat";
            Text = "TambahEditObat";
            Load += TambahEditObat_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNamaObat;
        private ComboBox comboKategori;
        private Button btnSimpan;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtStok;
        private TextBox txtHarga;
        private Button btnBatal;
    }
}