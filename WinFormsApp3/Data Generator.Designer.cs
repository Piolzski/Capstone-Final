namespace WinFormsApp3
{
    partial class DataGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataGenerator));
            textBox1 = new TextBox();
            label10 = new Label();
            button4 = new Button();
            TextBoxDept = new TextBox();
            label9 = new Label();
            button3 = new Button();
            button1 = new Button();
            label7 = new Label();
            textBoxTime = new TextBox();
            label6 = new Label();
            textBoxSpec = new TextBox();
            textBoxName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            textBoxHos = new TextBox();
            label11 = new Label();
            label5 = new Label();
            label4 = new Label();
            label8 = new Label();
            textBoxID = new TextBox();
            label12 = new Label();
            label13 = new Label();
            textBoxLVL = new TextBox();
            textBoxLVLID = new TextBox();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            textBoxgrp = new TextBox();
            label17 = new Label();
            textBoxColorCode = new TextBox();
            label18 = new Label();
            textBoxTextColor = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel5 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(384, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(180, 25);
            textBox1.TabIndex = 23;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(223, 43);
            label10.Name = "label10";
            label10.Size = new Size(104, 21);
            label10.TabIndex = 22;
            label10.Text = "Hospital ID:";
            // 
            // button4
            // 
            button4.BackColor = Color.Peru;
            button4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(1126, 633);
            button4.Name = "button4";
            button4.Size = new Size(243, 90);
            button4.TabIndex = 21;
            button4.Text = "UPDATE";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // TextBoxDept
            // 
            TextBoxDept.Location = new Point(1198, 224);
            TextBoxDept.Name = "TextBoxDept";
            TextBoxDept.Size = new Size(209, 25);
            TextBoxDept.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(255, 255, 192);
            label9.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(255, 128, 0);
            label9.Location = new Point(1126, 226);
            label9.Name = "label9";
            label9.Size = new Size(52, 21);
            label9.TabIndex = 18;
            label9.Text = "Area:";
            // 
            // button3
            // 
            button3.BackColor = Color.SandyBrown;
            button3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(1126, 527);
            button3.Name = "button3";
            button3.Size = new Size(243, 90);
            button3.TabIndex = 17;
            button3.Text = "DELETE";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Bisque;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(1126, 422);
            button1.Name = "button1";
            button1.Size = new Size(243, 90);
            button1.TabIndex = 15;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(223, 81);
            label7.Name = "label7";
            label7.Size = new Size(132, 21);
            label7.TabIndex = 11;
            label7.Text = "Hospital Name:";
            label7.Click += label7_Click;
            // 
            // textBoxTime
            // 
            textBoxTime.Location = new Point(1198, 153);
            textBoxTime.Name = "textBoxTime";
            textBoxTime.Size = new Size(209, 25);
            textBoxTime.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(255, 255, 192);
            label6.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(255, 128, 0);
            label6.Location = new Point(1124, 156);
            label6.Name = "label6";
            label6.Size = new Size(54, 21);
            label6.TabIndex = 8;
            label6.Text = "Time:";
            // 
            // textBoxSpec
            // 
            textBoxSpec.Location = new Point(577, 54);
            textBoxSpec.Name = "textBoxSpec";
            textBoxSpec.Size = new Size(216, 25);
            textBoxSpec.TabIndex = 6;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(187, 116);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(216, 25);
            textBoxName.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(255, 128, 0);
            label3.Location = new Point(296, 11);
            label3.Name = "label3";
            label3.Size = new Size(260, 27);
            label3.TabIndex = 2;
            label3.Text = "CLINICAL INSTRUCTOR";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(445, 59);
            label2.Name = "label2";
            label2.Size = new Size(110, 21);
            label2.TabIndex = 1;
            label2.Text = "Designation:";
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(12, 63);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 52);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(59, 119);
            label1.Name = "label1";
            label1.Size = new Size(61, 21);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            label1.Click += label1_Click;
            // 
            // textBoxHos
            // 
            textBoxHos.Location = new Point(384, 77);
            textBoxHos.Name = "textBoxHos";
            textBoxHos.Size = new Size(180, 25);
            textBoxHos.TabIndex = 12;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(255, 128, 0);
            label11.Location = new Point(347, 9);
            label11.Name = "label11";
            label11.Size = new Size(120, 27);
            label11.TabIndex = 24;
            label11.Text = "HOSPITAL";
            label11.Click += label11_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(1172, 119);
            label5.Name = "label5";
            label5.Size = new Size(135, 27);
            label5.TabIndex = 25;
            label5.Text = "TIME SHIFT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(1198, 192);
            label4.Name = "label4";
            label4.Size = new Size(61, 27);
            label4.TabIndex = 26;
            label4.Text = "Area";
            label4.Click += label4_Click_1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(59, 68);
            label8.Name = "label8";
            label8.Size = new Size(117, 21);
            label8.TabIndex = 27;
            label8.Text = "Instructor ID:";
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(187, 68);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(216, 25);
            textBoxID.TabIndex = 28;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(255, 128, 0);
            label12.Location = new Point(347, 24);
            label12.Name = "label12";
            label12.Size = new Size(116, 27);
            label12.TabIndex = 29;
            label12.Text = "YearLevel";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(242, 104);
            label13.Name = "label13";
            label13.Size = new Size(95, 21);
            label13.TabIndex = 30;
            label13.Text = "Year Level:";
            // 
            // textBoxLVL
            // 
            textBoxLVL.Location = new Point(383, 108);
            textBoxLVL.Name = "textBoxLVL";
            textBoxLVL.Size = new Size(180, 25);
            textBoxLVL.TabIndex = 31;
            textBoxLVL.TextChanged += textBox2_TextChanged;
            // 
            // textBoxLVLID
            // 
            textBoxLVLID.Location = new Point(384, 66);
            textBoxLVLID.Name = "textBoxLVLID";
            textBoxLVLID.Size = new Size(179, 25);
            textBoxLVLID.TabIndex = 33;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(223, 66);
            label14.Name = "label14";
            label14.Size = new Size(117, 21);
            label14.TabIndex = 32;
            label14.Text = "Year Level ID:";
            label14.Click += label14_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Black;
            label15.Location = new Point(1198, 255);
            label15.Name = "label15";
            label15.Size = new Size(75, 27);
            label15.TabIndex = 36;
            label15.Text = "Group";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.FromArgb(255, 255, 192);
            label16.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.FromArgb(255, 128, 0);
            label16.Location = new Point(1085, 289);
            label16.Name = "label16";
            label16.Size = new Size(102, 21);
            label16.TabIndex = 34;
            label16.Text = "GroupNum:";
            // 
            // textBoxgrp
            // 
            textBoxgrp.Location = new Point(1198, 287);
            textBoxgrp.Name = "textBoxgrp";
            textBoxgrp.Size = new Size(209, 25);
            textBoxgrp.TabIndex = 35;
            textBoxgrp.TextChanged += textBoxgrp_TextChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.Black;
            label17.Location = new Point(450, 95);
            label17.Name = "label17";
            label17.Size = new Size(100, 21);
            label17.TabIndex = 37;
            label17.Text = "Color Code:";
            // 
            // textBoxColorCode
            // 
            textBoxColorCode.Location = new Point(577, 95);
            textBoxColorCode.Name = "textBoxColorCode";
            textBoxColorCode.Size = new Size(216, 25);
            textBoxColorCode.TabIndex = 38;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Transparent;
            label18.Font = new Font("Segoe UI Black", 8F, FontStyle.Bold);
            label18.ForeColor = Color.Black;
            label18.Location = new Point(413, 142);
            label18.Name = "label18";
            label18.Size = new Size(137, 13);
            label18.TabIndex = 39;
            label18.Text = "Background Text Color:";
            // 
            // textBoxTextColor
            // 
            textBoxTextColor.Location = new Point(577, 136);
            textBoxTextColor.Name = "textBoxTextColor";
            textBoxTextColor.Size = new Size(216, 25);
            textBoxTextColor.TabIndex = 40;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(textBoxTextColor);
            panel1.Controls.Add(label18);
            panel1.Controls.Add(textBoxColorCode);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(textBoxID);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBoxName);
            panel1.Controls.Add(textBoxSpec);
            panel1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.Location = new Point(104, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(846, 197);
            panel1.TabIndex = 41;
            panel1.Paint += panel1_Paint_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkOrange;
            panel2.Location = new Point(-9, -5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1048, 50);
            panel2.TabIndex = 42;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(textBoxHos);
            panel3.Location = new Point(104, 289);
            panel3.Name = "panel3";
            panel3.Size = new Size(846, 128);
            panel3.TabIndex = 43;
            panel3.Paint += panel3_Paint;
            // 
            // panel5
            // 
            panel5.BackColor = Color.WhiteSmoke;
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(textBoxLVLID);
            panel5.Controls.Add(label14);
            panel5.Controls.Add(textBoxLVL);
            panel5.Controls.Add(label13);
            panel5.Controls.Add(label12);
            panel5.Location = new Point(104, 445);
            panel5.Name = "panel5";
            panel5.Size = new Size(846, 165);
            panel5.TabIndex = 45;
            panel5.Paint += panel5_Paint;
            // 
            // DataGenerator
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 95, 30);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1195, 633);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label15);
            Controls.Add(label16);
            Controls.Add(textBoxgrp);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label9);
            Controls.Add(TextBoxDept);
            Controls.Add(button4);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(textBoxTime);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(panel3);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "DataGenerator";
            Text = "Data_Generator";
            Load += Data_Generator_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxSpec;
        private TextBox textBoxName;
        private Label label3;
        private Label label2;
        private TextBox textBoxTime;
        private Label label6;
        private Label label7;
        private Button button1;
        private PictureBox pictureBox1;
        private Button button3;
        private TextBox TextBoxDept;
        private Label label9;
        private Button button4;
        private TextBox textBox1;
        private Label label10;
        private Label label1;
        private TextBox textBoxHos;
        private Label label11;
        private Label label5;
        private Label label4;
        private Label label8;
        private TextBox textBoxID;
        private Label label12;
        private Label label13;
        private TextBox textBoxLVL;
        private TextBox textBoxLVLID;
        private Label label14;
        private Label label15;
        private Label label16;
        private TextBox textBoxgrp;
        private Label label17;
        private TextBox textBoxColorCode;
        private Label label18;
        private TextBox textBoxTextColor;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel5;
    }
}