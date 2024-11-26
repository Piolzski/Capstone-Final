namespace WinFormsApp3
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.AutoSize = true;
            button2.BackColor = Color.Orange;
            button2.Font = new Font("Bahnschrift", 12F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(725, 454);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(182, 45);
            button2.TabIndex = 2;
            button2.Text = "Generate Data\r\n";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.AutoSize = true;
            button1.BackColor = Color.Orange;
            button1.Font = new Font("Bahnschrift", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(725, 402);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(182, 45);
            button1.TabIndex = 5;
            button1.Text = "Fill Rotation";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button3.AutoSize = true;
            button3.BackColor = Color.Orange;
            button3.Font = new Font("Bahnschrift", 12F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(725, 506);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(182, 45);
            button3.TabIndex = 4;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1062, 676);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterParent;
            Load += Dashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox5;
        private Button button2;
        private Button button1;
        private Button button3;
    }
}