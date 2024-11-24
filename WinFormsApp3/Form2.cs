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
            // Ensure that columns are not auto-generated since we will add them manually
            dataGridView1.AutoGenerateColumns = false;

            // Set up columns for DataGridView
            SetUpDataGridViewColumns();

            // Load the clinical instructors into the DataGridView
            LoadInstructors();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell clicks if needed
        }

        private void SetUpDataGridViewColumns()
        {
            // Clear any existing columns
            dataGridView1.Columns.Clear();

            // Define each column with header text and data property
            dataGridView1.Columns.Add("InstructorID", "Instructor ID");
            dataGridView1.Columns.Add("InstructorName", "Instructor Name");
            dataGridView1.Columns.Add("Designation", "Designation");
            dataGridView1.Columns.Add("BackgroundColor", "Background Color");
            dataGridView1.Columns.Add("TextColor", "Text Color");
        }

        private void LoadInstructors()
        {
            string connectionString = "Server=127.0.0.1;Port=3306;Database=clinicalrotationplanner;Uid=root;Pwd=;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT InstructorID, InstructorName, Designation, BackgroundColor, TextColor FROM clinicalinstructors";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        dataGridView1.Rows.Clear(); // Clear any existing rows in the DataGridView
                        while (reader.Read())
                        {
                            // Add a new row to DataGridView with data from the reader
                            dataGridView1.Rows.Add(
                                reader["InstructorID"].ToString(),
                                reader["InstructorName"].ToString(),
                                reader["Designation"].ToString(),
                                reader["BackgroundColor"].ToString(),
                                reader["TextColor"].ToString()
                            );
                        }
                    }
                }
            }
        }
    }
}
