namespace Healytics_PBO.View
{
    partial class Login
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
            button1 = new Button();
            button2 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LightBlue;
            button1.Font = new Font("Consolas", 10F);
            button1.ForeColor = SystemColors.MenuHighlight;
            button1.Location = new Point(1309, 524);
            button1.Name = "button1";
            button1.Size = new Size(28, 27);
            button1.TabIndex = 1;
            button1.Text = "*";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 5;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Bahnschrift Condensed", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.SteelBlue;
            button2.Location = new Point(810, 600);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(527, 67);
            button2.TabIndex = 6;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(221, 239, 247);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Bahnschrift", 10F);
            textBox2.ForeColor = Color.SlateGray;
            textBox2.Location = new Point(806, 526);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(531, 25);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(221, 239, 247);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Bahnschrift", 10F);
            textBox1.ForeColor = Color.SlateGray;
            textBox1.Location = new Point(806, 418);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(531, 25);
            textBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Bahnschrift", 12F);
            label3.ForeColor = Color.SlateGray;
            label3.Location = new Point(806, 483);
            label3.Name = "label3";
            label3.Size = new Size(119, 29);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Bahnschrift", 12F);
            label2.ForeColor = Color.SlateGray;
            label2.Location = new Point(806, 374);
            label2.Name = "label2";
            label2.Size = new Size(124, 29);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Bahnschrift Condensed", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(892, 199);
            label1.Name = "label1";
            label1.Size = new Size(372, 115);
            label1.TabIndex = 0;
            label1.Text = "HEALYTICS";
            label1.Click += label1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.Desktop___10__2_;
            ClientSize = new Size(1440, 1024);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button2;
        private Button button1;
    }
}