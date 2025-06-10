namespace NEW_PROJEKAN_PBO
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
            dgvAlat = new DataGridView();
            btnTambah = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAlat).BeginInit();
            SuspendLayout();
            // 
            // dgvAlat
            // 
            dgvAlat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlat.Location = new Point(831, 163);
            dgvAlat.Name = "dgvAlat";
            dgvAlat.Size = new Size(617, 460);
            dgvAlat.TabIndex = 3;
            dgvAlat.CellContentClick += dgvAlat_CellContentClick;
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(251, 163);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(75, 23);
            btnTambah.TabIndex = 4;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += btnTambah_Click;
            // 
            // Alat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1670, 1000);
            Controls.Add(btnTambah);
            Controls.Add(dgvAlat);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Alat";
            Text = "Alat";
            ((System.ComponentModel.ISupportInitialize)dgvAlat).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvAlat;
        private Button btnTambah;
    }
}