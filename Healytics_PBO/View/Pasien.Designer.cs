namespace Healytics_PBO.View
{
    partial class Pasien
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
            tbPasien = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            nama_pasien = new DataGridViewTextBoxColumn();
            umur = new DataGridViewTextBoxColumn();
            desa = new DataGridViewTextBoxColumn();
            riwayat = new DataGridViewButtonColumn();
            btnUpdate = new DataGridViewButtonColumn();
            btnDelete = new DataGridViewButtonColumn();
            btnSearch = new Button();
            txtSearch = new TextBox();
            btnTambah = new Button();
            ((System.ComponentModel.ISupportInitialize)tbPasien).BeginInit();
            SuspendLayout();
            // 
            // tbPasien
            // 
            tbPasien.AllowUserToAddRows = false;
            tbPasien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tbPasien.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            tbPasien.BackgroundColor = Color.FromArgb(184, 237, 248);
            tbPasien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbPasien.Columns.AddRange(new DataGridViewColumn[] { ID, nama_pasien, umur, desa, riwayat, btnUpdate, btnDelete });
            tbPasien.GridColor = Color.FromArgb(120, 195, 233);
            tbPasien.Location = new Point(423, 203);
            tbPasien.MultiSelect = false;
            tbPasien.Name = "tbPasien";
            tbPasien.ReadOnly = true;
            tbPasien.RowHeadersVisible = false;
            tbPasien.RowHeadersWidth = 62;
            tbPasien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tbPasien.ShowRowErrors = false;
            tbPasien.Size = new Size(970, 800);
            tbPasien.TabIndex = 9;
            tbPasien.CellContentClick += tbPasien_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID Obat";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            // 
            // nama_pasien
            // 
            nama_pasien.HeaderText = "Nama Pasien";
            nama_pasien.MinimumWidth = 8;
            nama_pasien.Name = "nama_pasien";
            nama_pasien.ReadOnly = true;
            // 
            // umur
            // 
            umur.HeaderText = "Umur";
            umur.MinimumWidth = 8;
            umur.Name = "umur";
            umur.ReadOnly = true;
            // 
            // desa
            // 
            desa.HeaderText = "Desa";
            desa.MinimumWidth = 8;
            desa.Name = "desa";
            desa.ReadOnly = true;
            // 
            // riwayat
            // 
            riwayat.HeaderText = "Riwayat";
            riwayat.MinimumWidth = 8;
            riwayat.Name = "riwayat";
            riwayat.ReadOnly = true;
            riwayat.Text = "Riwayat";
            riwayat.UseColumnTextForButtonValue = true;
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
            btnSearch.Location = new Point(1328, 133);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(65, 30);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(120, 195, 233);
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(1043, 133);
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
            btnTambah.Location = new Point(423, 133);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(120, 40);
            btnTambah.TabIndex = 6;
            btnTambah.Text = "Add Data";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // Pasien
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg;
            ClientSize = new Size(1440, 1024);
            Controls.Add(tbPasien);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnTambah);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Pasien";
            Text = "Pasien";
            Load += Pasien_Load;
            ((System.ComponentModel.ISupportInitialize)tbPasien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tbPasien;
        private Button btnSearch;
        private TextBox txtSearch;
        private Button btnTambah;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn nama_pasien;
        private DataGridViewTextBoxColumn umur;
        private DataGridViewTextBoxColumn desa;
        private DataGridViewButtonColumn riwayat;
        private DataGridViewButtonColumn btnUpdate;
        private DataGridViewButtonColumn btnDelete;
    }
}