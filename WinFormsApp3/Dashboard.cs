using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            this.Resize += new EventHandler(Dashboard_Resize);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // Set form properties for better resizing experience
            this.MinimumSize = new Size(800, 600); // Minimum size for the form
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void SetupLayout()
        {
            // Configure the TableLayoutPanel
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel
            {
                Dock = DockStyle.Right,
                ColumnCount = 1,
                RowCount = 3,
                AutoSize = true,
                Padding = new Padding(10)
            };

            // Add controls
            Button btn1 = new Button { Text = "Fill Rotation", AutoSize = true };
            Button btn2 = new Button { Text = "Generate Data", AutoSize = true };
            TextBox txt1 = new TextBox { Width = 200 };

            tableLayoutPanel.Controls.Add(txt1);
            tableLayoutPanel.Controls.Add(btn1);
            tableLayoutPanel.Controls.Add(btn2);

            this.Controls.Add(tableLayoutPanel);
        }
        private void Dashboard_Resize(object? sender, EventArgs e)
        {
            int panelWidth = this.ClientSize.Width / 3; // Adjust the right panel width
            int panelHeight = this.ClientSize.Height - 50; // Adjust height proportionally

            flowLayoutPanel1.Width = panelWidth; // Set width dynamically
            flowLayoutPanel1.Height = panelHeight; // Set height dynamically
            flowLayoutPanel1.Location = new Point(this.ClientSize.Width - panelWidth, 10); // Align to the right

            // Ensure buttons/textboxes inside the panel resize correctly
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                control.Width = panelWidth - 20; // Adjust width for spacing
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Close the current form (if needed)
            this.Hide();

            // Instantiate the Data Generator form
            DataGenerator dataGeneratorForm = new DataGenerator();

            // Show the Data Generator form
            dataGeneratorForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Close the current form
            this.Close();

            // Close the application
            Application.Exit();
        }



        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Close the current form (if needed)
            this.Hide();

            // Instantiate the  form
            Form1 Form1 = new Form1();

            // Show the Rotation Filler form
            Form1.Show();
            //added one C.I color to be assessed tommorrow ang uban 
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
