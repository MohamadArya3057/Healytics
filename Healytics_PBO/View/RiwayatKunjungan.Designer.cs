namespace Healytics_PBO.View
{
    partial class RiwayatKunjungan
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgKunjungan = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            tanggal = new DataGridViewTextBoxColumn();
            catatan = new DataGridViewTextBoxColumn();
            gejala_riwayat = new DataGridViewTextBoxColumn();
            obat_riwayat = new DataGridViewTextBoxColumn();
            btnUpdate = new DataGridViewButtonColumn();
            btnDelete = new DataGridViewButtonColumn();
            btnSearch = new Button();
            txtSearch = new TextBox();
            btnTambah = new Button();
            btnKembali = new Button();
            labelPasien = new Label();
            labelDesa = new Label();
            ((System.ComponentModel.ISupportInitialize)dgKunjungan).BeginInit();
            SuspendLayout();
            // 
            // dgKunjungan
            // 
            dgKunjungan.AllowUserToAddRows = false;
            dgKunjungan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgKunjungan.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgKunjungan.BackgroundColor = Color.FromArgb(184, 237, 248);
            dgKunjungan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgKunjungan.Columns.AddRange(new DataGridViewColumn[] { ID, tanggal, catatan, gejala_riwayat, obat_riwayat, btnUpdate, btnDelete });
            dgKunjungan.GridColor = Color.FromArgb(120, 195, 233);
            dgKunjungan.Location = new Point(427, 288);
            dgKunjungan.MultiSelect = false;
            dgKunjungan.Name = "dgKunjungan";
            dgKunjungan.ReadOnly = true;
            dgKunjungan.RowHeadersVisible = false;
            dgKunjungan.RowHeadersWidth = 62;
            dgKunjungan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgKunjungan.ShowRowErrors = false;
            dgKunjungan.Size = new Size(970, 132);
            dgKunjungan.TabIndex = 9;
            // 
            // ID
            // 
            ID.HeaderText = "ID Riwayat";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            // 
            // tanggal
            // 
            tanggal.HeaderText = "Tanggal";
            tanggal.MinimumWidth = 8;
            tanggal.Name = "tanggal";
            tanggal.ReadOnly = true;
            // 
            // catatan
            // 
            catatan.HeaderText = "Catatan";
            catatan.MinimumWidth = 8;
            catatan.Name = "catatan";
            catatan.ReadOnly = true;
            // 
            // gejala_riwayat
            // 
            gejala_riwayat.HeaderText = "Gejala";
            gejala_riwayat.MinimumWidth = 8;
            gejala_riwayat.Name = "gejala_riwayat";
            gejala_riwayat.ReadOnly = true;
            // 
            // obat_riwayat
            // 
            obat_riwayat.HeaderText = "Obat";
            obat_riwayat.MinimumWidth = 8;
            obat_riwayat.Name = "obat_riwayat";
            obat_riwayat.ReadOnly = true;
            // 
            // btnUpdate
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Khaki;
            btnUpdate.DefaultCellStyle = dataGridViewCellStyle1;
            btnUpdate.HeaderText = "Action";
            btnUpdate.MinimumWidth = 8;
            btnUpdate.Name = "btnUpdate";
            btnUpdate.ReadOnly = true;
            btnUpdate.Text = "Update";
            btnUpdate.UseColumnTextForButtonValue = true;
            // 
            // btnDelete
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 128, 128);
            btnDelete.DefaultCellStyle = dataGridViewCellStyle2;
            btnDelete.HeaderText = "";
            btnDelete.MinimumWidth = 8;
            btnDelete.Name = "btnDelete";
            btnDelete.ReadOnly = true;
            btnDelete.Text = "Delete";
            btnDelete.UseColumnTextForButtonValue = true;
            // 
            // btnSearch
            // 
            btnSearch.FlatAppearance.BorderColor = Color.SteelBlue;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.SteelBlue;
            btnSearch.Location = new Point(1332, 218);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(65, 30);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(120, 195, 233);
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(1047, 218);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(350, 30);
            txtSearch.TabIndex = 7;
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.White;
            btnTambah.FlatAppearance.BorderColor = Color.SteelBlue;
            btnTambah.FlatAppearance.BorderSize = 3;
            btnTambah.FlatStyle = FlatStyle.Flat;
            btnTambah.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTambah.ForeColor = Color.SteelBlue;
            btnTambah.Location = new Point(427, 218);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(120, 40);
            btnTambah.TabIndex = 6;
            btnTambah.Text = "Add Data";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.Gray;
            btnKembali.FlatAppearance.BorderColor = Color.Gray;
            btnKembali.FlatAppearance.BorderSize = 3;
            btnKembali.FlatStyle = FlatStyle.Flat;
            btnKembali.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKembali.ForeColor = SystemColors.ButtonFace;
            btnKembali.Location = new Point(432, 465);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(115, 45);
            btnKembali.TabIndex = 18;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += btnKembali_Click;
            // 
            // labelPasien
            // 
            labelPasien.AutoSize = true;
            labelPasien.BackColor = Color.White;
            labelPasien.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            labelPasien.ForeColor = Color.SteelBlue;
            labelPasien.Location = new Point(427, 96);
            labelPasien.Name = "labelPasien";
            labelPasien.Size = new Size(84, 29);
            labelPasien.TabIndex = 19;
            labelPasien.Text = "Pasien";
            // 
            // labelDesa
            // 
            labelDesa.AutoSize = true;
            labelDesa.BackColor = Color.White;
            labelDesa.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            labelDesa.ForeColor = Color.SteelBlue;
            labelDesa.Location = new Point(427, 145);
            labelDesa.Name = "labelDesa";
            labelDesa.Size = new Size(67, 29);
            labelDesa.TabIndex = 20;
            labelDesa.Text = "Desa";
            // 
            // RiwayatKunjungan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.bg;
            ClientSize = new Size(1440, 1024);
            Controls.Add(labelDesa);
            Controls.Add(labelPasien);
            Controls.Add(btnKembali);
            Controls.Add(dgKunjungan);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnTambah);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RiwayatKunjungan";
            Text = "RiwayatKunjungan";
            ((System.ComponentModel.ISupportInitialize)dgKunjungan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgKunjungan;
        private Button btnSearch;
        private TextBox txtSearch;
        private Button btnTambah;
        private Button btnKembali;
        private Label labelPasien;
        private Label labelDesa;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn tanggal;
        private DataGridViewTextBoxColumn catatan;
        private DataGridViewTextBoxColumn gejala_riwayat;
        private DataGridViewTextBoxColumn obat_riwayat;
        private DataGridViewButtonColumn btnUpdate;
        private DataGridViewButtonColumn btnDelete;
    }
}