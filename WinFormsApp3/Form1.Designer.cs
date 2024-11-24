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
            textBox1 = new TextBox();
            label13 = new Label();
            btnClinicalinstructor = new Button();
            panel1 = new Panel();
            button9 = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            label18 = new Label();
            textBoxSpecifiedWeeks = new TextBox();
            panel2 = new Panel();
            panel6 = new Panel();
            button7 = new Button();
            textBox3 = new TextBox();
            label15 = new Label();
            listBox1 = new ListBox();
            label16 = new Label();
            button8 = new Button();
            panel4 = new Panel();
            textBox16hrs = new TextBox();
            label14 = new Label();
            checklistboxExclude = new CheckedListBox();
            panel5 = new Panel();
            label17 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 37);
            label1.Name = "label1";
            label1.Size = new Size(150, 21);
            label1.TabIndex = 0;
            label1.Text = "Clinical Instructor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(628, 8);
            label2.Name = "label2";
            label2.Size = new Size(151, 21);
            label2.TabIndex = 1;
            label2.Text = "Number of Weeks:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
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
            label5.Location = new Point(638, 35);
            label5.Name = "label5";
            label5.Size = new Size(103, 21);
            label5.TabIndex = 4;
            label5.Text = "Add Groups:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
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
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(188, 83);
            label7.Name = "label7";
            label7.Size = new Size(83, 21);
            label7.TabIndex = 6;
            label7.Text = "End Date:";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(294, 33);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(226, 25);
            dtpStartDate.TabIndex = 7;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(294, 83);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(226, 25);
            dtpEndDate.TabIndex = 8;
            // 
            // lstClinicalInstructors
            // 
            lstClinicalInstructors.FormattingEnabled = true;
            lstClinicalInstructors.ItemHeight = 17;
            lstClinicalInstructors.Location = new Point(38, 71);
            lstClinicalInstructors.Name = "lstClinicalInstructors";
            lstClinicalInstructors.SelectionMode = SelectionMode.MultiExtended;
            lstClinicalInstructors.Size = new Size(246, 106);
            lstClinicalInstructors.TabIndex = 9;
            lstClinicalInstructors.SelectedIndexChanged += lstClinicalInstructors_SelectedIndexChanged;
            // 
            // lstYearLevels
            // 
            lstYearLevels.FormattingEnabled = true;
            lstYearLevels.ItemHeight = 17;
            lstYearLevels.Location = new Point(912, 56);
            lstYearLevels.Name = "lstYearLevels";
            lstYearLevels.SelectionMode = SelectionMode.MultiExtended;
            lstYearLevels.Size = new Size(123, 55);
            lstYearLevels.TabIndex = 11;
            lstYearLevels.SelectedIndexChanged += lstYearLevels_SelectedIndexChanged;
            // 
            // lstDepartments
            // 
            lstDepartments.FormattingEnabled = true;
            lstDepartments.ItemHeight = 17;
            lstDepartments.Location = new Point(38, 59);
            lstDepartments.Name = "lstDepartments";
            lstDepartments.SelectionMode = SelectionMode.MultiExtended;
            lstDepartments.Size = new Size(111, 72);
            lstDepartments.TabIndex = 12;
            lstDepartments.SelectedIndexChanged += listBox4_SelectedIndexChanged;
            // 
            // txtNumberOfWeeks
            // 
            txtNumberOfWeeks.Location = new Point(624, 37);
            txtNumberOfWeeks.Name = "txtNumberOfWeeks";
            txtNumberOfWeeks.Size = new Size(190, 25);
            txtNumberOfWeeks.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(47, 24);
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
            lstTimeShifts.Location = new Point(41, 56);
            lstTimeShifts.Name = "lstTimeShifts";
            lstTimeShifts.SelectionMode = SelectionMode.MultiExtended;
            lstTimeShifts.Size = new Size(111, 55);
            lstTimeShifts.TabIndex = 18;
            lstTimeShifts.SelectedIndexChanged += lstTimeShifts_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOrange;
            button1.Font = new Font("Microsoft Sans Serif", 13.8F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(23, 326);
            button1.Name = "button1";
            button1.Size = new Size(167, 50);
            button1.TabIndex = 19;
            button1.Text = "Create Excel ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkOrange;
            button3.Font = new Font("Microsoft Sans Serif", 13.8F);
            button3.ForeColor = Color.White;
            button3.Location = new Point(23, 404);
            button3.Name = "button3";
            button3.Size = new Size(167, 50);
            button3.TabIndex = 20;
            button3.Text = "Open Excel";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkOrange;
            button4.Font = new Font("Microsoft Sans Serif", 13.8F);
            button4.ForeColor = Color.White;
            button4.Location = new Point(23, 479);
            button4.Name = "button4";
            button4.Size = new Size(167, 50);
            button4.TabIndex = 21;
            button4.Text = "Close Excel";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkOrange;
            button2.Font = new Font("Microsoft Sans Serif", 13.8F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(23, 551);
            button2.Name = "button2";
            button2.Size = new Size(167, 50);
            button2.TabIndex = 22;
            button2.Text = "Delete Excel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // RotationTextBox
            // 
            RotationTextBox.Location = new Point(376, 72);
            RotationTextBox.Name = "RotationTextBox";
            RotationTextBox.Size = new Size(145, 25);
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
            button5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(593, 59);
            button5.Name = "button5";
            button5.Size = new Size(220, 54);
            button5.TabIndex = 25;
            button5.Text = "Insert Areas To Excel";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.DarkOrange;
            button6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.White;
            button6.Location = new Point(892, 59);
            button6.Name = "button6";
            button6.Size = new Size(163, 54);
            button6.TabIndex = 26;
            button6.Text = "Clear Areas";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(397, 88);
            label10.Name = "label10";
            label10.Size = new Size(76, 21);
            label10.TabIndex = 27;
            label10.Text = "2nd Year";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(904, 88);
            label11.Name = "label11";
            label11.Size = new Size(72, 21);
            label11.TabIndex = 28;
            label11.Text = "4th Year";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(654, 88);
            label12.Name = "label12";
            label12.Size = new Size(76, 21);
            label12.TabIndex = 29;
            label12.Text = "3rd Year ";
            label12.Click += label12_Click;
            // 
            // groupbox2
            // 
            groupbox2.Location = new Point(382, 122);
            groupbox2.Name = "groupbox2";
            groupbox2.Size = new Size(111, 25);
            groupbox2.TabIndex = 30;
            // 
            // groupbox3
            // 
            groupbox3.Location = new Point(640, 122);
            groupbox3.Name = "groupbox3";
            groupbox3.Size = new Size(111, 25);
            groupbox3.TabIndex = 31;
            // 
            // groupbox4
            // 
            groupbox4.Location = new Point(883, 122);
            groupbox4.Name = "groupbox4";
            groupbox4.Size = new Size(111, 25);
            groupbox4.TabIndex = 32;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(527, 63);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(111, 25);
            textBox1.TabIndex = 34;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(410, 20);
            label13.Name = "label13";
            label13.Size = new Size(313, 21);
            label13.TabIndex = 35;
            label13.Text = "Number of Clinical Instructor Rotations:";
            label13.Click += label13_Click;
            // 
            // btnClinicalinstructor
            // 
            btnClinicalinstructor.BackColor = Color.FromArgb(255, 128, 0);
            btnClinicalinstructor.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClinicalinstructor.ForeColor = Color.White;
            btnClinicalinstructor.Location = new Point(802, 84);
            btnClinicalinstructor.Name = "btnClinicalinstructor";
            btnClinicalinstructor.Size = new Size(180, 46);
            btnClinicalinstructor.TabIndex = 36;
            btnClinicalinstructor.Text = "Deploy CI Rotation";
            btnClinicalinstructor.UseVisualStyleBackColor = false;
            btnClinicalinstructor.Click += button7_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleGoldenrod;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(button9);
            panel1.Controls.Add(pictureBox2);
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
            // button9
            // 
            button9.BackColor = Color.DarkOrange;
            button9.Font = new Font("Microsoft Sans Serif", 13.8F);
            button9.ForeColor = Color.White;
            button9.Location = new Point(23, 629);
            button9.Name = "button9";
            button9.Size = new Size(167, 50);
            button9.TabIndex = 46;
            button9.Text = "Excel Preview";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.OrangeRed;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Location = new Point(-2, -2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(219, 73);
            pictureBox2.TabIndex = 45;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Snow;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(-2, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(219, 200);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Moccasin;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(label18);
            panel3.Controls.Add(textBoxSpecifiedWeeks);
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
            panel3.Location = new Point(345, 31);
            panel3.Name = "panel3";
            panel3.Size = new Size(1082, 153);
            panel3.TabIndex = 40;
            panel3.Paint += panel3_Paint;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Transparent;
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label18.Location = new Point(628, 87);
            label18.Name = "label18";
            label18.Size = new Size(139, 21);
            label18.TabIndex = 20;
            label18.Text = "Specified Weeks:";
            // 
            // textBoxSpecifiedWeeks
            // 
            textBoxSpecifiedWeeks.Location = new Point(623, 113);
            textBoxSpecifiedWeeks.Name = "textBoxSpecifiedWeeks";
            textBoxSpecifiedWeeks.Size = new Size(190, 25);
            textBoxSpecifiedWeeks.TabIndex = 19;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Moccasin;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(RotationTextBox);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(lstDepartments);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(button5);
            panel2.Location = new Point(345, 204);
            panel2.Name = "panel2";
            panel2.Size = new Size(1082, 166);
            panel2.TabIndex = 41;
            panel2.Paint += panel2_Paint;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Moccasin;
            panel6.BorderStyle = BorderStyle.Fixed3D;
            panel6.Controls.Add(button7);
            panel6.Controls.Add(textBox3);
            panel6.Controls.Add(label15);
            panel6.Controls.Add(listBox1);
            panel6.Controls.Add(label16);
            panel6.Controls.Add(button8);
            panel6.Location = new Point(-2, -2);
            panel6.Name = "panel6";
            panel6.Size = new Size(1287, 166);
            panel6.TabIndex = 42;
            // 
            // button7
            // 
            button7.BackColor = Color.DarkOrange;
            button7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.White;
            button7.Location = new Point(802, 59);
            button7.Name = "button7";
            button7.Size = new Size(163, 54);
            button7.TabIndex = 26;
            button7.Text = "Clear Areas";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click_1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(255, 83);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(145, 25);
            textBox3.TabIndex = 24;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(243, 41);
            label15.Name = "label15";
            label15.Size = new Size(151, 21);
            label15.TabIndex = 23;
            label15.Text = "Number of Weeks:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 17;
            listBox1.Location = new Point(38, 59);
            listBox1.Name = "listBox1";
            listBox1.SelectionMode = SelectionMode.MultiExtended;
            listBox1.Size = new Size(111, 72);
            listBox1.TabIndex = 12;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(59, 25);
            label16.Name = "label16";
            label16.Size = new Size(56, 21);
            label16.TabIndex = 3;
            label16.Text = "Areas:";
            // 
            // button8
            // 
            button8.BackColor = Color.DarkOrange;
            button8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.ForeColor = Color.White;
            button8.Location = new Point(498, 55);
            button8.Name = "button8";
            button8.Size = new Size(220, 54);
            button8.TabIndex = 25;
            button8.Text = "Insert Areas To Excel";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Moccasin;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(textBox16hrs);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(lstClinicalInstructors);
            panel4.Controls.Add(btnClinicalinstructor);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(textBox1);
            panel4.Location = new Point(345, 393);
            panel4.Name = "panel4";
            panel4.Size = new Size(1082, 211);
            panel4.TabIndex = 42;
            // 
            // textBox16hrs
            // 
            textBox16hrs.Location = new Point(523, 156);
            textBox16hrs.Name = "textBox16hrs";
            textBox16hrs.Size = new Size(106, 25);
            textBox16hrs.TabIndex = 39;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BorderStyle = BorderStyle.FixedSingle;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(484, 105);
            label14.Name = "label14";
            label14.RightToLeft = RightToLeft.No;
            label14.Size = new Size(176, 23);
            label14.TabIndex = 38;
            label14.Text = "16 hour shift in week:";
            // 
            // checklistboxExclude
            // 
            checklistboxExclude.FormattingEnabled = true;
            checklistboxExclude.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            checklistboxExclude.Location = new Point(38, 51);
            checklistboxExclude.Name = "checklistboxExclude";
            checklistboxExclude.Size = new Size(209, 144);
            checklistboxExclude.TabIndex = 37;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Moccasin;
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(label17);
            panel5.Controls.Add(groupbox3);
            panel5.Controls.Add(label11);
            panel5.Controls.Add(groupbox4);
            panel5.Controls.Add(checklistboxExclude);
            panel5.Controls.Add(groupbox2);
            panel5.Controls.Add(label12);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(345, 619);
            panel5.Name = "panel5";
            panel5.Size = new Size(1082, 225);
            panel5.TabIndex = 43;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(38, 14);
            label17.Name = "label17";
            label17.Size = new Size(123, 21);
            label17.TabIndex = 44;
            label17.Text = "Week Excluder";
            label17.Click += label17_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1199, 749);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
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
        private TextBox textBox1;
        private Label label13;
        private Button btnClinicalinstructor;
        private Panel panel1;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel4;
        private Panel panel5;
        private CheckedListBox checklistboxExclude;
        private Label label14;
        private TextBox textBox16hrs;
        private Panel panel6;
        private Button button7;
        private TextBox textBox3;
        private Label label15;
        private ListBox listBox1;
        private Label label16;
        private Button button8;
        private Label label17;
        private PictureBox pictureBox2;
        private Label label18;
        private TextBox textBoxSpecifiedWeeks;
        private Button button9;
    }
}