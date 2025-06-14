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
            lblTanggal = new Label();
            dtTanggal = new DateTimePicker();
            lblCatatan = new Label();
            txtCatatan = new TextBox();
            lblGejala = new Label();
            clbGejala = new CheckedListBox();
            lblObat = new Label();
            dgvObat = new DataGridView();
            btnSimpan = new Button();
            obatModelBindingSource = new BindingSource(components);
            colObat = new DataGridViewComboBoxColumn();
            colJumlah = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvObat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)obatModelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // lblTanggal
            // 
            lblTanggal.AutoSize = true;
            lblTanggal.Location = new Point(414, 134);
            lblTanggal.Name = "lblTanggal";
            lblTanggal.Size = new Size(73, 25);
            lblTanggal.TabIndex = 0;
            lblTanggal.Text = "Tanggal";
            // 
            // dtTanggal
            // 
            dtTanggal.Location = new Point(607, 134);
            dtTanggal.Name = "dtTanggal";
            dtTanggal.Size = new Size(300, 31);
            dtTanggal.TabIndex = 1;
            // 
            // lblCatatan
            // 
            lblCatatan.AutoSize = true;
            lblCatatan.Location = new Point(414, 195);
            lblCatatan.Name = "lblCatatan";
            lblCatatan.Size = new Size(72, 25);
            lblCatatan.TabIndex = 2;
            lblCatatan.Text = "Catatan";
            // 
            // txtCatatan
            // 
            txtCatatan.Location = new Point(609, 196);
            txtCatatan.Name = "txtCatatan";
            txtCatatan.Size = new Size(150, 31);
            txtCatatan.TabIndex = 3;
            // 
            // lblGejala
            // 
            lblGejala.AutoSize = true;
            lblGejala.Location = new Point(414, 256);
            lblGejala.Name = "lblGejala";
            lblGejala.Size = new Size(59, 25);
            lblGejala.TabIndex = 4;
            lblGejala.Text = "Gejala";
            // 
            // clbGejala
            // 
            clbGejala.FormattingEnabled = true;
            clbGejala.Location = new Point(612, 256);
            clbGejala.Name = "clbGejala";
            clbGejala.Size = new Size(180, 144);
            clbGejala.TabIndex = 5;
            // 
            // lblObat
            // 
            lblObat.AutoSize = true;
            lblObat.Location = new Point(414, 458);
            lblObat.Name = "lblObat";
            lblObat.Size = new Size(52, 25);
            lblObat.TabIndex = 6;
            lblObat.Text = "Obat";
            // 
            // dgvObat
            // 
            dgvObat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvObat.Columns.AddRange(new DataGridViewColumn[] { colObat, colJumlah });
            dgvObat.Location = new Point(608, 448);
            dgvObat.Name = "dgvObat";
            dgvObat.RowHeadersWidth = 62;
            dgvObat.Size = new Size(360, 225);
            dgvObat.TabIndex = 7;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(414, 766);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(112, 34);
            btnSimpan.TabIndex = 8;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            // 
            // obatModelBindingSource
            // 
            obatModelBindingSource.DataSource = typeof(Model.ObatModel);
            // 
            // colObat
            // 
            colObat.DataPropertyName = "id_obat";
            colObat.DataSource = obatModelBindingSource;
            colObat.HeaderText = "Obat";
            colObat.MinimumWidth = 8;
            colObat.Name = "colObat";
            colObat.Width = 150;
            // 
            // colJumlah
            // 
            colJumlah.HeaderText = "Jumlah";
            colJumlah.MinimumWidth = 8;
            colJumlah.Name = "colJumlah";
            colJumlah.Width = 150;
            // 
            // TambahEditRiwayat
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.bg;
            ClientSize = new Size(1440, 1024);
            Controls.Add(btnSimpan);
            Controls.Add(dgvObat);
            Controls.Add(lblObat);
            Controls.Add(clbGejala);
            Controls.Add(lblGejala);
            Controls.Add(txtCatatan);
            Controls.Add(lblCatatan);
            Controls.Add(dtTanggal);
            Controls.Add(lblTanggal);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TambahEditRiwayat";
            Text = "TambahEditRiwayat";
            ((System.ComponentModel.ISupportInitialize)dgvObat).EndInit();
            ((System.ComponentModel.ISupportInitialize)obatModelBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTanggal;
        private DateTimePicker dtTanggal;
        private Label lblCatatan;
        private TextBox txtCatatan;
        private Label lblGejala;
        private CheckedListBox clbGejala;
        private Label lblObat;
        private DataGridView dgvObat;
        private Button btnSimpan;
        private BindingSource obatModelBindingSource;
        private DataGridViewComboBoxColumn colObat;
        private DataGridViewTextBoxColumn colJumlah;
    }
}