namespace Healytics_PBO.View
{
    partial class TambahEditAlat
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
            btnBatal = new Button();
            txtStok = new TextBox();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnSimpan = new Button();
            txtNamaAlat = new TextBox();
            SuspendLayout();
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.Gray;
            btnBatal.FlatAppearance.BorderColor = Color.Gray;
            btnBatal.FlatAppearance.BorderSize = 3;
            btnBatal.FlatStyle = FlatStyle.Flat;
            btnBatal.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBatal.ForeColor = SystemColors.ButtonFace;
            btnBatal.Location = new Point(460, 538);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(108, 45);
            btnBatal.TabIndex = 24;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = false;
            btnBatal.Click += btnBatal_Click;
            // 
            // txtStok
            // 
            txtStok.BackColor = Color.FromArgb(196, 227, 242);
            txtStok.BorderStyle = BorderStyle.FixedSingle;
            txtStok.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStok.ForeColor = Color.SteelBlue;
            txtStok.Location = new Point(772, 431);
            txtStok.Name = "txtStok";
            txtStok.Size = new Size(500, 41);
            txtStok.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Bahnschrift SemiBold", 18F, FontStyle.Bold);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(447, 431);
            label5.Name = "label5";
            label5.Size = new Size(110, 43);
            label5.TabIndex = 21;
            label5.Text = "Stock";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Bahnschrift SemiBold", 18F, FontStyle.Bold);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(447, 312);
            label2.Name = "label2";
            label2.Size = new Size(187, 43);
            label2.TabIndex = 18;
            label2.Text = "Nama Alat";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold", 30F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(19, 62, 135);
            label1.Location = new Point(434, 167);
            label1.Name = "label1";
            label1.Size = new Size(329, 72);
            label1.TabIndex = 17;
            label1.Text = "DATA ALAT";
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.ForestGreen;
            btnSimpan.FlatAppearance.BorderColor = Color.ForestGreen;
            btnSimpan.FlatAppearance.BorderSize = 3;
            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnSimpan.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSimpan.ForeColor = Color.Honeydew;
            btnSimpan.Location = new Point(595, 538);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(120, 45);
            btnSimpan.TabIndex = 16;
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // txtNamaAlat
            // 
            txtNamaAlat.BackColor = Color.FromArgb(196, 227, 242);
            txtNamaAlat.BorderStyle = BorderStyle.FixedSingle;
            txtNamaAlat.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNamaAlat.ForeColor = Color.SteelBlue;
            txtNamaAlat.Location = new Point(772, 312);
            txtNamaAlat.Name = "txtNamaAlat";
            txtNamaAlat.Size = new Size(500, 41);
            txtNamaAlat.TabIndex = 14;
            // 
            // TambahEditAlat
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.bg;
            ClientSize = new Size(1418, 968);
            Controls.Add(btnBatal);
            Controls.Add(txtStok);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSimpan);
            Controls.Add(txtNamaAlat);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TambahEditAlat";
            Text = "TambahEditAlat";
            Load += TambahEditAlat_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBatal;
        private TextBox txtHarga;
        private TextBox txtStok;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSimpan;
        private ComboBox comboKategori;
        private TextBox txtNamaAlat;
    }
}