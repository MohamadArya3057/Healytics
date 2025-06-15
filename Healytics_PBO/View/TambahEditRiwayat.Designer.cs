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
            components = new System.ComponentModel.Container();
            dtTanggal = new DateTimePicker();
            dgvObat = new DataGridView();
            colObat = new DataGridViewComboBoxColumn();
            obatModelBindingSource = new BindingSource(components);
            colJumlah = new DataGridViewTextBoxColumn();
            label1 = new Label();
            lblTanggal = new Label();
            lblCatatan = new Label();
            lblGejala = new Label();
            txtCatatan = new TextBox();
            lblObat = new Label();
            btnBatal = new Button();
            btnSimpan = new Button();
            clbGejala = new CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)dgvObat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)obatModelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dtTanggal
            // 
            dtTanggal.CalendarForeColor = Color.SteelBlue;
            dtTanggal.CalendarMonthBackground = Color.FromArgb(196, 227, 242);
            dtTanggal.CalendarTitleForeColor = Color.SteelBlue;
            dtTanggal.CalendarTrailingForeColor = Color.FromArgb(196, 227, 242);
            dtTanggal.Location = new Point(758, 279);
            dtTanggal.Name = "dtTanggal";
            dtTanggal.Size = new Size(500, 31);
            dtTanggal.TabIndex = 1;
            // 
            // dgvObat
            // 
            dgvObat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvObat.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvObat.BackgroundColor = Color.FromArgb(196, 227, 242);
            dgvObat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvObat.Columns.AddRange(new DataGridViewColumn[] { colObat, colJumlah });
            dgvObat.GridColor = Color.FromArgb(196, 227, 242);
            dgvObat.Location = new Point(758, 557);
            dgvObat.Name = "dgvObat";
            dgvObat.RowHeadersWidth = 62;
            dgvObat.Size = new Size(500, 70);
            dgvObat.TabIndex = 7;
            // 
            // colObat
            // 
            colObat.DataPropertyName = "id_obat";
            colObat.DataSource = obatModelBindingSource;
            colObat.HeaderText = "Obat";
            colObat.MinimumWidth = 8;
            colObat.Name = "colObat";
            // 
            // obatModelBindingSource
            // 
            obatModelBindingSource.DataSource = typeof(Model.ObatModel);
            // 
            // colJumlah
            // 
            colJumlah.HeaderText = "Jumlah";
            colJumlah.MinimumWidth = 8;
            colJumlah.Name = "colJumlah";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold", 30F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(19, 62, 135);
            label1.Location = new Point(423, 119);
            label1.Name = "label1";
            label1.Size = new Size(641, 72);
            label1.TabIndex = 9;
            label1.Text = "DATA RIWAYAT PASIEN";
            // 
            // lblTanggal
            // 
            lblTanggal.AutoSize = true;
            lblTanggal.BackColor = Color.White;
            lblTanggal.Font = new Font("Bahnschrift SemiBold", 18F, FontStyle.Bold);
            lblTanggal.ForeColor = Color.SteelBlue;
            lblTanggal.Location = new Point(441, 267);
            lblTanggal.Name = "lblTanggal";
            lblTanggal.Size = new Size(141, 43);
            lblTanggal.TabIndex = 10;
            lblTanggal.Text = "Tanggal";
            // 
            // lblCatatan
            // 
            lblCatatan.AutoSize = true;
            lblCatatan.BackColor = Color.White;
            lblCatatan.Font = new Font("Bahnschrift SemiBold", 18F, FontStyle.Bold);
            lblCatatan.ForeColor = Color.SteelBlue;
            lblCatatan.Location = new Point(441, 358);
            lblCatatan.Name = "lblCatatan";
            lblCatatan.Size = new Size(142, 43);
            lblCatatan.TabIndex = 11;
            lblCatatan.Text = "Catatan";
            // 
            // lblGejala
            // 
            lblGejala.AutoSize = true;
            lblGejala.BackColor = Color.White;
            lblGejala.Font = new Font("Bahnschrift SemiBold", 18F, FontStyle.Bold);
            lblGejala.ForeColor = Color.SteelBlue;
            lblGejala.Location = new Point(441, 456);
            lblGejala.Name = "lblGejala";
            lblGejala.Size = new Size(119, 43);
            lblGejala.TabIndex = 12;
            lblGejala.Text = "Gejala";
            // 
            // txtCatatan
            // 
            txtCatatan.BackColor = Color.FromArgb(196, 227, 242);
            txtCatatan.BorderStyle = BorderStyle.FixedSingle;
            txtCatatan.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCatatan.ForeColor = Color.SteelBlue;
            txtCatatan.Location = new Point(758, 360);
            txtCatatan.Name = "txtCatatan";
            txtCatatan.Size = new Size(500, 41);
            txtCatatan.TabIndex = 13;
            // 
            // lblObat
            // 
            lblObat.AutoSize = true;
            lblObat.BackColor = Color.White;
            lblObat.Font = new Font("Bahnschrift SemiBold", 18F, FontStyle.Bold);
            lblObat.ForeColor = Color.SteelBlue;
            lblObat.Location = new Point(441, 557);
            lblObat.Name = "lblObat";
            lblObat.Size = new Size(93, 43);
            lblObat.TabIndex = 15;
            lblObat.Text = "Obat";
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.Gray;
            btnBatal.FlatAppearance.BorderColor = Color.Gray;
            btnBatal.FlatAppearance.BorderSize = 3;
            btnBatal.FlatStyle = FlatStyle.Flat;
            btnBatal.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBatal.ForeColor = SystemColors.ButtonFace;
            btnBatal.Location = new Point(449, 707);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(108, 45);
            btnBatal.TabIndex = 17;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = false;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.ForestGreen;
            btnSimpan.FlatAppearance.BorderColor = Color.ForestGreen;
            btnSimpan.FlatAppearance.BorderSize = 3;
            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnSimpan.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSimpan.ForeColor = Color.Honeydew;
            btnSimpan.Location = new Point(584, 707);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(120, 45);
            btnSimpan.TabIndex = 16;
            btnSimpan.UseVisualStyleBackColor = false;
            // 
            // clbGejala
            // 
            clbGejala.BackColor = Color.FromArgb(196, 227, 242);
            clbGejala.Font = new Font("Bahnschrift SemiBold", 14F, FontStyle.Bold);
            clbGejala.ForeColor = Color.SteelBlue;
            clbGejala.FormattingEnabled = true;
            clbGejala.Location = new Point(758, 457);
            clbGejala.Name = "clbGejala";
            clbGejala.Size = new Size(500, 42);
            clbGejala.TabIndex = 18;
            // 
            // TambahEditRiwayat
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.bg;
            ClientSize = new Size(1440, 1024);
            Controls.Add(clbGejala);
            Controls.Add(btnBatal);
            Controls.Add(btnSimpan);
            Controls.Add(lblObat);
            Controls.Add(txtCatatan);
            Controls.Add(lblGejala);
            Controls.Add(lblCatatan);
            Controls.Add(lblTanggal);
            Controls.Add(label1);
            Controls.Add(dgvObat);
            Controls.Add(dtTanggal);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TambahEditRiwayat";
            Text = "TambahEditRiwayat";
            ((System.ComponentModel.ISupportInitialize)dgvObat).EndInit();
            ((System.ComponentModel.ISupportInitialize)obatModelBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dtTanggal;
        private DataGridView dgvObat;
        private BindingSource obatModelBindingSource;
        private DataGridViewComboBoxColumn colObat;
        private DataGridViewTextBoxColumn colJumlah;
        private Label label1;
        private Label lblTanggal;
        private Label lblCatatan;
        private Label lblGejala;
        private TextBox txtCatatan;
        private Label lblObat;
        private Button btnBatal;
        private Button btnSimpan;
        private CheckedListBox clbGejala;
    }
}