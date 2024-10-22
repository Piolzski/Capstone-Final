using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Assuming your DataGridView is named dataGridView1
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Name = "Instructor Name";
            dataGridView1.Columns[1].Name = "Designation";

            // Load the clinical instructors into the DataGridView
            LoadInstructors();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadInstructors()
        {
            string connectionString = "Server=127.0.0.1;Port=3306;Database=clinicalrotationplanner;Uid=root;Pwd=;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT InstructorName, Designation FROM clinicalinstructors";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dataGridView1.Rows.Add(reader["InstructorName"].ToString(), reader["Designation"].ToString());
                        }
                    }
                }
            }
        }
    }
}
