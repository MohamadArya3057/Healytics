namespace Healytics_PBO.View
{
    partial class Transaksi
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
            tbTransaksi = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            tanggal = new DataGridViewTextBoxColumn();
            nama = new DataGridViewTextBoxColumn();
            harga = new DataGridViewTextBoxColumn();
            jumlah = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)tbTransaksi).BeginInit();
            SuspendLayout();
            // 
            // tbTransaksi
            // 
            tbTransaksi.AllowUserToAddRows = false;
            tbTransaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tbTransaksi.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            tbTransaksi.BackgroundColor = Color.FromArgb(184, 237, 248);
            tbTransaksi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbTransaksi.Columns.AddRange(new DataGridViewColumn[] { ID, tanggal, nama, harga, jumlah, total });
            tbTransaksi.GridColor = Color.FromArgb(120, 195, 233);
            tbTransaksi.Location = new Point(416, 203);
            tbTransaksi.MultiSelect = false;
            tbTransaksi.Name = "tbTransaksi";
            tbTransaksi.ReadOnly = true;
            tbTransaksi.RowHeadersVisible = false;
            tbTransaksi.RowHeadersWidth = 62;
            tbTransaksi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tbTransaksi.ShowRowErrors = false;
            tbTransaksi.Size = new Size(970, 229);
            tbTransaksi.TabIndex = 6;
            // 
            // ID
            // 
            ID.HeaderText = "ID Transaksi";
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
            // nama
            // 
            nama.HeaderText = "Nama Pasien";
            nama.MinimumWidth = 8;
            nama.Name = "nama";
            nama.ReadOnly = true;
            // 
            // harga
            // 
            harga.HeaderText = "Harga";
            harga.MinimumWidth = 8;
            harga.Name = "harga";
            harga.ReadOnly = true;
            // 
            // jumlah
            // 
            jumlah.HeaderText = "Jumlah";
            jumlah.MinimumWidth = 8;
            jumlah.Name = "jumlah";
            jumlah.ReadOnly = true;
            // 
            // total
            // 
            total.HeaderText = "Total";
            total.MinimumWidth = 8;
            total.Name = "total";
            total.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold", 20F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(19, 62, 135);
            label1.Location = new Point(406, 115);
            label1.Name = "label1";
            label1.Size = new Size(231, 48);
            label1.TabIndex = 19;
            label1.Text = "TRANSAKSI";
            // 
            // Transaksi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg;
            ClientSize = new Size(1440, 1024);
            Controls.Add(label1);
            Controls.Add(tbTransaksi);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Transaksi";
            Text = "Transaksi";
            Load += Transaksi_Load;
            ((System.ComponentModel.ISupportInitialize)tbTransaksi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tbTransaksi;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn tanggal;
        private DataGridViewTextBoxColumn nama;
        private DataGridViewTextBoxColumn harga;
        private DataGridViewTextBoxColumn jumlah;
        private DataGridViewTextBoxColumn total;
        private Label label1;
    }
}