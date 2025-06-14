namespace Healytics_PBO.View
{
    partial class Gejala
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle cellStyleUpdate = new DataGridViewCellStyle();
            DataGridViewCellStyle cellStyleDelete = new DataGridViewCellStyle();

            btnTambah = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            tbGejala = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            nama_gejala = new DataGridViewTextBoxColumn();
            btnUpdate = new DataGridViewButtonColumn();
            btnDelete = new DataGridViewButtonColumn();

            ((System.ComponentModel.ISupportInitialize)tbGejala).BeginInit();
            SuspendLayout();

            // btnTambah
            btnTambah.BackColor = Color.White;
            btnTambah.FlatAppearance.BorderColor = Color.SteelBlue;
            btnTambah.FlatAppearance.BorderSize = 3;
            btnTambah.FlatStyle = FlatStyle.Flat;
            btnTambah.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnTambah.ForeColor = Color.SteelBlue;
            btnTambah.Location = new Point(400, 100);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(120, 40);
            btnTambah.TabIndex = 0;
            btnTambah.Text = "Add Data";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;

            // txtSearch
            txtSearch.BackColor = Color.FromArgb(120, 195, 233);
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Segoe UI", 11F);
            txtSearch.Location = new Point(1020, 100);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(350, 30);
            txtSearch.TabIndex = 1;

            // btnSearch
            btnSearch.FlatAppearance.BorderColor = Color.SteelBlue;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 8F);
            btnSearch.ForeColor = Color.SteelBlue;
            btnSearch.Location = new Point(1305, 100);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(65, 30);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;

            // tbGejala
            tbGejala.AllowUserToAddRows = false;
            tbGejala.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tbGejala.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            tbGejala.BackgroundColor = Color.FromArgb(184, 237, 248);
            tbGejala.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbGejala.Columns.AddRange(new DataGridViewColumn[] { ID, nama_gejala, btnUpdate, btnDelete });
            tbGejala.GridColor = Color.FromArgb(120, 195, 233);
            tbGejala.Location = new Point(400, 170);
            tbGejala.MultiSelect = false;
            tbGejala.Name = "tbGejala";
            tbGejala.ReadOnly = true;
            tbGejala.RowHeadersVisible = false;
            tbGejala.RowHeadersWidth = 62;
            tbGejala.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tbGejala.ShowRowErrors = false;
            tbGejala.Size = new Size(970, 800);
            tbGejala.TabIndex = 3;
            tbGejala.CellClick += tbGejala_CellClick;

            // ID
            ID.HeaderText = "ID";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;

            // nama_gejala
            nama_gejala.HeaderText = "Nama Gejala";
            nama_gejala.MinimumWidth = 8;
            nama_gejala.Name = "nama_gejala";
            nama_gejala.ReadOnly = true;

            // btnUpdate
            cellStyleUpdate.Alignment = DataGridViewContentAlignment.MiddleCenter;
            cellStyleUpdate.BackColor = Color.Khaki;
            btnUpdate.DefaultCellStyle = cellStyleUpdate;
            btnUpdate.HeaderText = "Action";
            btnUpdate.MinimumWidth = 8;
            btnUpdate.Name = "btnUpdate";
            btnUpdate.ReadOnly = true;
            btnUpdate.Text = "Update";
            btnUpdate.UseColumnTextForButtonValue = true;

            // btnDelete
            cellStyleDelete.Alignment = DataGridViewContentAlignment.MiddleCenter;
            cellStyleDelete.BackColor = Color.FromArgb(255, 128, 128);
            btnDelete.DefaultCellStyle = cellStyleDelete;
            btnDelete.HeaderText = "";
            btnDelete.MinimumWidth = 8;
            btnDelete.Name = "btnDelete";
            btnDelete.ReadOnly = true;
            btnDelete.Text = "Delete";
            btnDelete.UseColumnTextForButtonValue = true;

            // Gejala
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.bg;
            ClientSize = new Size(1440, 1024);
            Controls.Add(tbGejala);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnTambah);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Gejala";
            Text = "Gejala";
            Load += Gejala_Load;
            ((System.ComponentModel.ISupportInitialize)tbGejala).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTambah;
        private TextBox txtSearch;
        private Button btnSearch;
        private DataGridView tbGejala;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn nama_gejala;
        private DataGridViewButtonColumn btnUpdate;
        private DataGridViewButtonColumn btnDelete;
    }
}
