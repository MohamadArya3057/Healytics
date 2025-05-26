namespace NEW_PROJEKAN_PBO
{
    partial class Pasien1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pasien1));
            panel1 = new Panel();
            buttonMenu = new PictureBox();
            panel5 = new Panel();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            sidebar = new FlowLayoutPanel();
            pnPasien = new Panel();
            button2 = new Button();
            pnObat = new Panel();
            button1 = new Button();
            pnAlat = new Panel();
            button3 = new Button();
            pnTransaksi = new Panel();
            button6 = new Button();
            pnLaporan = new Panel();
            button4 = new Button();
            pnLogout = new Panel();
            btnLogout = new Button();
            sidebarTransisi = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)buttonMenu).BeginInit();
            sidebar.SuspendLayout();
            pnPasien.SuspendLayout();
            pnObat.SuspendLayout();
            pnAlat.SuspendLayout();
            pnTransaksi.SuspendLayout();
            pnLaporan.SuspendLayout();
            pnLogout.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BackgroundImage = Properties.Resources.Screenshot_2025_05_25_141132;
            panel1.Controls.Add(buttonMenu);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1193, 35);
            panel1.TabIndex = 0;
            // 
            // buttonMenu
            // 
            buttonMenu.BackColor = Color.Transparent;
            buttonMenu.Image = (Image)resources.GetObject("buttonMenu.Image");
            buttonMenu.Location = new Point(10, 0);
            buttonMenu.Name = "buttonMenu";
            buttonMenu.Size = new Size(40, 32);
            buttonMenu.SizeMode = PictureBoxSizeMode.CenterImage;
            buttonMenu.TabIndex = 2;
            buttonMenu.TabStop = false;
            buttonMenu.Click += buttonMenu_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Black;
            panel5.BackgroundImage = Properties.Resources.Screenshot_2025_05_25_141132;
            panel5.Location = new Point(0, 32);
            panel5.Name = "panel5";
            panel5.Size = new Size(239, 53);
            panel5.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Image = Properties.Resources.Screenshot_2025_05_25_141132;
            label1.Location = new Point(56, 0);
            label1.Name = "label1";
            label1.Size = new Size(93, 29);
            label1.TabIndex = 1;
            label1.Text = "HEALYTICS";
            // 
            // sidebar
            // 
            sidebar.BackgroundImage = Properties.Resources.Screenshot_2025_05_25_141132;
            sidebar.Controls.Add(pnPasien);
            sidebar.Controls.Add(pnObat);
            sidebar.Controls.Add(pnAlat);
            sidebar.Controls.Add(pnTransaksi);
            sidebar.Controls.Add(pnLaporan);
            sidebar.Controls.Add(pnLogout);
            sidebar.Dock = DockStyle.Left;
            sidebar.FlowDirection = FlowDirection.TopDown;
            sidebar.Location = new Point(0, 35);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(225, 586);
            sidebar.TabIndex = 1;
            // 
            // pnPasien
            // 
            pnPasien.BackColor = Color.Black;
            pnPasien.BackgroundImage = Properties.Resources.Screenshot_2025_05_25_141132;
            pnPasien.Controls.Add(button2);
            pnPasien.Location = new Point(3, 3);
            pnPasien.Name = "pnPasien";
            pnPasien.Size = new Size(239, 72);
            pnPasien.TabIndex = 3;
            pnPasien.Paint += panel2_Paint;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(-3, 0);
            button2.Name = "button2";
            button2.Size = new Size(225, 75);
            button2.TabIndex = 3;
            button2.Text = "            Pasien";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pnObat
            // 
            pnObat.BackColor = Color.Black;
            pnObat.BackgroundImage = Properties.Resources.Screenshot_2025_05_25_141132;
            pnObat.Controls.Add(button1);
            pnObat.Location = new Point(3, 81);
            pnObat.Name = "pnObat";
            pnObat.Size = new Size(239, 72);
            pnObat.TabIndex = 7;
            pnObat.Paint += panel3_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(222, 72);
            button1.TabIndex = 2;
            button1.Text = "            Obat";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pnAlat
            // 
            pnAlat.BackColor = Color.Black;
            pnAlat.BackgroundImage = Properties.Resources.Screenshot_2025_05_25_141132;
            pnAlat.Controls.Add(button3);
            pnAlat.Location = new Point(3, 159);
            pnAlat.Name = "pnAlat";
            pnAlat.Size = new Size(239, 72);
            pnAlat.TabIndex = 8;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(0, 0);
            button3.Name = "button3";
            button3.Size = new Size(222, 72);
            button3.TabIndex = 3;
            button3.Text = "            Alat";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pnTransaksi
            // 
            pnTransaksi.BackColor = Color.Black;
            pnTransaksi.BackgroundImage = Properties.Resources.Screenshot_2025_05_25_141132;
            pnTransaksi.Controls.Add(button6);
            pnTransaksi.Location = new Point(3, 237);
            pnTransaksi.Name = "pnTransaksi";
            pnTransaksi.Size = new Size(239, 72);
            pnTransaksi.TabIndex = 11;
            // 
            // button6
            // 
            button6.BackColor = Color.Transparent;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(0, 0);
            button6.Name = "button6";
            button6.Size = new Size(222, 72);
            button6.TabIndex = 3;
            button6.Text = "            Transaksi";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // pnLaporan
            // 
            pnLaporan.BackColor = Color.Black;
            pnLaporan.BackgroundImage = Properties.Resources.Screenshot_2025_05_25_141132;
            pnLaporan.Controls.Add(button4);
            pnLaporan.Location = new Point(3, 315);
            pnLaporan.Name = "pnLaporan";
            pnLaporan.Size = new Size(239, 72);
            pnLaporan.TabIndex = 9;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(0, 0);
            button4.Name = "button4";
            button4.Size = new Size(222, 72);
            button4.TabIndex = 3;
            button4.Text = "            Laporan";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // pnLogout
            // 
            pnLogout.BackColor = Color.Black;
            pnLogout.BackgroundImage = Properties.Resources.Screenshot_2025_05_25_141132;
            pnLogout.Controls.Add(btnLogout);
            pnLogout.Location = new Point(3, 393);
            pnLogout.Name = "pnLogout";
            pnLogout.Size = new Size(239, 72);
            pnLogout.TabIndex = 10;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Transparent;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(0, 0);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(225, 72);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "            Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // sidebarTransisi
            // 
            sidebarTransisi.Interval = 10;
            sidebarTransisi.Tick += sidebarTransisi_Tick;
            // 
            // Pasien1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1193, 621);
            Controls.Add(sidebar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            IsMdiContainer = true;
            Name = "Pasien1";
            Text = "Pasien";
            Load += Pasien_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)buttonMenu).EndInit();
            sidebar.ResumeLayout(false);
            pnPasien.ResumeLayout(false);
            pnObat.ResumeLayout(false);
            pnAlat.ResumeLayout(false);
            pnTransaksi.ResumeLayout(false);
            pnLaporan.ResumeLayout(false);
            pnLogout.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public PictureBox buttonMenu;
        private FlowLayoutPanel sidebar;
        private Button button1;
        private Panel pnPasien;
        private Panel panel5;
        private Button button2;
        private Panel pnObat;
        private Panel pnAlat;
        private Button button3;
        private Panel pnLaporan;
        private Button button4;
        private Panel pnLogout;
        private Button btnLogout;
        private Panel pnTransaksi;
        private Button button6;
        private System.Windows.Forms.Timer sidebarTransisi;
    }
}