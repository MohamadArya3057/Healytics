namespace Healytics_PBO.View
{
    partial class TambahEditPasien
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
            txtUmur = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnSimpan = new Button();
            txtNamaPasien = new TextBox();
            comboDesa = new ComboBox();
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
            btnBatal.Location = new Point(478, 700);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(108, 45);
            btnBatal.TabIndex = 24;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = false;
            btnBatal.Click += btnBatal_Click;
            // 
            // txtUmur
            // 
            txtUmur.BackColor = Color.FromArgb(196, 227, 242);
            txtUmur.BorderStyle = BorderStyle.FixedSingle;
            txtUmur.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUmur.ForeColor = Color.SteelBlue;
            txtUmur.Location = new Point(796, 472);
            txtUmur.Name = "txtUmur";
            txtUmur.Size = new Size(500, 41);
            txtUmur.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Bahnschrift SemiBold", 18F, FontStyle.Bold);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(471, 562);
            label5.Name = "label5";
            label5.Size = new Size(100, 43);
            label5.TabIndex = 21;
            label5.Text = "Desa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Bahnschrift SemiBold", 18F, FontStyle.Bold);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(471, 472);
            label4.Name = "label4";
            label4.Size = new Size(109, 43);
            label4.TabIndex = 20;
            label4.Text = "Umur";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Bahnschrift SemiBold", 18F, FontStyle.Bold);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(471, 383);
            label2.Name = "label2";
            label2.Size = new Size(230, 43);
            label2.TabIndex = 18;
            label2.Text = "Nama Pasien";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold", 30F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(19, 62, 135);
            label1.Location = new Point(471, 204);
            label1.Name = "label1";
            label1.Size = new Size(331, 72);
            label1.TabIndex = 17;
            label1.Text = "DATA OBAT";
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.ForestGreen;
            btnSimpan.FlatAppearance.BorderColor = Color.ForestGreen;
            btnSimpan.FlatAppearance.BorderSize = 3;
            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnSimpan.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSimpan.ForeColor = Color.Honeydew;
            btnSimpan.Location = new Point(613, 700);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(120, 45);
            btnSimpan.TabIndex = 16;
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // txtNamaPasien
            // 
            txtNamaPasien.BackColor = Color.FromArgb(196, 227, 242);
            txtNamaPasien.BorderStyle = BorderStyle.FixedSingle;
            txtNamaPasien.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNamaPasien.ForeColor = Color.SteelBlue;
            txtNamaPasien.Location = new Point(796, 383);
            txtNamaPasien.Name = "txtNamaPasien";
            txtNamaPasien.Size = new Size(500, 41);
            txtNamaPasien.TabIndex = 14;
            // 
            // comboDesa
            // 
            comboDesa.BackColor = Color.FromArgb(196, 227, 242);
            comboDesa.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboDesa.ForeColor = Color.SteelBlue;
            comboDesa.FormattingEnabled = true;
            comboDesa.Location = new Point(796, 562);
            comboDesa.Name = "comboDesa";
            comboDesa.Size = new Size(500, 42);
            comboDesa.TabIndex = 25;
            // 
            // TambahEditPasien
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.bg;
            ClientSize = new Size(1440, 1024);
            Controls.Add(comboDesa);
            Controls.Add(btnBatal);
            Controls.Add(txtUmur);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSimpan);
            Controls.Add(txtNamaPasien);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TambahEditPasien";
            Text = "TambahEditPasien";
            Load += TambahEditPasien_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBatal;
        private TextBox txtUmur;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private Button btnSimpan;
        private TextBox txtNamaPasien;
        private ComboBox comboDesa;
    }
}