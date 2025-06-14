namespace Healytics_PBO.View
{
    partial class TambahEditRiwayat
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
            btnBatal = new Button();
            labelPasien = new Label();
            btnSimpan = new Button();
            dateTanggal = new DateTimePicker();
            btnHapusBaris = new Button();
            btnTambahBaris = new Button();
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
            // btnBatal
            // 
            btnBatal.BackColor = Color.Gray;
            btnBatal.FlatAppearance.BorderColor = Color.Gray;
            btnBatal.FlatAppearance.BorderSize = 3;
            btnBatal.FlatStyle = FlatStyle.Flat;
            btnBatal.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBatal.ForeColor = SystemColors.ButtonFace;
            btnBatal.Location = new Point(481, 704);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(108, 45);
            btnBatal.TabIndex = 33;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = false;
            btnBatal.Click += btnBatal_Click;
            // 
            // labelPasien
            // 
            labelPasien.AutoSize = true;
            labelPasien.Font = new Font("Bahnschrift SemiBold", 30F, FontStyle.Bold);
            labelPasien.ForeColor = Color.FromArgb(19, 62, 135);
            labelPasien.Location = new Point(443, 142);
            labelPasien.Name = "labelPasien";
            labelPasien.Size = new Size(331, 72);
            labelPasien.TabIndex = 28;
            labelPasien.Text = "DATA OBAT";
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.ForestGreen;
            btnSimpan.FlatAppearance.BorderColor = Color.ForestGreen;
            btnSimpan.FlatAppearance.BorderSize = 3;
            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnSimpan.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSimpan.ForeColor = Color.Honeydew;
            btnSimpan.Location = new Point(616, 704);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(120, 45);
            btnSimpan.TabIndex = 27;
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // dateTanggal
            // 
            dateTanggal.Location = new Point(460, 242);
            dateTanggal.Name = "dateTanggal";
            dateTanggal.Size = new Size(300, 31);
            dateTanggal.TabIndex = 35;
            // 
            // btnHapusBaris
            // 
            btnHapusBaris.BackColor = Color.Gray;
            btnHapusBaris.FlatAppearance.BorderColor = Color.Gray;
            btnHapusBaris.FlatAppearance.BorderSize = 3;
            btnHapusBaris.FlatStyle = FlatStyle.Flat;
            btnHapusBaris.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHapusBaris.ForeColor = SystemColors.ButtonFace;
            btnHapusBaris.Location = new Point(461, 555);
            btnHapusBaris.Name = "btnHapusBaris";
            btnHapusBaris.Size = new Size(108, 45);
            btnHapusBaris.TabIndex = 38;
            btnHapusBaris.Text = "Hapus";
            btnHapusBaris.UseVisualStyleBackColor = false;
            btnHapusBaris.Click += btnHapusBaris_Click;
            // 
            // btnTambahBaris
            // 
            btnTambahBaris.BackColor = Color.ForestGreen;
            btnTambahBaris.FlatAppearance.BorderColor = Color.ForestGreen;
            btnTambahBaris.FlatAppearance.BorderSize = 3;
            btnTambahBaris.FlatStyle = FlatStyle.Flat;
            btnTambahBaris.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTambahBaris.ForeColor = Color.Honeydew;
            btnTambahBaris.Location = new Point(596, 555);
            btnTambahBaris.Name = "btnTambahBaris";
            btnTambahBaris.Size = new Size(120, 45);
            btnTambahBaris.TabIndex = 37;
            btnTambahBaris.UseVisualStyleBackColor = false;
            btnTambahBaris.Click += btnTambahBaris_Click;
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
            tbObat.Location = new Point(460, 313);
            tbObat.MultiSelect = false;
            tbObat.Name = "tbObat";
            tbObat.ReadOnly = true;
            tbObat.RowHeadersVisible = false;
            tbObat.RowHeadersWidth = 62;
            tbObat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tbObat.ShowRowErrors = false;
            tbObat.Size = new Size(970, 131);
            tbObat.TabIndex = 39;
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
            // TambahEditRiwayat
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg;
            ClientSize = new Size(1440, 1024);
            Controls.Add(tbObat);
            Controls.Add(btnHapusBaris);
            Controls.Add(btnTambahBaris);
            Controls.Add(dateTanggal);
            Controls.Add(btnBatal);
            Controls.Add(labelPasien);
            Controls.Add(btnSimpan);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TambahEditRiwayat";
            Text = "TambahEditRiwayat";
            Load += TambahEditRiwayat_Load;
            ((System.ComponentModel.ISupportInitialize)tbObat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnBatal;
        private Label labelPasien;
        private Button btnSimpan;
        private DateTimePicker dateTanggal;
        private Button btnHapusBaris;
        private Button btnTambahBaris;
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