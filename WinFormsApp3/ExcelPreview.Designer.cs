namespace WinFormsApp3
{
    partial class ExcelPreview
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
            dataGridView1 = new DataGridView();
            btnLoadRotationSchedule = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(53, 57);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1542, 878);
            dataGridView1.TabIndex = 0;
            // 
            // btnLoadRotationSchedule
            // 
            btnLoadRotationSchedule.Location = new Point(35, 22);
            btnLoadRotationSchedule.Name = "btnLoadRotationSchedule";
            btnLoadRotationSchedule.Size = new Size(194, 29);
            btnLoadRotationSchedule.TabIndex = 1;
            btnLoadRotationSchedule.Text = "LoadRotationSchedule";
            btnLoadRotationSchedule.UseVisualStyleBackColor = true;
            btnLoadRotationSchedule.Click += btnLoadRotationSchedule_Click;
            // 
            // ExcelPreview
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(btnLoadRotationSchedule);
            Controls.Add(dataGridView1);
            Name = "ExcelPreview";
            Text = "ExcelPreview";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnLoadRotationSchedule;
    }
}