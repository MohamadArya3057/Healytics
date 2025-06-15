namespace Healytics_PBO.View
{
    partial class SideBar
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
            components = new System.ComponentModel.Container();
            panelSide = new FlowLayoutPanel();
            panelPasien = new Panel();
            btnPasien = new Button();
            panelObat = new Panel();
            btnObat = new Button();
            panelAlat = new Panel();
            btnAlat = new Button();
            panelGejala = new Panel();
            btnGejala = new Button();
            panelTransaksi = new Panel();
            btnTransaksi = new Button();
            panelLogout = new Panel();
            btnLogout = new Button();
            laporanTransition = new System.Windows.Forms.Timer(components);
            panelSide.SuspendLayout();
            panelPasien.SuspendLayout();
            panelObat.SuspendLayout();
            panelAlat.SuspendLayout();
            panelGejala.SuspendLayout();
            panelTransaksi.SuspendLayout();
            panelLogout.SuspendLayout();
            SuspendLayout();
            // 
            // panelSide
            // 
            panelSide.BackColor = Color.FromArgb(19, 62, 135);
            panelSide.Controls.Add(panelPasien);
            panelSide.Controls.Add(panelObat);
            panelSide.Controls.Add(panelAlat);
            panelSide.Controls.Add(panelGejala);
            panelSide.Controls.Add(panelTransaksi);
            panelSide.Controls.Add(panelLogout);
            panelSide.Location = new Point(5, 101);
            panelSide.Name = "panelSide";
            panelSide.Size = new Size(363, 880);
            panelSide.TabIndex = 0;
            // 
            // panelPasien
            // 
            panelPasien.Controls.Add(btnPasien);
            panelPasien.Location = new Point(3, 3);
            panelPasien.Name = "panelPasien";
            panelPasien.Size = new Size(365, 85);
            panelPasien.TabIndex = 2;
            // 
            // btnPasien
            // 
            btnPasien.BackColor = Color.FromArgb(19, 62, 135);
            btnPasien.Font = new Font("Bahnschrift SemiBold", 14F, FontStyle.Bold);
            btnPasien.ForeColor = SystemColors.ButtonFace;
            btnPasien.Location = new Point(-5, -12);
            btnPasien.Name = "btnPasien";
            btnPasien.Size = new Size(377, 102);
            btnPasien.TabIndex = 1;
            btnPasien.Text = "         PASIEN";
            btnPasien.TextAlign = ContentAlignment.MiddleLeft;
            btnPasien.UseVisualStyleBackColor = false;
            btnPasien.Click += btnPasien_Click;
            // 
            // panelObat
            // 
            panelObat.Controls.Add(btnObat);
            panelObat.Location = new Point(3, 94);
            panelObat.Name = "panelObat";
            panelObat.Size = new Size(365, 85);
            panelObat.TabIndex = 3;
            // 
            // btnObat
            // 
            btnObat.BackColor = Color.FromArgb(19, 62, 135);
            btnObat.Font = new Font("Bahnschrift SemiBold", 14F, FontStyle.Bold);
            btnObat.ForeColor = SystemColors.ButtonFace;
            btnObat.Location = new Point(-5, -12);
            btnObat.Name = "btnObat";
            btnObat.Size = new Size(377, 102);
            btnObat.TabIndex = 1;
            btnObat.Text = "         OBAT";
            btnObat.TextAlign = ContentAlignment.MiddleLeft;
            btnObat.UseVisualStyleBackColor = false;
            btnObat.Click += btnObat_Click;
            // 
            // panelAlat
            // 
            panelAlat.Controls.Add(btnAlat);
            panelAlat.Location = new Point(3, 185);
            panelAlat.Name = "panelAlat";
            panelAlat.Size = new Size(365, 85);
            panelAlat.TabIndex = 4;
            // 
            // btnAlat
            // 
            btnAlat.BackColor = Color.FromArgb(19, 62, 135);
            btnAlat.Font = new Font("Bahnschrift SemiBold", 14F, FontStyle.Bold);
            btnAlat.ForeColor = SystemColors.ButtonFace;
            btnAlat.Location = new Point(-5, -12);
            btnAlat.Name = "btnAlat";
            btnAlat.Size = new Size(377, 102);
            btnAlat.TabIndex = 1;
            btnAlat.Text = "         ALAT";
            btnAlat.TextAlign = ContentAlignment.MiddleLeft;
            btnAlat.UseVisualStyleBackColor = false;
            btnAlat.Click += btnAlat_Click;
            // 
            // panelGejala
            // 
            panelGejala.Controls.Add(btnGejala);
            panelGejala.Location = new Point(3, 276);
            panelGejala.Name = "panelGejala";
            panelGejala.Size = new Size(365, 85);
            panelGejala.TabIndex = 6;
            // 
            // btnGejala
            // 
            btnGejala.BackColor = Color.FromArgb(19, 62, 135);
            btnGejala.Font = new Font("Bahnschrift SemiBold", 14F, FontStyle.Bold);
            btnGejala.ForeColor = SystemColors.ButtonFace;
            btnGejala.Location = new Point(-5, -12);
            btnGejala.Name = "btnGejala";
            btnGejala.Size = new Size(377, 102);
            btnGejala.TabIndex = 1;
            btnGejala.Text = "         GEJALA";
            btnGejala.TextAlign = ContentAlignment.MiddleLeft;
            btnGejala.UseVisualStyleBackColor = false;
            btnGejala.Click += btnGejala_Click;
            // 
            // panelTransaksi
            // 
            panelTransaksi.Controls.Add(btnTransaksi);
            panelTransaksi.Location = new Point(3, 367);
            panelTransaksi.Name = "panelTransaksi";
            panelTransaksi.Size = new Size(365, 85);
            panelTransaksi.TabIndex = 6;
            // 
            // btnTransaksi
            // 
            btnTransaksi.BackColor = Color.FromArgb(19, 62, 135);
            btnTransaksi.Font = new Font("Bahnschrift SemiBold", 14F, FontStyle.Bold);
            btnTransaksi.ForeColor = SystemColors.ButtonFace;
            btnTransaksi.Location = new Point(-5, -12);
            btnTransaksi.Name = "btnTransaksi";
            btnTransaksi.Size = new Size(377, 102);
            btnTransaksi.TabIndex = 1;
            btnTransaksi.Text = "         TRANSAKSI";
            btnTransaksi.TextAlign = ContentAlignment.MiddleLeft;
            btnTransaksi.UseVisualStyleBackColor = false;
            btnTransaksi.Click += btnTransaksi_Click;
            // 
            // panelLogout
            // 
            panelLogout.Controls.Add(btnLogout);
            panelLogout.Location = new Point(3, 458);
            panelLogout.Name = "panelLogout";
            panelLogout.Size = new Size(365, 85);
            panelLogout.TabIndex = 5;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(19, 62, 135);
            btnLogout.Font = new Font("Bahnschrift SemiBold", 14F, FontStyle.Bold);
            btnLogout.ForeColor = SystemColors.ButtonFace;
            btnLogout.Location = new Point(-5, -12);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(377, 102);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "         LOGOUT";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // SideBar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1418, 968);
            Controls.Add(panelSide);
            Name = "SideBar";
            Text = "SideBar";
            Load += SideBar_Load;
            panelSide.ResumeLayout(false);
            panelPasien.ResumeLayout(false);
            panelObat.ResumeLayout(false);
            panelAlat.ResumeLayout(false);
            panelGejala.ResumeLayout(false);
            panelTransaksi.ResumeLayout(false);
            panelLogout.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel panelSide;
        private Button btnPasien;
        private Panel panelPasien;
        private Panel panelObat;
        private Button btnObat;
        private Panel panelAlat;
        private Button btnAlat;
        private Panel panelLogout;
        private Button btnLogout;
        private Panel panelTransaksi;
        private Button btnTransaksi;
        private System.Windows.Forms.Timer laporanTransition;
        private Panel panelGejala;
        private Button btnGejala;
    }
}