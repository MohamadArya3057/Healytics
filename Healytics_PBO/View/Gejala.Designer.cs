namespace Healytics_PBO.View
{
    partial class Gejala
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
            tbGejala = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            nama_gejala = new DataGridViewTextBoxColumn();
            btnUpdate = new DataGridViewButtonColumn();
            btnDelete = new DataGridViewButtonColumn();
            btnSearch = new Button();
            txtSearch = new TextBox();
            btnTambah = new Button();
            ((System.ComponentModel.ISupportInitialize)tbGejala).BeginInit();
            SuspendLayout();
            // 
            // tbGejala
            // 
            tbGejala.AllowUserToAddRows = false;
            tbGejala.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tbGejala.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            tbGejala.BackgroundColor = Color.FromArgb(184, 237, 248);
            tbGejala.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbGejala.Columns.AddRange(new DataGridViewColumn[] { ID, nama_gejala, btnUpdate, btnDelete });
            tbGejala.GridColor = Color.FromArgb(120, 195, 233);
            tbGejala.Location = new Point(374, 142);
            tbGejala.Margin = new Padding(2, 2, 2, 2);
            tbGejala.MultiSelect = false;
            tbGejala.Name = "tbGejala";
            tbGejala.ReadOnly = true;
            tbGejala.RowHeadersVisible = false;
            tbGejala.RowHeadersWidth = 62;
            tbGejala.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tbGejala.ShowRowErrors = false;
            tbGejala.Size = new Size(776, 640);
            tbGejala.TabIndex = 13;
            tbGejala.CellClick += tbGejala_CellClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID Gejala";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            // 
            // nama_gejala
            // 
            nama_gejala.HeaderText = "Nama Gejala";
            nama_gejala.MinimumWidth = 8;
            nama_gejala.Name = "nama_gejala";
            nama_gejala.ReadOnly = true;
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
            btnSearch.Location = new Point(1054, 90);
            btnSearch.Margin = new Padding(2, 2, 2, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(52, 24);
            btnSearch.TabIndex = 12;
            btnSearch.Text = "search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(120, 195, 233);
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(826, 90);
            txtSearch.Margin = new Padding(2, 2, 2, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(280, 25);
            txtSearch.TabIndex = 11;
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.White;
            btnTambah.FlatAppearance.BorderColor = Color.SteelBlue;
            btnTambah.FlatAppearance.BorderSize = 3;
            btnTambah.FlatStyle = FlatStyle.Flat;
            btnTambah.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTambah.ForeColor = Color.SteelBlue;
            btnTambah.Location = new Point(384, 90);
            btnTambah.Margin = new Padding(2, 2, 2, 2);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(96, 32);
            btnTambah.TabIndex = 10;
            btnTambah.Text = "Add Data";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // Gejala
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.bg;
            ClientSize = new Size(1152, 819);
            Controls.Add(tbGejala);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnTambah);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 2, 2, 2);
            Name = "Gejala";
            Text = "Gejala";
            Load += Gejala_Load;
            ((System.ComponentModel.ISupportInitialize)tbGejala).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tbGejala;
        private Button btnSearch;
        private TextBox txtSearch;
        private Button btnTambah;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn nama_gejala;
        private DataGridViewButtonColumn btnUpdate;
        private DataGridViewButtonColumn btnDelete;
    }
}