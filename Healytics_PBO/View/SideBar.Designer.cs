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
            panelTransaksi = new Panel();
            btnTransaksi = new Button();
            LaporanContainer = new FlowLayoutPanel();
            panelLaporan = new Panel();
            btnLaporan = new Button();
            panelKunjungan = new Panel();
            btnKunjungan = new Button();
            panelKeuangan = new Panel();
            btnKeuangan = new Button();
            panelLogout = new Panel();
            btnLogout = new Button();
            laporanTransition = new System.Windows.Forms.Timer(components);
            panelSide.SuspendLayout();
            panelPasien.SuspendLayout();
            panelObat.SuspendLayout();
            panelAlat.SuspendLayout();
            panelTransaksi.SuspendLayout();
            LaporanContainer.SuspendLayout();
            panelLaporan.SuspendLayout();
            panelKunjungan.SuspendLayout();
            panelKeuangan.SuspendLayout();
            panelLogout.SuspendLayout();
            SuspendLayout();
            // 
            // panelSide
            // 
            panelSide.BackColor = Color.FromArgb(19, 62, 135);
            panelSide.Controls.Add(panelPasien);
            panelSide.Controls.Add(panelObat);
            panelSide.Controls.Add(panelAlat);
            panelSide.Controls.Add(panelTransaksi);
            panelSide.Controls.Add(LaporanContainer);
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
            // panelTransaksi
            // 
            panelTransaksi.Controls.Add(btnTransaksi);
            panelTransaksi.Location = new Point(3, 276);
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
            // LaporanContainer
            // 
            LaporanContainer.BackColor = Color.FromArgb(41, 70, 138);
            LaporanContainer.Controls.Add(panelLaporan);
            LaporanContainer.Controls.Add(panelKunjungan);
            LaporanContainer.Controls.Add(panelKeuangan);
            LaporanContainer.Location = new Point(3, 367);
            LaporanContainer.Name = "LaporanContainer";
            LaporanContainer.Size = new Size(365, 85);
            LaporanContainer.TabIndex = 7;
            // 
            // panelLaporan
            // 
            panelLaporan.Controls.Add(btnLaporan);
            panelLaporan.Location = new Point(3, 3);
            panelLaporan.Name = "panelLaporan";
            panelLaporan.Size = new Size(365, 85);
            panelLaporan.TabIndex = 6;
            // 
            // btnLaporan
            // 
            btnLaporan.BackColor = Color.FromArgb(19, 62, 135);
            btnLaporan.Font = new Font("Bahnschrift SemiBold", 14F, FontStyle.Bold);
            btnLaporan.ForeColor = SystemColors.ButtonFace;
            btnLaporan.Location = new Point(-5, -12);
            btnLaporan.Name = "btnLaporan";
            btnLaporan.Size = new Size(377, 102);
            btnLaporan.TabIndex = 1;
            btnLaporan.Text = "         LAPORAN";
            btnLaporan.TextAlign = ContentAlignment.MiddleLeft;
            btnLaporan.UseVisualStyleBackColor = false;
            btnLaporan.Click += btnLaporan_Click;
            // 
            // panelKunjungan
            // 
            panelKunjungan.Controls.Add(btnKunjungan);
            panelKunjungan.Location = new Point(3, 94);
            panelKunjungan.Name = "panelKunjungan";
            panelKunjungan.Size = new Size(365, 85);
            panelKunjungan.TabIndex = 8;
            // 
            // btnKunjungan
            // 
            btnKunjungan.BackColor = Color.FromArgb(50, 83, 161);
            btnKunjungan.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            btnKunjungan.ForeColor = SystemColors.ButtonFace;
            btnKunjungan.Location = new Point(-5, -12);
            btnKunjungan.Name = "btnKunjungan";
            btnKunjungan.Size = new Size(377, 102);
            btnKunjungan.TabIndex = 1;
            btnKunjungan.Text = "         Laporan Kunjungan";
            btnKunjungan.TextAlign = ContentAlignment.MiddleLeft;
            btnKunjungan.UseVisualStyleBackColor = false;
            btnKunjungan.Click += btnKunjungan_Click;
            // 
            // panelKeuangan
            // 
            panelKeuangan.Controls.Add(btnKeuangan);
            panelKeuangan.Location = new Point(3, 185);
            panelKeuangan.Name = "panelKeuangan";
            panelKeuangan.Size = new Size(365, 85);
            panelKeuangan.TabIndex = 9;
            // 
            // btnKeuangan
            // 
            btnKeuangan.BackColor = Color.FromArgb(50, 83, 161);
            btnKeuangan.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            btnKeuangan.ForeColor = SystemColors.ButtonFace;
            btnKeuangan.Location = new Point(-5, -12);
            btnKeuangan.Name = "btnKeuangan";
            btnKeuangan.Size = new Size(377, 102);
            btnKeuangan.TabIndex = 1;
            btnKeuangan.Text = "         Laporan Keuangan";
            btnKeuangan.TextAlign = ContentAlignment.MiddleLeft;
            btnKeuangan.UseVisualStyleBackColor = false;
            btnKeuangan.Click += btnKeuangan_Click;
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
            // laporanTransition
            // 
            laporanTransition.Interval = 10;
            laporanTransition.Tick += laporanTransition_Tick;
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
            panelTransaksi.ResumeLayout(false);
            LaporanContainer.ResumeLayout(false);
            panelLaporan.ResumeLayout(false);
            panelKunjungan.ResumeLayout(false);
            panelKeuangan.ResumeLayout(false);
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
        private Panel panelLaporan;
        private Button btnLaporan;
        private FlowLayoutPanel LaporanContainer;
        private Panel panelKunjungan;
        private Button btnKunjungan;
        private Panel panelKeuangan;
        private Button btnKeuangan;
        private Panel panelTransaksi;
        private Button btnTransaksi;
        private System.Windows.Forms.Timer laporanTransition;
    }
}