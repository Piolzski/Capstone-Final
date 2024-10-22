namespace WinFormsApp3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            lstClinicalInstructors = new ListBox();
            lstYearLevels = new ListBox();
            lstDepartments = new ListBox();
            txtNumberOfWeeks = new TextBox();
            label8 = new Label();
            lstTimeShifts = new ListBox();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            button2 = new Button();
            RotationTextBox = new TextBox();
            label9 = new Label();
            button5 = new Button();
            button6 = new Button();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            groupbox2 = new TextBox();
            groupbox3 = new TextBox();
            groupbox4 = new TextBox();
            checkedListBox1 = new CheckedListBox();
            textBox1 = new TextBox();
            label13 = new Label();
            btnClinicalinstructor = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 50);
            label1.Name = "label1";
            label1.Size = new Size(150, 21);
            label1.TabIndex = 0;
            label1.Text = "Clinical Instructor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Wheat;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(628, 24);
            label2.Name = "label2";
            label2.Size = new Size(151, 21);
            label2.TabIndex = 1;
            label2.Text = "Number of Weeks:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Orange;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(922, 24);
            label3.Name = "label3";
            label3.Size = new Size(91, 21);
            label3.TabIndex = 2;
            label3.Text = "Year Level:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(59, 25);
            label4.Name = "label4";
            label4.Size = new Size(56, 21);
            label4.TabIndex = 3;
            label4.Text = "Areas:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(35, 74);
            label5.Name = "label5";
            label5.Size = new Size(68, 21);
            label5.TabIndex = 4;
            label5.Text = "Groups:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Wheat;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(181, 33);
            label6.Name = "label6";
            label6.Size = new Size(90, 21);
            label6.TabIndex = 5;
            label6.Text = "Start Date:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Wheat;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(188, 83);
            label7.Name = "label7";
            label7.Size = new Size(83, 21);
            label7.TabIndex = 6;
            label7.Text = "End Date:";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(290, 33);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(231, 25);
            dtpStartDate.TabIndex = 7;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(290, 83);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(231, 25);
            dtpEndDate.TabIndex = 8;
            // 
            // lstClinicalInstructors
            // 
            lstClinicalInstructors.FormattingEnabled = true;
            lstClinicalInstructors.ItemHeight = 17;
            lstClinicalInstructors.Location = new Point(201, 17);
            lstClinicalInstructors.Name = "lstClinicalInstructors";
            lstClinicalInstructors.SelectionMode = SelectionMode.MultiExtended;
            lstClinicalInstructors.Size = new Size(250, 89);
            lstClinicalInstructors.TabIndex = 9;
            lstClinicalInstructors.SelectedIndexChanged += lstClinicalInstructors_SelectedIndexChanged;
            // 
            // lstYearLevels
            // 
            lstYearLevels.FormattingEnabled = true;
            lstYearLevels.ItemHeight = 17;
            lstYearLevels.Location = new Point(907, 56);
            lstYearLevels.Name = "lstYearLevels";
            lstYearLevels.SelectionMode = SelectionMode.MultiExtended;
            lstYearLevels.Size = new Size(127, 55);
            lstYearLevels.TabIndex = 11;
            lstYearLevels.SelectedIndexChanged += lstYearLevels_SelectedIndexChanged;
            // 
            // lstDepartments
            // 
            lstDepartments.FormattingEnabled = true;
            lstDepartments.ItemHeight = 17;
            lstDepartments.Location = new Point(33, 59);
            lstDepartments.Name = "lstDepartments";
            lstDepartments.SelectionMode = SelectionMode.MultiExtended;
            lstDepartments.Size = new Size(115, 72);
            lstDepartments.TabIndex = 12;
            lstDepartments.SelectedIndexChanged += listBox4_SelectedIndexChanged;
            // 
            // txtNumberOfWeeks
            // 
            txtNumberOfWeeks.Location = new Point(609, 65);
            txtNumberOfWeeks.Name = "txtNumberOfWeeks";
            txtNumberOfWeeks.Size = new Size(184, 25);
            txtNumberOfWeeks.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Wheat;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(51, 24);
            label8.Name = "label8";
            label8.Size = new Size(92, 21);
            label8.TabIndex = 17;
            label8.Text = "Time Shift:";
            // 
            // lstTimeShifts
            // 
            lstTimeShifts.BackColor = Color.White;
            lstTimeShifts.FormattingEnabled = true;
            lstTimeShifts.ItemHeight = 17;
            lstTimeShifts.Location = new Point(37, 56);
            lstTimeShifts.Name = "lstTimeShifts";
            lstTimeShifts.SelectionMode = SelectionMode.MultiExtended;
            lstTimeShifts.Size = new Size(115, 55);
            lstTimeShifts.TabIndex = 18;
            lstTimeShifts.SelectedIndexChanged += lstTimeShifts_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Bookman Old Style", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(10, 204);
            button1.Name = "button1";
            button1.Size = new Size(192, 77);
            button1.TabIndex = 19;
            button1.Text = "Create Excel ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.SteelBlue;
            button3.Font = new Font("Bookman Old Style", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(10, 327);
            button3.Name = "button3";
            button3.Size = new Size(192, 77);
            button3.TabIndex = 20;
            button3.Text = "Open Excel";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Red;
            button4.Font = new Font("Bookman Old Style", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(10, 446);
            button4.Name = "button4";
            button4.Size = new Size(192, 77);
            button4.TabIndex = 21;
            button4.Text = "Close Excel";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Maroon;
            button2.Font = new Font("Bookman Old Style", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(10, 573);
            button2.Name = "button2";
            button2.Size = new Size(192, 77);
            button2.TabIndex = 22;
            button2.Text = "Delete Excel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // RotationTextBox
            // 
            RotationTextBox.Location = new Point(372, 72);
            RotationTextBox.Name = "RotationTextBox";
            RotationTextBox.Size = new Size(149, 25);
            RotationTextBox.TabIndex = 24;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(188, 72);
            label9.Name = "label9";
            label9.Size = new Size(151, 21);
            label9.TabIndex = 23;
            label9.Text = "Number of Weeks:";
            // 
            // button5
            // 
            button5.BackColor = Color.DarkOrange;
            button5.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(589, 59);
            button5.Name = "button5";
            button5.Size = new Size(224, 54);
            button5.TabIndex = 25;
            button5.Text = "Insert Areas To Excel";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.DarkOrange;
            button6.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.White;
            button6.Location = new Point(888, 59);
            button6.Name = "button6";
            button6.Size = new Size(167, 54);
            button6.TabIndex = 26;
            button6.Text = "Clear Areas";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(402, 43);
            label10.Name = "label10";
            label10.Size = new Size(138, 21);
            label10.TabIndex = 27;
            label10.Text = "2nd Year Groups:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Wheat;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(902, 43);
            label11.Name = "label11";
            label11.Size = new Size(134, 21);
            label11.TabIndex = 28;
            label11.Text = "4th Year Groups:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(659, 43);
            label12.Name = "label12";
            label12.Size = new Size(134, 21);
            label12.TabIndex = 29;
            label12.Text = "3rd Year Groups:";
            label12.Click += label12_Click;
            // 
            // groupbox2
            // 
            groupbox2.Location = new Point(408, 77);
            groupbox2.Name = "groupbox2";
            groupbox2.Size = new Size(115, 25);
            groupbox2.TabIndex = 30;
            // 
            // groupbox3
            // 
            groupbox3.Location = new Point(666, 77);
            groupbox3.Name = "groupbox3";
            groupbox3.Size = new Size(115, 25);
            groupbox3.TabIndex = 31;
            // 
            // groupbox4
            // 
            groupbox4.Location = new Point(909, 77);
            groupbox4.Name = "groupbox4";
            groupbox4.Size = new Size(115, 25);
            groupbox4.TabIndex = 32;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(117, 12);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(161, 124);
            checkedListBox1.TabIndex = 33;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(609, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(115, 25);
            textBox1.TabIndex = 34;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(514, 17);
            label13.Name = "label13";
            label13.Size = new Size(313, 21);
            label13.TabIndex = 35;
            label13.Text = "Number of Clinical Instructor Rotations:";
            label13.Click += label13_Click;
            // 
            // btnClinicalinstructor
            // 
            btnClinicalinstructor.BackColor = Color.FromArgb(255, 128, 0);
            btnClinicalinstructor.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClinicalinstructor.ForeColor = Color.White;
            btnClinicalinstructor.Location = new Point(870, 37);
            btnClinicalinstructor.Name = "btnClinicalinstructor";
            btnClinicalinstructor.Size = new Size(185, 46);
            btnClinicalinstructor.TabIndex = 36;
            btnClinicalinstructor.Text = "Deploy CI Rotation";
            btnClinicalinstructor.UseVisualStyleBackColor = false;
            btnClinicalinstructor.Click += button7_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOrange;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(219, 749);
            panel1.TabIndex = 39;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(45, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 118);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Wheat;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(label8);
            panel3.Controls.Add(lstTimeShifts);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(dtpStartDate);
            panel3.Controls.Add(dtpEndDate);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(txtNumberOfWeeks);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(lstYearLevels);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(240, 23);
            panel3.Name = "panel3";
            panel3.Size = new Size(1086, 153);
            panel3.TabIndex = 40;
            panel3.Paint += panel3_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Wheat;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(button6);
            panel2.Controls.Add(RotationTextBox);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(lstDepartments);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(button5);
            panel2.Location = new Point(240, 197);
            panel2.Name = "panel2";
            panel2.Size = new Size(1086, 166);
            panel2.TabIndex = 41;
            panel2.Paint += panel2_Paint;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Wheat;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(label13);
            panel4.Controls.Add(lstClinicalInstructors);
            panel4.Controls.Add(btnClinicalinstructor);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(textBox1);
            panel4.Location = new Point(240, 384);
            panel4.Name = "panel4";
            panel4.Size = new Size(1086, 127);
            panel4.TabIndex = 42;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Wheat;
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(checkedListBox1);
            panel5.Controls.Add(groupbox3);
            panel5.Controls.Add(label11);
            panel5.Controls.Add(groupbox4);
            panel5.Controls.Add(groupbox2);
            panel5.Controls.Add(label12);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(240, 529);
            panel5.Name = "panel5";
            panel5.Size = new Size(1086, 169);
            panel5.TabIndex = 43;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Goldenrod;
            ClientSize = new Size(1370, 749);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private ListBox lstClinicalInstructors;
        private ListBox lstYearLevels;
        private ListBox lstDepartments;
        private TextBox txtNumberOfWeeks;
        private Label label8;
        private ListBox lstTimeShifts;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button2;
        private TextBox RotationTextBox;
        private Label label9;
        private Button button5;
        private Button button6;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox groupbox2;
        private TextBox groupbox3;
        private TextBox groupbox4;
        private CheckedListBox checkedListBox1;
        private TextBox textBox1;
        private Label label13;
        private Button btnClinicalinstructor;
        private Panel panel1;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel4;
        private Panel panel5;
    }
}