namespace Healytics_PBO.View
{
    partial class Gejala
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtNamaGejala = new TextBox();
            btnSimpan = new Button();
            btnBatal = new Button();
            label1 = new Label();
            label2 = new Label();

            SuspendLayout();
            // 
            // txtNamaGejala
            // 
            txtNamaGejala.BackColor = Color.FromArgb(196, 227, 242);
            txtNamaGejala.BorderStyle = BorderStyle.FixedSingle;
            txtNamaGejala.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNamaGejala.ForeColor = Color.SteelBlue;
            txtNamaGejala.Location = new Point(759, 346);
            txtNamaGejala.Name = "txtNamaGejala";
            txtNamaGejala.Size = new Size(500, 41);
            txtNamaGejala.TabIndex = 0;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.ForestGreen;
            btnSimpan.FlatAppearance.BorderColor = Color.ForestGreen;
            btnSimpan.FlatAppearance.BorderSize = 3;
            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnSimpan.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSimpan.ForeColor = Color.Honeydew;
            btnSimpan.Location = new Point(563, 500);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(120, 45);
            btnSimpan.TabIndex = 1;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.Gray;
            btnBatal.FlatAppearance.BorderColor = Color.Gray;
            btnBatal.FlatAppearance.BorderSize = 3;
            btnBatal.FlatStyle = FlatStyle.Flat;
            btnBatal.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBatal.ForeColor = SystemColors.ButtonFace;
            btnBatal.Location = new Point(428, 500);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(108, 45);
            btnBatal.TabIndex = 2;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = false;
            btnBatal.Click += btnBatal_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold", 30F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(19, 62, 135);
            label1.Location = new Point(434, 167);
            label1.Name = "label1";
            label1.Size = new Size(442, 72);
            label1.TabIndex = 3;
            label1.Text = "GEJALA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Bahnschrift SemiBold", 18F, FontStyle.Bold);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(434, 346);
            label2.Name = "label2";
            label2.Size = new Size(217, 43);
            label2.TabIndex = 4;
            label2.Text = "Nama Gejala";
            // 
            // TambahEditGejala
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.bg;
            ClientSize = new Size(1440, 1024);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBatal);
            Controls.Add(btnSimpan);
            Controls.Add(txtNamaGejala);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TambahEditGejala";
            Text = "TambahEditGejala";
            Load += TambahEditGejala_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNamaGejala;
        private Button btnSimpan;
        private Button btnBatal;
        private Label label1;
        private Label label2;
    }
}
