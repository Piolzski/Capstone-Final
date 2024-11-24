using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.Eventing.Reader;
using ClosedXML.Excel;
using System.Data.SQLite;


namespace WinFormsApp3
{
    public partial class DataGenerator : Form
    {
        public DataGenerator()
        {
            InitializeComponent();

            // Ensure that columns are not auto-generated since we will add them manually
            dataGridView1.AutoGenerateColumns = false;

            // Set up columns for DataGridView
            SetUpDataGridViewColumns();

            // Load the clinical instructors into the DataGridView
            LoadInstructors();
        }





        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Close the current form (if needed)
            this.Close();

            // Instantiate the HOMEPAGE form
            Dashboard dashboardForm = new Dashboard();

            // Show the HOMEPAGE form
            dashboardForm.Show();
        }

        private void Data_Generator_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=clinicalrotationplanner.db;Version=3;"; // SQLite connection string

            if (string.IsNullOrWhiteSpace(textBoxName.Text) &&
                string.IsNullOrWhiteSpace(textBoxSpec.Text) &&
                string.IsNullOrWhiteSpace(textBoxTime.Text) &&
                string.IsNullOrWhiteSpace(textBoxHos.Text) &&
                string.IsNullOrWhiteSpace(TextBoxDept.Text) &&
                string.IsNullOrWhiteSpace(textBox1.Text) &&
                string.IsNullOrWhiteSpace(textBoxLVL.Text) &&
                string.IsNullOrWhiteSpace(textBoxLVLID.Text) &&
                string.IsNullOrWhiteSpace(textBoxColorCode.Text) &&
                string.IsNullOrWhiteSpace(textBoxTextColor.Text) &&
                string.IsNullOrWhiteSpace(textBoxgrp.Text))
            {
                MessageBox.Show("Please fill in at least one field.");
                return;
            }

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    // Insert data for clinical instructors if textbox has value
                    if (!string.IsNullOrWhiteSpace(textBoxName.Text) || !string.IsNullOrWhiteSpace(textBoxSpec.Text))
                    {
                        string instructorInsertQuery = "INSERT INTO clinicalinstructors (InstructorName, Designation, BackgroundColor, TextColor) VALUES (@Name, @Designation, @BackgroundColor, @TextColor)";
                        using (SQLiteCommand instructorCommand = new SQLiteCommand(instructorInsertQuery, connection))
                        {
                            instructorCommand.Parameters.AddWithValue("@Name", textBoxName.Text);
                            instructorCommand.Parameters.AddWithValue("@Designation", textBoxSpec.Text);
                            instructorCommand.Parameters.AddWithValue("@BackgroundColor", textBoxColorCode.Text);
                            instructorCommand.Parameters.AddWithValue("@TextColor", textBoxTextColor.Text);
                            instructorCommand.ExecuteNonQuery();
                        }
                    }

                    // Insert data for time shifts if textbox has value
                    if (!string.IsNullOrWhiteSpace(textBoxTime.Text))
                    {
                        string timeshiftInsertQuery = "INSERT INTO timeshifts (TimeShiftName) VALUES (@Time)";
                        using (SQLiteCommand timeshiftCommand = new SQLiteCommand(timeshiftInsertQuery, connection))
                        {
                            timeshiftCommand.Parameters.AddWithValue("@Time", textBoxTime.Text);
                            timeshiftCommand.ExecuteNonQuery();
                        }
                    }

                    // Insert data for hospitals if textbox has value
                    if (!string.IsNullOrWhiteSpace(textBoxHos.Text))
                    {
                        string hospitalInsertQuery = "INSERT INTO hospitals (HospitalName) VALUES (@Hospital)";
                        using (SQLiteCommand hospitalCommand = new SQLiteCommand(hospitalInsertQuery, connection))
                        {
                            hospitalCommand.Parameters.AddWithValue("@Hospital", textBoxHos.Text);
                            hospitalCommand.ExecuteNonQuery();
                        }
                    }

                    // Insert data for hospital departments if TextBoxDept has value
                    if (!string.IsNullOrWhiteSpace(TextBoxDept.Text))
                    {
                        string departmentInsertQuery = "INSERT INTO hospitaldepartments (DepartmentName) VALUES (@DepartmentName)";
                        using (SQLiteCommand departmentCommand = new SQLiteCommand(departmentInsertQuery, connection))
                        {
                            departmentCommand.Parameters.AddWithValue("@DepartmentName", TextBoxDept.Text);
                            departmentCommand.ExecuteNonQuery();
                        }
                    }

