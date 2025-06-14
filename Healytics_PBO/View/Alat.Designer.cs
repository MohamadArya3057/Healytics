namespace Healytics_PBO.View
{
    partial class Alat
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
            tbAlat = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            nama_alat = new DataGridViewTextBoxColumn();
            harga = new DataGridViewTextBoxColumn();
            btnUpdate = new DataGridViewButtonColumn();
            btnDelete = new DataGridViewButtonColumn();
            btnSearch = new Button();
            txtSearch = new TextBox();
            btnTambah = new Button();
            ((System.ComponentModel.ISupportInitialize)tbAlat).BeginInit();
            SuspendLayout();
            // 
            // tbAlat
            // 
            tbAlat.AllowUserToAddRows = false;
            tbAlat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tbAlat.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            tbAlat.BackgroundColor = Color.FromArgb(184, 237, 248);
            tbAlat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbAlat.Columns.AddRange(new DataGridViewColumn[] { ID, nama_alat, harga, btnUpdate, btnDelete });
            tbAlat.GridColor = Color.FromArgb(120, 195, 233);
            tbAlat.Location = new Point(400, 170);
            tbAlat.MultiSelect = false;
            tbAlat.Name = "tbAlat";
            tbAlat.ReadOnly = true;
            tbAlat.RowHeadersVisible = false;
            tbAlat.RowHeadersWidth = 62;
            tbAlat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tbAlat.ShowRowErrors = false;
            tbAlat.Size = new Size(970, 800);
            tbAlat.TabIndex = 9;
            tbAlat.CellClick += tbAlat_CellClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID Obat";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            // 
            // nama_alat
            // 
            nama_alat.HeaderText = "Nama Alat";
            nama_alat.MinimumWidth = 8;
            nama_alat.Name = "nama_alat";
            nama_alat.ReadOnly = true;
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
            // btnSearch
            // 
            btnSearch.FlatAppearance.BorderColor = Color.SteelBlue;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.SteelBlue;
            btnSearch.Location = new Point(1305, 100);
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
            txtSearch.Location = new Point(1020, 100);
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
            btnTambah.Location = new Point(400, 100);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(120, 40);
            btnTambah.TabIndex = 6;
            btnTambah.Text = "Add Data";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // Alat
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg;
            ClientSize = new Size(1418, 968);
            Controls.Add(tbAlat);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnTambah);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Alat";
            Text = "Alat";
            Load += Alat_Load;
            ((System.ComponentModel.ISupportInitialize)tbAlat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tbAlat;
        private Button btnSearch;
        private TextBox txtSearch;
        private Button btnTambah;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn nama_alat;
        private DataGridViewTextBoxColumn harga;
        private DataGridViewButtonColumn btnUpdate;
        private DataGridViewButtonColumn btnDelete;
    }
}