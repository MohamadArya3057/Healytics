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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            tbRiwayat = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            tanggal = new DataGridViewTextBoxColumn();
            catatan = new DataGridViewTextBoxColumn();
            btnUpdate = new DataGridViewButtonColumn();
            btnDelete = new DataGridViewButtonColumn();
            btnSearch = new Button();
            txtSearch = new TextBox();
            btnTambah = new Button();
            labelPasien = new Label();
            labelDesa = new Label();
            tbGejala = new DataGridView();
            id_gejala = new DataGridViewTextBoxColumn();
            gejala = new DataGridViewTextBoxColumn();
            dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
            dataGridViewButtonColumn2 = new DataGridViewButtonColumn();
            groupDetail = new GroupBox();
            tbObat = new DataGridView();
            id_obat = new DataGridViewTextBoxColumn();
            obat = new DataGridViewTextBoxColumn();
            dataGridViewButtonColumn3 = new DataGridViewButtonColumn();
            dataGridViewButtonColumn4 = new DataGridViewButtonColumn();
            btnTutup = new Button();
            ((System.ComponentModel.ISupportInitialize)tbRiwayat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbGejala).BeginInit();
            groupDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbObat).BeginInit();
            SuspendLayout();
            // 
            // tbRiwayat
            // 
            tbRiwayat.AllowUserToAddRows = false;
            tbRiwayat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tbRiwayat.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            tbRiwayat.BackgroundColor = Color.FromArgb(184, 237, 248);
            tbRiwayat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbRiwayat.Columns.AddRange(new DataGridViewColumn[] { ID, tanggal, catatan, btnUpdate, btnDelete });
            tbRiwayat.GridColor = Color.FromArgb(120, 195, 233);
            tbRiwayat.Location = new Point(419, 290);
            tbRiwayat.MultiSelect = false;
            tbRiwayat.Name = "tbRiwayat";
            tbRiwayat.ReadOnly = true;
            tbRiwayat.RowHeadersVisible = false;
            tbRiwayat.RowHeadersWidth = 62;
            tbRiwayat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tbRiwayat.ShowRowErrors = false;
            tbRiwayat.Size = new Size(970, 76);
            tbRiwayat.TabIndex = 9;
            tbRiwayat.CellClick += tbRiwayat_CellClick;
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
            btnSearch.Location = new Point(1324, 216);
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
            txtSearch.Location = new Point(1039, 216);
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
            btnTambah.Location = new Point(419, 216);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(120, 40);
            btnTambah.TabIndex = 6;
            btnTambah.Text = "Add Data";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // labelPasien
            // 
            labelPasien.AutoSize = true;
            labelPasien.Location = new Point(419, 105);
            labelPasien.Name = "labelPasien";
            labelPasien.Size = new Size(59, 25);
            labelPasien.TabIndex = 10;
            labelPasien.Text = "label1";
            // 
            // labelDesa
            // 
            labelDesa.AutoSize = true;
            labelDesa.Location = new Point(419, 157);
            labelDesa.Name = "labelDesa";
            labelDesa.Size = new Size(59, 25);
            labelDesa.TabIndex = 11;
            labelDesa.Text = "label1";
            // 
            // tbGejala
            // 
            tbGejala.AllowUserToAddRows = false;
            tbGejala.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tbGejala.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            tbGejala.BackgroundColor = Color.FromArgb(184, 237, 248);
            tbGejala.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbGejala.Columns.AddRange(new DataGridViewColumn[] { id_gejala, gejala, dataGridViewButtonColumn1, dataGridViewButtonColumn2 });
            tbGejala.GridColor = Color.FromArgb(120, 195, 233);
            tbGejala.Location = new Point(0, 48);
            tbGejala.MultiSelect = false;
            tbGejala.Name = "tbGejala";
            tbGejala.ReadOnly = true;
            tbGejala.RowHeadersVisible = false;
            tbGejala.RowHeadersWidth = 62;
            tbGejala.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tbGejala.ShowRowErrors = false;
            tbGejala.Size = new Size(970, 76);
            tbGejala.TabIndex = 12;
            // 
            // id_gejala
            // 
            id_gejala.HeaderText = "ID Gejala";
            id_gejala.MinimumWidth = 8;
            id_gejala.Name = "id_gejala";
            id_gejala.ReadOnly = true;
            id_gejala.Visible = false;
            // 
            // gejala
            // 
            gejala.HeaderText = "Gejala";
            gejala.MinimumWidth = 8;
            gejala.Name = "gejala";
            gejala.ReadOnly = true;
            // 
            // dataGridViewButtonColumn1
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.Khaki;
            dataGridViewButtonColumn1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewButtonColumn1.HeaderText = "Action";
            dataGridViewButtonColumn1.MinimumWidth = 8;
            dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            dataGridViewButtonColumn1.ReadOnly = true;
            dataGridViewButtonColumn1.Text = "Update";
            dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            // 
            // dataGridViewButtonColumn2
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 128, 128);
            dataGridViewButtonColumn2.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewButtonColumn2.HeaderText = "";
            dataGridViewButtonColumn2.MinimumWidth = 8;
            dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            dataGridViewButtonColumn2.ReadOnly = true;
            dataGridViewButtonColumn2.Text = "Delete";
            dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
            // 
            // groupDetail
            // 
            groupDetail.Controls.Add(tbObat);
            groupDetail.Controls.Add(tbGejala);
            groupDetail.Location = new Point(419, 406);
            groupDetail.Name = "groupDetail";
            groupDetail.Size = new Size(970, 244);
            groupDetail.TabIndex = 13;
            groupDetail.TabStop = false;
            groupDetail.Text = "groupBox1";
            // 
            // tbObat
            // 
            tbObat.AllowUserToAddRows = false;
            tbObat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tbObat.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            tbObat.BackgroundColor = Color.FromArgb(184, 237, 248);
            tbObat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbObat.Columns.AddRange(new DataGridViewColumn[] { id_obat, obat, dataGridViewButtonColumn3, dataGridViewButtonColumn4 });
            tbObat.GridColor = Color.FromArgb(120, 195, 233);
            tbObat.Location = new Point(0, 162);
            tbObat.MultiSelect = false;
            tbObat.Name = "tbObat";
            tbObat.ReadOnly = true;
            tbObat.RowHeadersVisible = false;
            tbObat.RowHeadersWidth = 62;
            tbObat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tbObat.ShowRowErrors = false;
            tbObat.Size = new Size(970, 76);
            tbObat.TabIndex = 16;
            // 
            // id_obat
            // 
            id_obat.HeaderText = "ID Obat";
            id_obat.MinimumWidth = 8;
            id_obat.Name = "id_obat";
            id_obat.ReadOnly = true;
            id_obat.Visible = false;
            // 
            // obat
            // 
            obat.HeaderText = "Obat";
            obat.MinimumWidth = 8;
            obat.Name = "obat";
            obat.ReadOnly = true;
            // 
            // dataGridViewButtonColumn3
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.Khaki;
            dataGridViewButtonColumn3.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewButtonColumn3.HeaderText = "Action";
            dataGridViewButtonColumn3.MinimumWidth = 8;
            dataGridViewButtonColumn3.Name = "dataGridViewButtonColumn3";
            dataGridViewButtonColumn3.ReadOnly = true;
            dataGridViewButtonColumn3.Text = "Update";
            dataGridViewButtonColumn3.UseColumnTextForButtonValue = true;
            // 
            // dataGridViewButtonColumn4
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(255, 128, 128);
            dataGridViewButtonColumn4.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewButtonColumn4.HeaderText = "";
            dataGridViewButtonColumn4.MinimumWidth = 8;
            dataGridViewButtonColumn4.Name = "dataGridViewButtonColumn4";
            dataGridViewButtonColumn4.ReadOnly = true;
            dataGridViewButtonColumn4.Text = "Delete";
            dataGridViewButtonColumn4.UseColumnTextForButtonValue = true;
            // 
            // btnTutup
            // 
            btnTutup.Location = new Point(419, 774);
            btnTutup.Name = "btnTutup";
            btnTutup.Size = new Size(112, 34);
            btnTutup.TabIndex = 14;
            btnTutup.Text = "button1";
            btnTutup.UseVisualStyleBackColor = true;
            // 
            // RiwayatKunjungan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg;
            ClientSize = new Size(1440, 1024);
            Controls.Add(btnTutup);
            Controls.Add(groupDetail);
            Controls.Add(labelDesa);
            Controls.Add(labelPasien);
            Controls.Add(tbRiwayat);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnTambah);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RiwayatKunjungan";
            Text = "RiwayatKunjungan";
            Load += RiwayatKunjungan_Load;
            ((System.ComponentModel.ISupportInitialize)tbRiwayat).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbGejala).EndInit();
            groupDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tbObat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tbRiwayat;
        private Button btnSearch;
        private TextBox txtSearch;
        private Button btnTambah;
        private Label labelPasien;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn tanggal;
        private DataGridViewTextBoxColumn catatan;
        private DataGridViewButtonColumn btnUpdate;
        private DataGridViewButtonColumn btnDelete;
        private Label labelDesa;
        private DataGridView tbGejala;
        private GroupBox groupDetail;
        private DataGridView tbObat;
        private Button btnTutup;
        private DataGridViewTextBoxColumn id_gejala;
        private DataGridViewTextBoxColumn gejala;
        private DataGridViewButtonColumn dataGridViewButtonColumn1;
        private DataGridViewButtonColumn dataGridViewButtonColumn2;
        private DataGridViewTextBoxColumn id_obat;
        private DataGridViewTextBoxColumn obat;
        private DataGridViewButtonColumn dataGridViewButtonColumn3;
        private DataGridViewButtonColumn dataGridViewButtonColumn4;
    }
}