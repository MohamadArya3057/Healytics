namespace Healytics_PBO.View
{
    partial class Obat
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
            btnTambah = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            tbObat = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            nama_obat = new DataGridViewTextBoxColumn();
            nama_kategori = new DataGridViewTextBoxColumn();
            stock = new DataGridViewTextBoxColumn();
            harga = new DataGridViewTextBoxColumn();
            btnUpdate = new DataGridViewButtonColumn();
            btnDelete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)tbObat).BeginInit();
            SuspendLayout();
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.White;
            btnTambah.FlatAppearance.BorderColor = Color.SteelBlue;
            btnTambah.FlatAppearance.BorderSize = 3;
            btnTambah.FlatStyle = FlatStyle.Flat;
            btnTambah.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTambah.ForeColor = Color.SteelBlue;
            btnTambah.Location = new Point(400, 100);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(120, 40);
            btnTambah.TabIndex = 2;
            btnTambah.Text = "Add Data";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(120, 195, 233);
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(1020, 100);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(350, 30);
            txtSearch.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.FlatAppearance.BorderColor = Color.SteelBlue;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.SteelBlue;
            btnSearch.Location = new Point(1305, 100);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(65, 30);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // tbObat
            // 
            tbObat.AllowUserToAddRows = false;
            tbObat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tbObat.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            tbObat.BackgroundColor = Color.FromArgb(184, 237, 248);
            tbObat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbObat.Columns.AddRange(new DataGridViewColumn[] { ID, nama_obat, nama_kategori, stock, harga, btnUpdate, btnDelete });
            tbObat.GridColor = Color.FromArgb(120, 195, 233);
            tbObat.Location = new Point(400, 170);
            tbObat.MultiSelect = false;
            tbObat.Name = "tbObat";
            tbObat.ReadOnly = true;
            tbObat.RowHeadersVisible = false;
            tbObat.RowHeadersWidth = 62;
            tbObat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tbObat.ShowRowErrors = false;
            tbObat.Size = new Size(970, 800);
            tbObat.TabIndex = 5;
            tbObat.CellClick += tbObat_CellClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID Obat";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            // 
            // nama_obat
            // 
            nama_obat.HeaderText = "Nama Obat";
            nama_obat.MinimumWidth = 8;
            nama_obat.Name = "nama_obat";
            nama_obat.ReadOnly = true;
            // 
            // nama_kategori
            // 
            nama_kategori.HeaderText = "Kategori";
            nama_kategori.MinimumWidth = 8;
            nama_kategori.Name = "nama_kategori";
            nama_kategori.ReadOnly = true;
            // 
            // stock
            // 
            stock.HeaderText = "Harga";
            stock.MinimumWidth = 8;
            stock.Name = "stock";
            stock.ReadOnly = true;
            // 
            // harga
            // 
            harga.HeaderText = "Stok";
            harga.MinimumWidth = 8;
            harga.Name = "harga";
            harga.ReadOnly = true;
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
            // Obat
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.Desktop___9__2_;
            ClientSize = new Size(1440, 1024);
            Controls.Add(tbObat);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnTambah);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Obat";
            Text = "Obat";
            Load += Obat_Load;
            ((System.ComponentModel.ISupportInitialize)tbObat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnTambah;
        private TextBox txtSearch;
        private Button btnSearch;
        private DataGridView tbObat;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn nama_obat;
        private DataGridViewTextBoxColumn nama_kategori;
        private DataGridViewTextBoxColumn stock;
        private DataGridViewTextBoxColumn harga;
        private DataGridViewButtonColumn btnUpdate;
        private DataGridViewButtonColumn btnDelete;
    }
}