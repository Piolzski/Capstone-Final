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
            button3 = new Button();
            button1 = new Button();
            label7 = new Label();
            textBoxTime = new TextBox();
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
            textBoxgrp = new TextBox();
            label17 = new Label();
            textBoxColorCode = new TextBox();
            label18 = new Label();
            textBoxTextColor = new TextBox();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            panel3 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            panel6 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(439, 46);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 27);
            textBox1.TabIndex = 23;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(255, 51);
            label10.Name = "label10";
            label10.Size = new Size(129, 28);
            label10.TabIndex = 22;
            label10.Text = "Hospital ID:";
            // 
            // button4
            // 
            button4.BackColor = Color.DarkOrange;
            button4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ButtonFace;
            button4.Location = new Point(22, 495);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(166, 51);
            button4.TabIndex = 21;
            button4.Text = "UPDATE";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // TextBoxDept
            // 
            TextBoxDept.Location = new Point(22, 225);
            TextBoxDept.Margin = new Padding(3, 4, 3, 4);
            TextBoxDept.Name = "TextBoxDept";
            TextBoxDept.Size = new Size(238, 27);
            TextBoxDept.TabIndex = 19;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkOrange;
            button3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(22, 371);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(166, 51);
            button3.TabIndex = 17;
            button3.Text = "DELETE";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOrange;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(22, 247);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(166, 51);
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
            label7.Location = new Point(255, 95);
            label7.Name = "label7";
            label7.Size = new Size(164, 28);
            label7.TabIndex = 11;
            label7.Text = "Hospital Name:";
            label7.Click += label7_Click;
            // 
            // textBoxTime
            // 
            textBoxTime.Location = new Point(22, 115);
            textBoxTime.Margin = new Padding(3, 4, 3, 4);
            textBoxTime.Name = "textBoxTime";
            textBoxTime.Size = new Size(238, 27);
            textBoxTime.TabIndex = 9;
            // 
            // textBoxSpec
            // 
            textBoxSpec.BackColor = SystemColors.Window;
            textBoxSpec.Location = new Point(214, 225);
            textBoxSpec.Margin = new Padding(3, 4, 3, 4);
            textBoxSpec.Name = "textBoxSpec";
            textBoxSpec.Size = new Size(246, 29);
            textBoxSpec.TabIndex = 6;
            // 
            // textBoxName
            // 
            textBoxName.BackColor = SystemColors.Window;
            textBoxName.Location = new Point(214, 171);
            textBoxName.Margin = new Padding(3, 4, 3, 4);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(246, 29);
            textBoxName.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(117, 49);
            label3.Name = "label3";
            label3.Size = new Size(326, 33);
            label3.TabIndex = 2;
            label3.Text = "CLINICAL INSTRUCTOR";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Chocolate;
            label2.Location = new Point(55, 226);
            label2.Name = "label2";
            label2.Size = new Size(137, 28);
            label2.TabIndex = 1;
            label2.Text = "Designation:";
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.SandyBrown;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(-10, 38);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(231, 60);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Chocolate;
            label1.Location = new Point(117, 168);
            label1.Name = "label1";
            label1.Size = new Size(75, 28);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            label1.Click += label1_Click;
            // 
            // textBoxHos
            // 
            textBoxHos.Location = new Point(439, 91);
            textBoxHos.Margin = new Padding(3, 4, 3, 4);
            textBoxHos.Name = "textBoxHos";
            textBoxHos.Size = new Size(205, 27);
            textBoxHos.TabIndex = 12;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(255, 128, 0);
            label11.Location = new Point(397, 11);
            label11.Name = "label11";
            label11.Size = new Size(125, 33);
            label11.TabIndex = 24;
            label11.Text = "Hospital";
            label11.Click += label11_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(76, 49);
            label5.Name = "label5";
            label5.Size = new Size(149, 33);
            label5.TabIndex = 25;
            label5.Text = "Time Shift";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(99, 167);
            label4.Name = "label4";
            label4.Size = new Size(77, 33);
            label4.TabIndex = 26;
            label4.Text = "Area";
            label4.Click += label4_Click_1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Chocolate;
            label8.Location = new Point(46, 116);
            label8.Name = "label8";
            label8.Size = new Size(146, 28);
            label8.TabIndex = 27;
            label8.Text = "Instructor ID:";
            // 
            // textBoxID
            // 
            textBoxID.BackColor = SystemColors.Window;
            textBoxID.Location = new Point(214, 115);
            textBoxID.Margin = new Padding(3, 4, 3, 4);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(246, 29);
            textBoxID.TabIndex = 28;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(255, 128, 0);
            label12.Location = new Point(397, 28);
            label12.Name = "label12";
            label12.Size = new Size(152, 33);
            label12.TabIndex = 29;
            label12.Text = "Year Level";
            label12.Click += label12_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(277, 122);
            label13.Name = "label13";
            label13.Size = new Size(119, 28);
            label13.TabIndex = 30;
            label13.Text = "Year Level:";
            // 
            // textBoxLVL
            // 
            textBoxLVL.Location = new Point(438, 127);
            textBoxLVL.Margin = new Padding(3, 4, 3, 4);
            textBoxLVL.Name = "textBoxLVL";
            textBoxLVL.Size = new Size(205, 27);
            textBoxLVL.TabIndex = 31;
            textBoxLVL.TextChanged += textBox2_TextChanged;
            // 
            // textBoxLVLID
            // 
            textBoxLVLID.Location = new Point(439, 78);
            textBoxLVLID.Margin = new Padding(3, 4, 3, 4);
            textBoxLVLID.Name = "textBoxLVLID";
            textBoxLVLID.Size = new Size(204, 27);
            textBoxLVLID.TabIndex = 33;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(255, 78);
            label14.Name = "label14";
            label14.Size = new Size(147, 28);
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
            label15.Location = new Point(32, 293);
            label15.Name = "label15";
            label15.Size = new Size(205, 33);
            label15.TabIndex = 36;
            label15.Text = "Group Number";
            // 
            // textBoxgrp
            // 
            textBoxgrp.Location = new Point(22, 357);
            textBoxgrp.Margin = new Padding(3, 4, 3, 4);
            textBoxgrp.Name = "textBoxgrp";
            textBoxgrp.Size = new Size(238, 27);
            textBoxgrp.TabIndex = 35;
            textBoxgrp.TextChanged += textBoxgrp_TextChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.Chocolate;
            label17.Location = new Point(64, 274);
            label17.Name = "label17";
            label17.Size = new Size(128, 28);
            label17.TabIndex = 37;
            label17.Text = "Color Code:";
            // 
            // textBoxColorCode
            // 
            textBoxColorCode.BackColor = SystemColors.Window;
            textBoxColorCode.Location = new Point(214, 277);
            textBoxColorCode.Margin = new Padding(3, 4, 3, 4);
            textBoxColorCode.Name = "textBoxColorCode";
            textBoxColorCode.Size = new Size(246, 29);
            textBoxColorCode.TabIndex = 38;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Transparent;
            label18.Font = new Font("Segoe UI Black", 8F, FontStyle.Bold);
            label18.ForeColor = Color.Chocolate;
            label18.Location = new Point(18, 343);
            label18.Name = "label18";
            label18.Size = new Size(174, 19);
            label18.TabIndex = 39;
            label18.Text = "Background Text Color:";
            // 
            // textBoxTextColor
            // 
            textBoxTextColor.BackColor = SystemColors.Window;
            textBoxTextColor.Location = new Point(214, 337);
            textBoxTextColor.Margin = new Padding(3, 4, 3, 4);
            textBoxTextColor.Name = "textBoxTextColor";
            textBoxTextColor.Size = new Size(246, 29);
            textBoxTextColor.TabIndex = 40;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Moccasin;
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
            panel1.Location = new Point(265, 82);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(549, 430);
            panel1.TabIndex = 41;
            panel1.Paint += panel1_Paint_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(101, 11);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(709, 371);
            dataGridView1.TabIndex = 48;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Moccasin;
            panel3.Controls.Add(dataGridView1);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(textBoxHos);
            panel3.Location = new Point(265, 649);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(966, 150);
            panel3.TabIndex = 43;
            panel3.Paint += panel3_Paint;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Moccasin;
            panel5.Controls.Add(textBoxLVLID);
            panel5.Controls.Add(label14);
            panel5.Controls.Add(textBoxLVL);
            panel5.Controls.Add(label13);
            panel5.Controls.Add(label12);
            panel5.Location = new Point(265, 807);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(966, 193);
            panel5.TabIndex = 45;
            panel5.Paint += panel5_Paint;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Khaki;
            panel4.Controls.Add(button1);
            panel4.Controls.Add(button4);
            panel4.Controls.Add(button3);
            panel4.Location = new Point(0, 98);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(221, 986);
            panel4.TabIndex = 46;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Moccasin;
            panel6.BorderStyle = BorderStyle.Fixed3D;
            panel6.Controls.Add(label15);
            panel6.Controls.Add(textBoxgrp);
            panel6.Controls.Add(label4);
            panel6.Controls.Add(label5);
            panel6.Controls.Add(TextBoxDept);
            panel6.Controls.Add(textBoxTime);
            panel6.Location = new Point(862, 82);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(291, 430);
            panel6.TabIndex = 47;
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1921, 40);
            panel2.TabIndex = 48;
            // 
            // DataGenerator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1920, 1080);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(panel3);
            Controls.Add(panel6);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "DataGenerator";
            Text = "Data_Generator";
            Load += Data_Generator_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox textBoxSpec;
        private TextBox textBoxName;
        private Label label3;
        private Label label2;
        private TextBox textBoxTime;
        private Label label7;
        private Button button1;
        private PictureBox pictureBox1;
        private Button button3;
        private TextBox TextBoxDept;
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
        private TextBox textBoxgrp;
        private Label label17;
        private TextBox textBoxColorCode;
        private Label label18;
        private TextBox textBoxTextColor;
        private Panel panel1;
        private Panel panel3;
        private Panel panel5;
        private Panel panel4;
        private Panel panel6;
        private DataGridView dataGridView1;
        private Panel panel2;
    }
}