                    // Insert data for year levels if textboxes have value
                    if (!string.IsNullOrWhiteSpace(textBoxLVL.Text) && !string.IsNullOrWhiteSpace(textBoxLVLID.Text))
                    {
                        string yearLevelInsertQuery = "INSERT INTO yearlevels (YearLevelID, YearLevel) VALUES (@YearLevelID, @YearLevel)";
                        using (SQLiteCommand yearLevelCommand = new SQLiteCommand(yearLevelInsertQuery, connection))
                        {
                            yearLevelCommand.Parameters.AddWithValue("@YearLevelID", textBoxLVLID.Text);
                            yearLevelCommand.Parameters.AddWithValue("@YearLevel", textBoxLVL.Text);
                            yearLevelCommand.ExecuteNonQuery();
                        }
                    }

                    // Insert data for group numbers if textbox has value
                    if (!string.IsNullOrWhiteSpace(textBoxgrp.Text))
                    {
                        string groupInsertQuery = "INSERT INTO groups (GroupNumber) VALUES (@GroupNumber)";
                        using (SQLiteCommand groupCommand = new SQLiteCommand(groupInsertQuery, connection))
                        {
                            groupCommand.Parameters.AddWithValue("@GroupNumber", textBoxgrp.Text);
                            groupCommand.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Data inserted successfully!");

                    // Clear text boxes
                    textBoxName.Clear();
                    textBoxSpec.Clear();
                    textBoxTime.Clear();
                    textBoxHos.Clear();
                    TextBoxDept.Clear();
                    textBox1.Clear();
                    textBoxLVL.Clear();
                    textBoxLVLID.Clear();
                    textBoxgrp.Clear();
                    textBoxColorCode.Clear();
                    textBoxTextColor.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to database: " + ex.Message);
            }
        }




        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=clinicalrotationplanner.db;Version=3;";

            // Check if at least one text box has input
            if (string.IsNullOrWhiteSpace(textBoxName.Text) &&
                string.IsNullOrWhiteSpace(textBoxSpec.Text) &&
                string.IsNullOrWhiteSpace(textBoxTime.Text) &&
                string.IsNullOrWhiteSpace(textBoxHos.Text) &&
                string.IsNullOrWhiteSpace(TextBoxDept.Text) &&
                string.IsNullOrWhiteSpace(textBoxID.Text)) // Add check for textBoxID
            {
                MessageBox.Show("Please fill in at least one field.");
                return;
            }

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    bool dataFoundToDelete = false;

                    // Delete data for clinical instructors if textbox has value
                    if (!string.IsNullOrWhiteSpace(textBoxID.Text))
                    {
                        // Check and delete by ID
                        string checkInstructorQuery = "SELECT COUNT(*) FROM clinicalinstructors WHERE InstructorID = @ID";
                        using (SQLiteCommand checkCommand = new SQLiteCommand(checkInstructorQuery, connection))
                        {
                            checkCommand.Parameters.AddWithValue("@ID", textBoxID.Text);
                            int count = Convert.ToInt32(checkCommand.ExecuteScalar());
                            if (count > 0)
                            {
                                string instructorDeleteQuery = "DELETE FROM clinicalinstructors WHERE InstructorID = @ID";
                                using (SQLiteCommand instructorCommand = new SQLiteCommand(instructorDeleteQuery, connection))
                                {
                                    instructorCommand.Parameters.AddWithValue("@ID", textBoxID.Text);
                                    instructorCommand.ExecuteNonQuery();
                                    dataFoundToDelete = true;
                                }
                            }
                        }
                    }
                    else if (!string.IsNullOrWhiteSpace(textBoxName.Text) || !string.IsNullOrWhiteSpace(textBoxSpec.Text))
                    {
                        // Check and delete by Name and/or Specialty
                        string checkInstructorQuery = "SELECT COUNT(*) FROM clinicalinstructors WHERE InstructorName = @Name";
                        using (SQLiteCommand checkCommand = new SQLiteCommand(checkInstructorQuery, connection))
                        {
                            checkCommand.Parameters.AddWithValue("@Name", textBoxName.Text);
                            int count = Convert.ToInt32(checkCommand.ExecuteScalar());
                            if (count > 0)
                            {
                                string instructorDeleteQuery = "DELETE FROM clinicalinstructors WHERE InstructorName = @Name";
                                using (SQLiteCommand instructorCommand = new SQLiteCommand(instructorDeleteQuery, connection))
                                {
                                    instructorCommand.Parameters.AddWithValue("@Name", textBoxName.Text);
                                    instructorCommand.ExecuteNonQuery();
                                    dataFoundToDelete = true;
                                }
                            }
                        }
                    }

