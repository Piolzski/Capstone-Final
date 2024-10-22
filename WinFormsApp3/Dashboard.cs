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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

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
        }
    }
}
