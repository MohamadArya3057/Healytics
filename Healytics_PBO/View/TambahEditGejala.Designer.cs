﻿namespace Healytics_PBO.View
{
    partial class TambahEditGejala
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
            label2 = new Label();
            label1 = new Label();
            btnSimpan = new Button();
            txtNamagGejala = new TextBox();
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
            btnBatal.Location = new Point(468, 453);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(108, 45);
            btnBatal.TabIndex = 24;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = false;
            btnBatal.Click += btnBatal_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Bahnschrift SemiBold", 18F, FontStyle.Bold);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(460, 335);
            label2.Name = "label2";
            label2.Size = new Size(197, 43);
            label2.TabIndex = 18;
            label2.Text = "Nama Obat";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold", 30F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(19, 62, 135);
            label1.Location = new Point(460, 156);
            label1.Name = "label1";
            label1.Size = new Size(622, 72);
            label1.TabIndex = 17;
            label1.Text = "DATA GEJALA PASIEN";
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.ForestGreen;
            btnSimpan.FlatAppearance.BorderColor = Color.ForestGreen;
            btnSimpan.FlatAppearance.BorderSize = 3;
            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnSimpan.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSimpan.ForeColor = Color.Honeydew;
            btnSimpan.Location = new Point(603, 453);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(120, 45);
            btnSimpan.TabIndex = 16;
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // txtNamagGejala
            // 
            txtNamagGejala.BackColor = Color.FromArgb(196, 227, 242);
            txtNamagGejala.BorderStyle = BorderStyle.FixedSingle;
            txtNamagGejala.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNamagGejala.ForeColor = Color.SteelBlue;
            txtNamagGejala.Location = new Point(785, 335);
            txtNamagGejala.Name = "txtNamagGejala";
            txtNamagGejala.Size = new Size(500, 41);
            txtNamagGejala.TabIndex = 14;
            // 
            // TambahEditGejala
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.bg;
            ClientSize = new Size(1440, 1024);
            Controls.Add(btnBatal);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSimpan);
            Controls.Add(txtNamagGejala);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TambahEditGejala";
            Text = "TambahEditGejala";
            Load += TambahEditGejala_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBatal;
        private Label label2;
        private Label label1;
        private Button btnSimpan;
        private TextBox txtNamagGejala;
    }
}