                    // Delete data for time shifts if textbox has value
                    if (!string.IsNullOrWhiteSpace(textBoxTime.Text))
                    {
                        string checkTimeshiftQuery = "SELECT COUNT(*) FROM timeshifts WHERE TimeShiftName = @Time";
                        using (SQLiteCommand checkCommand = new SQLiteCommand(checkTimeshiftQuery, connection))
                        {
                            checkCommand.Parameters.AddWithValue("@Time", textBoxTime.Text);
                            int count = Convert.ToInt32(checkCommand.ExecuteScalar());
                            if (count > 0)
                            {
                                string timeshiftDeleteQuery = "DELETE FROM timeshifts WHERE TimeShiftName = @Time";
                                using (SQLiteCommand timeshiftCommand = new SQLiteCommand(timeshiftDeleteQuery, connection))
                                {
                                    timeshiftCommand.Parameters.AddWithValue("@Time", textBoxTime.Text);
                                    timeshiftCommand.ExecuteNonQuery();
                                    dataFoundToDelete = true;
                                }
                            }
                        }
                    }

                    // Delete data for hospitals if textbox has value
                    if (!string.IsNullOrWhiteSpace(textBoxHos.Text))
                    {
                        string checkHospitalQuery = "SELECT COUNT(*) FROM hospitals WHERE HospitalName = @Hospital";
                        using (SQLiteCommand checkCommand = new SQLiteCommand(checkHospitalQuery, connection))
                        {
                            checkCommand.Parameters.AddWithValue("@Hospital", textBoxHos.Text);
                            int count = Convert.ToInt32(checkCommand.ExecuteScalar());
                            if (count > 0)
                            {
                                string hospitalDeleteQuery = "DELETE FROM hospitals WHERE HospitalName = @Hospital";
                                using (SQLiteCommand hospitalCommand = new SQLiteCommand(hospitalDeleteQuery, connection))
                                {
                                    hospitalCommand.Parameters.AddWithValue("@Hospital", textBoxHos.Text);
                                    hospitalCommand.ExecuteNonQuery();
                                    dataFoundToDelete = true;
                                }
                            }
                        }
                    }

                    // Delete data for hospital departments if textbox has value
                    if (!string.IsNullOrWhiteSpace(TextBoxDept.Text))
                    {
                        if (string.IsNullOrWhiteSpace(textBox1.Text))
                        {
                            throw new Exception("Hospital ID is required to delete department.");
                        }

                        string checkDepartmentQuery = "SELECT COUNT(*) FROM hospitaldepartments WHERE DepartmentName = @Department AND HospitalID = @HospitalID";
                        using (SQLiteCommand checkCommand = new SQLiteCommand(checkDepartmentQuery, connection))
                        {
                            checkCommand.Parameters.AddWithValue("@Department", TextBoxDept.Text);
                            checkCommand.Parameters.AddWithValue("@HospitalID", textBox1.Text);
                            int count = Convert.ToInt32(checkCommand.ExecuteScalar());
                            if (count > 0)
                            {
                                string departmentDeleteQuery = "DELETE FROM hospitaldepartments WHERE DepartmentName = @Department AND HospitalID = @HospitalID";
                                using (SQLiteCommand departmentCommand = new SQLiteCommand(departmentDeleteQuery, connection))
                                {
                                    departmentCommand.Parameters.AddWithValue("@Department", TextBoxDept.Text);
                                    departmentCommand.Parameters.AddWithValue("@HospitalID", textBox1.Text);
                                    departmentCommand.ExecuteNonQuery();
                                    dataFoundToDelete = true;
                                }
                            }
                        }
                    }

                    if (!dataFoundToDelete)
                    {
                        MessageBox.Show("No matching records found to delete.");
                    }
                    else
                    {
                        MessageBox.Show("Data deleted successfully!");
                    }

                    // Clear text boxes
                    textBoxName.Clear();
                    textBoxSpec.Clear();
                    textBoxTime.Clear();
                    textBoxHos.Clear();
                    TextBoxDept.Clear();
                    textBoxID.Clear();
                    textBox1.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to database: " + ex.ToString());
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=clinicalrotationplanner.db;Version=3;";

