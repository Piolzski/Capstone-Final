using ClosedXML.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
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
    public partial class DateRangeForm : Form
    {

        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }

        DateTime today = DateTime.Today;

        public DateRangeForm()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // Assign the selected dates from the DateTimePickers to the properties
            StartDate = dateTimePickerStart.Value.Date;
            EndDate = dateTimePickerEnd.Value.Date;

            // Validate that the start date is before or equal to the end date
            if (StartDate > EndDate)
            {
                MessageBox.Show("Start date must be before or equal to the end date.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate that both start date and end date are not before today
            if (StartDate < today || EndDate < today)
            {
                MessageBox.Show("Start date and end date must not be in the past.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

      
            MessageBox.Show("Rotation data generated successfully!");



            // Connection string and setup
            string connectionString = "Server=127.0.0.1;Port=3306;Database=clinicalrotationplanner;Uid=root;Pwd=;";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Prepare the list of public holidays
                    List<DateTime> publicHolidays = new List<DateTime>()
            {
                new DateTime(2023, 1, 1), // New Year's Day
                new DateTime(2024, 12, 25), // Christmas Day
                new DateTime(2024, 5, 1), // Labor Day
                new DateTime(2024, 6, 12), // Independence Day
                new DateTime(2024, 8, 21), // Ninoy Aquino Day
            };

                    var workbook = new XLWorkbook();
                    var worksheet = workbook.Worksheets.Add("Rotation Plans");

                    // Add headers to row 1
                    worksheet.Cell(1, 1).Value = "Date";
                    worksheet.Cell(1, 2).Value = "Day";
                    worksheet.Cell(1, 3).Value = "Rotation";
                    worksheet.Cell(1, 4).Value = "Instructor";
                    worksheet.Cell(1, 5).Value = "Timeshift";
                    worksheet.Cell(1, 6).Value = "Hospital";
                    worksheet.Cell(1, 7).Value = "Department";
                    worksheet.Cell(1, 8).Value = "Year Level";
                    worksheet.Cell(1, 9).Value = "Group";

                    // Style headers
                    var headerRange = worksheet.Range("A1:I1");
                    headerRange.Style.Font.Bold = true;
                    headerRange.Style.Fill.BackgroundColor = XLColor.LightGray;
                    headerRange.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    headerRange.Style.Border.TopBorder = XLBorderStyleValues.Thin;
                    headerRange.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                    headerRange.Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                    headerRange.Style.Border.RightBorder = XLBorderStyleValues.Thin;

                    // Set column widths
                    worksheet.Column(1).Width = 15; // Date
                    worksheet.Column(2).Width = 10; // Day
                    worksheet.Column(3).Width = 15; // Rotation
                    worksheet.Column(4).Width = 25; // Instructor
                    worksheet.Column(5).Width = 15; // Timeshift
                    worksheet.Column(6).Width = 25; // Hospital
                    worksheet.Column(7).Width = 25; // Department
                    worksheet.Column(8).Width = 20; // Year Level
                    worksheet.Column(9).Width = 10; // Group

                    // Enable text wrapping
                    worksheet.Cells().Style.Alignment.WrapText = true;

                    int row = 2; // Start adding data from row 2

                    // Iterate through each day between startDate and endDate
                    DateTime currentDay = StartDate;

                    while (currentDay <= EndDate)
                    {
                        // Skip weekends and public holidays
                        if (currentDay.DayOfWeek != DayOfWeek.Saturday && currentDay.DayOfWeek != DayOfWeek.Sunday && !publicHolidays.Contains(currentDay))
                        {
                            // Fetch data from database
                            List<(string, string)> instructors = new List<(string, string)>();
                            List<string> hospitals = new List<string>();
                            List<string> departments = new List<string>();
                            List<string> yearLevels = new List<string>();
                            List<int> groups = new List<int>();

                            using (MySqlCommand cmd = new MySqlCommand("SELECT InstructorName, Designation FROM clinicalinstructors", connection))
                            {
                                using (MySqlDataReader reader = cmd.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        instructors.Add((reader.GetString("InstructorName"), reader.GetString("Designation")));
                                    }
                                }
                            }

                            using (MySqlCommand cmd = new MySqlCommand("SELECT HospitalName FROM hospitals", connection))
                            {
                                using (MySqlDataReader reader = cmd.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        hospitals.Add(reader.GetString("HospitalName"));
                                    }
                                }
                            }

                            using (MySqlCommand cmd = new MySqlCommand("SELECT DepartmentName FROM hospitaldepartments", connection))
                            {
                                using (MySqlDataReader reader = cmd.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        departments.Add(reader.GetString("DepartmentName"));
                                    }
                                }
                            }

                            using (MySqlCommand cmd = new MySqlCommand("SELECT YearLevel FROM yearlevels", connection))
                            {
                                using (MySqlDataReader reader = cmd.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        yearLevels.Add(reader.GetString("YearLevel"));
                                    }
                                }
                            }

                            using (MySqlCommand cmd = new MySqlCommand("SELECT GroupNumber FROM groups", connection))
                            {
                                using (MySqlDataReader reader = cmd.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        groups.Add(reader.GetInt32("GroupNumber"));
                                    }
                                }
                            }

                            // Generate rotation data for the current day
                            Random rng = new Random();
                            List<string> timeshifts = new List<string> { "7am to 3pm", "3pm to 11pm", "11pm to 7am" };

                            for (int j = 0; j < 6; j++)  // Assuming 6 rotations per day
                            {
                                var (instructor, _) = instructors[rng.Next(instructors.Count)];
                                string timeshift = timeshifts[j % timeshifts.Count];
                                string hospital = hospitals[rng.Next(hospitals.Count)];
                                string department = departments[rng.Next(departments.Count)];
                                string yearLevel = yearLevels[rng.Next(yearLevels.Count)];
                                int group = groups[rng.Next(groups.Count)];

                                // Add data to Excel
                                worksheet.Cell(row, 1).Value = currentDay.ToString("yyyy-MM-dd");
                                worksheet.Cell(row, 2).Value = currentDay.DayOfWeek.ToString();
                                worksheet.Cell(row, 3).Value = $"Rotation {j + 1}";
                                worksheet.Cell(row, 4).Value = instructor;
                                worksheet.Cell(row, 5).Value = timeshift;
                                worksheet.Cell(row, 6).Value = hospital;
                                worksheet.Cell(row, 7).Value = department;
                                worksheet.Cell(row, 8).Value = yearLevel;
                                worksheet.Cell(row, 9).Value = group;

                                row++;
                            }
                        }
                        currentDay = currentDay.AddDays(1);
                    }


                    worksheet.Columns().AdjustToContents();  // Auto-fit columns
                    workbook.SaveAs(@"D:\RotationPlans.xlsx");  // Save the workbook
            }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }

            // Close the form
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
