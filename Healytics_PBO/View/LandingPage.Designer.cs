namespace Healytics_PBO.View
{
    partial class LandingPage
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
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(19, 62, 135);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Franklin Gothic Medium Cond", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Window;
            button1.ImageAlign = ContentAlignment.BottomLeft;
            button1.Location = new Point(614, 604);
            button1.Name = "button1";
            button1.Size = new Size(213, 71);
            button1.TabIndex = 5;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // LandingPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Desktop___7__2_;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1418, 968);
            Controls.Add(button1);
            DoubleBuffered = true;
            Name = "LandingPage";
            Text = "LandingPage";
            Load += LandingPage_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
    }
}