            // Check if at least one text box has input
            if (string.IsNullOrWhiteSpace(textBoxName.Text) &&
                string.IsNullOrWhiteSpace(textBoxSpec.Text) &&
                string.IsNullOrWhiteSpace(textBoxTime.Text) &&
                string.IsNullOrWhiteSpace(textBoxHos.Text) &&
                string.IsNullOrWhiteSpace(TextBoxDept.Text))
            {
                MessageBox.Show("Please fill in at least one field.");
                return;
            }

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    // Update data for clinical instructors if textbox has value
                    if (!string.IsNullOrWhiteSpace(textBoxName.Text) && !string.IsNullOrWhiteSpace(textBoxID.Text))
                    {
                        // Base query for updating instructor name
                        string instructorUpdateQuery = "UPDATE clinicalinstructors SET InstructorName = @Name";

                        // If Designation is provided, include it in the query
                        if (!string.IsNullOrWhiteSpace(textBoxSpec.Text))
                        {
                            instructorUpdateQuery += ", Designation = @Designation";
                        }

                        // If BackgroundColor is provided, include it in the query
                        if (!string.IsNullOrWhiteSpace(textBoxColorCode.Text))
                        {
                            instructorUpdateQuery += ", BackgroundColor = @BackgroundColor";
                        }

                        // If TextColor is provided, include it in the query
                        if (!string.IsNullOrWhiteSpace(textBoxTextColor.Text))
                        {
                            instructorUpdateQuery += ", TextColor = @TextColor";
                        }

                        instructorUpdateQuery += " WHERE InstructorID = @ID";

                        using (SQLiteCommand instructorCommand = new SQLiteCommand(instructorUpdateQuery, connection))
                        {
                            instructorCommand.Parameters.AddWithValue("@ID", textBoxID.Text); // Assuming textBoxID contains the instructor's ID
                            instructorCommand.Parameters.AddWithValue("@Name", textBoxName.Text);

                            // Only add Designation if it's not empty
                            if (!string.IsNullOrWhiteSpace(textBoxSpec.Text))
                            {
                                instructorCommand.Parameters.AddWithValue("@Designation", textBoxSpec.Text);
                            }

                            // Only add BackgroundColor if it's not empty
                            if (!string.IsNullOrWhiteSpace(textBoxColorCode.Text))
                            {
                                instructorCommand.Parameters.AddWithValue("@BackgroundColor", textBoxColorCode.Text);
                            }

                            // Only add TextColor if it's not empty
                            if (!string.IsNullOrWhiteSpace(textBoxTextColor.Text))
                            {
                                instructorCommand.Parameters.AddWithValue("@TextColor", textBoxTextColor.Text);
                            }

                            instructorCommand.ExecuteNonQuery();
                        }
                    }

                    // Update data for time shifts if textbox has value
                    if (!string.IsNullOrWhiteSpace(textBoxTime.Text))
                    {
                        string timeshiftUpdateQuery = "UPDATE timeshifts SET TimeShiftName = @Time WHERE HospitalID = @HospitalID";
                        using (SQLiteCommand timeshiftCommand = new SQLiteCommand(timeshiftUpdateQuery, connection))
                        {
                            timeshiftCommand.Parameters.AddWithValue("@Time", textBoxTime.Text);
                            timeshiftCommand.Parameters.AddWithValue("@HospitalID", textBox1.Text);
                            timeshiftCommand.ExecuteNonQuery();
                        }
                    }

                    // Update data for hospitals if textbox has value
                    if (!string.IsNullOrWhiteSpace(textBoxHos.Text))
                    {
                        string hospitalUpdateQuery = "UPDATE hospitals SET HospitalName = @Hospital WHERE HospitalID = @HospitalID";
                        using (SQLiteCommand hospitalCommand = new SQLiteCommand(hospitalUpdateQuery, connection))
                        {
                            hospitalCommand.Parameters.AddWithValue("@Hospital", textBoxHos.Text);
                            hospitalCommand.Parameters.AddWithValue("@HospitalID", textBox1.Text);
                            hospitalCommand.ExecuteNonQuery();
                        }
                    }

                    // Update data for hospital departments if textbox has value
                    if (!string.IsNullOrWhiteSpace(TextBoxDept.Text))
                    {
                        // Check if Hospital ID is provided
                        if (string.IsNullOrWhiteSpace(textBox1.Text))
                        {
                            throw new Exception("Hospital ID is required to update department.");
                        }

                        string departmentUpdateQuery = "UPDATE hospitaldepartments SET DepartmentName = @Department WHERE HospitalID = @HospitalID";
                        using (SQLiteCommand departmentCommand = new SQLiteCommand(departmentUpdateQuery, connection))
                        {
                            departmentCommand.Parameters.AddWithValue("@Department", TextBoxDept.Text);
                            departmentCommand.Parameters.AddWithValue("@HospitalID", textBox1.Text);
                            departmentCommand.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Data updated successfully!");

                    // Clear text boxes
                    textBoxName.Clear();
                    textBoxSpec.Clear();
                    textBoxTime.Clear();
                    textBoxHos.Clear();
                    TextBoxDept.Clear();
                    textBoxID.Clear();
                    textBox1.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to database: " + ex.Message);
            }


        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxgrp_TextChanged(object sender, EventArgs e)
        {

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
            string connectionString = @"Data Source=clinicalrotationplanner.db;Version=3;"; // SQLite connection string
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT InstructorID, InstructorName, Designation, BackgroundColor, TextColor FROM clinicalinstructors";
                using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}




