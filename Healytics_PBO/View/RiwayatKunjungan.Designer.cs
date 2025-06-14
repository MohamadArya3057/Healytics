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
            dgKunjungan = new DataGridView();
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
            groupBox1 = new GroupBox();
            dgObat = new DataGridView();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            obat = new DataGridViewTextBoxColumn();
            dataGridViewButtonColumn3 = new DataGridViewButtonColumn();
            dataGridViewButtonColumn4 = new DataGridViewButtonColumn();
            dgGejala = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            gejala = new DataGridViewTextBoxColumn();
            dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
            dataGridViewButtonColumn2 = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgKunjungan).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgObat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgGejala).BeginInit();
            SuspendLayout();
            // 
            // dgKunjungan
            // 
            dgKunjungan.AllowUserToAddRows = false;
            dgKunjungan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgKunjungan.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgKunjungan.BackgroundColor = Color.FromArgb(184, 237, 248);
            dgKunjungan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgKunjungan.Columns.AddRange(new DataGridViewColumn[] { ID, tanggal, catatan, btnUpdate, btnDelete });
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
            // labelPasien
            // 
            labelPasien.AutoSize = true;
            labelPasien.Location = new Point(427, 103);
            labelPasien.Name = "labelPasien";
            labelPasien.Size = new Size(59, 25);
            labelPasien.TabIndex = 10;
            labelPasien.Text = "label1";
            // 
            // labelDesa
            // 
            labelDesa.AutoSize = true;
            labelDesa.Location = new Point(427, 154);
            labelDesa.Name = "labelDesa";
            labelDesa.Size = new Size(59, 25);
            labelDesa.TabIndex = 11;
            labelDesa.Text = "label2";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgObat);
            groupBox1.Controls.Add(dgGejala);
            groupBox1.Location = new Point(427, 457);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(970, 352);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // dgObat
            // 
            dgObat.AllowUserToAddRows = false;
            dgObat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgObat.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgObat.BackgroundColor = Color.FromArgb(184, 237, 248);
            dgObat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgObat.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn4, obat, dataGridViewButtonColumn3, dataGridViewButtonColumn4 });
            dgObat.GridColor = Color.FromArgb(120, 195, 233);
            dgObat.Location = new Point(0, 199);
            dgObat.MultiSelect = false;
            dgObat.Name = "dgObat";
            dgObat.ReadOnly = true;
            dgObat.RowHeadersVisible = false;
            dgObat.RowHeadersWidth = 62;
            dgObat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgObat.ShowRowErrors = false;
            dgObat.Size = new Size(970, 132);
            dgObat.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "ID Obat";
            dataGridViewTextBoxColumn4.MinimumWidth = 8;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Visible = false;
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
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.Khaki;
            dataGridViewButtonColumn3.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewButtonColumn3.HeaderText = "Action";
            dataGridViewButtonColumn3.MinimumWidth = 8;
            dataGridViewButtonColumn3.Name = "dataGridViewButtonColumn3";
            dataGridViewButtonColumn3.ReadOnly = true;
            dataGridViewButtonColumn3.Text = "Update";
            dataGridViewButtonColumn3.UseColumnTextForButtonValue = true;
            // 
            // dataGridViewButtonColumn4
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 128, 128);
            dataGridViewButtonColumn4.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewButtonColumn4.HeaderText = "";
            dataGridViewButtonColumn4.MinimumWidth = 8;
            dataGridViewButtonColumn4.Name = "dataGridViewButtonColumn4";
            dataGridViewButtonColumn4.ReadOnly = true;
            dataGridViewButtonColumn4.Text = "Delete";
            dataGridViewButtonColumn4.UseColumnTextForButtonValue = true;
            // 
            // dgGejala
            // 
            dgGejala.AllowUserToAddRows = false;
            dgGejala.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgGejala.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgGejala.BackgroundColor = Color.FromArgb(184, 237, 248);
            dgGejala.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgGejala.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, gejala, dataGridViewButtonColumn1, dataGridViewButtonColumn2 });
            dgGejala.GridColor = Color.FromArgb(120, 195, 233);
            dgGejala.Location = new Point(0, 48);
            dgGejala.MultiSelect = false;
            dgGejala.Name = "dgGejala";
            dgGejala.ReadOnly = true;
            dgGejala.RowHeadersVisible = false;
            dgGejala.RowHeadersWidth = 62;
            dgGejala.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgGejala.ShowRowErrors = false;
            dgGejala.Size = new Size(970, 132);
            dgGejala.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "ID Gejala";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Visible = false;
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
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.Khaki;
            dataGridViewButtonColumn1.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewButtonColumn1.HeaderText = "Action";
            dataGridViewButtonColumn1.MinimumWidth = 8;
            dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            dataGridViewButtonColumn1.ReadOnly = true;
            dataGridViewButtonColumn1.Text = "Update";
            dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            // 
            // dataGridViewButtonColumn2
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(255, 128, 128);
            dataGridViewButtonColumn2.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewButtonColumn2.HeaderText = "";
            dataGridViewButtonColumn2.MinimumWidth = 8;
            dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            dataGridViewButtonColumn2.ReadOnly = true;
            dataGridViewButtonColumn2.Text = "Delete";
            dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
            // 
            // RiwayatKunjungan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg;
            ClientSize = new Size(1440, 1024);
            Controls.Add(groupBox1);
            Controls.Add(labelDesa);
            Controls.Add(labelPasien);
            Controls.Add(dgKunjungan);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnTambah);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RiwayatKunjungan";
            Text = "RiwayatKunjungan";
            ((System.ComponentModel.ISupportInitialize)dgKunjungan).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgObat).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgGejala).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgKunjungan;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn tanggal;
        private DataGridViewTextBoxColumn catatan;
        private DataGridViewButtonColumn btnUpdate;
        private DataGridViewButtonColumn btnDelete;
        private Button btnSearch;
        private TextBox txtSearch;
        private Button btnTambah;
        private Label labelPasien;
        private Label labelDesa;
        private GroupBox groupBox1;
        private DataGridView dgObat;
        private DataGridView dgGejala;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn obat;
        private DataGridViewButtonColumn dataGridViewButtonColumn3;
        private DataGridViewButtonColumn dataGridViewButtonColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn gejala;
        private DataGridViewButtonColumn dataGridViewButtonColumn1;
        private DataGridViewButtonColumn dataGridViewButtonColumn2;
    }
}