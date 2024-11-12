using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using MySql.Data.MySqlClient;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadClinicalInstructors();
            LoadYearLevels();
            LoadDepartments();
            LoadGroups();
            LoadTimeShifts();
            textBox1.Clear();
            textBox16hrs.Clear();
            groupbox2.Text = string.Empty;
            groupbox3.Text = string.Empty;
            groupbox4.Text = string.Empty;


        }

        private void LoadClinicalInstructors()
        {
            string connectionString = "Server=127.0.0.1;Port=3306;Database=clinicalrotationplanner;Uid=root;Pwd=;";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT InstructorName FROM ClinicalInstructors";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string instructorName = reader["InstructorName"]?.ToString() ?? string.Empty;
                                lstClinicalInstructors.Items.Add(instructorName);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading clinical instructors: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LoadYearLevels()
        {
            string connectionString = "Server=127.0.0.1;Port=3306;Database=clinicalrotationplanner;Uid=root;Pwd=;";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT YearLevel FROM YearLevels";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string yearLevel = reader["YearLevel"]?.ToString() ?? string.Empty;
                                lstYearLevels.Items.Add(yearLevel);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading year levels: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LoadDepartments()
        {

            string connectionString = "Server=127.0.0.1;Port=3306;Database=clinicalrotationplanner;Uid=root;Pwd=;";
            string query = "SELECT DepartmentName FROM hospitaldepartments"; // Correctly targeting the DepartmentName column

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            listBox1.Items.Clear(); // Clear the existing items in the listbox to avoid duplicates

                            while (reader.Read())
                            {
                                // Fetch the DepartmentName value from the reader
                                string departmentName = reader["DepartmentName"]?.ToString() ?? string.Empty;

                                if (!string.IsNullOrEmpty(departmentName)) // Only add non-empty department names
                                {
                                    listBox1.Items.Add(departmentName);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading departments: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void LoadGroups()
        {
            string connectionString = "Server=127.0.0.1;Port=3306;Database=clinicalrotationplanner;Uid=root;Pwd=;";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT GroupNumber FROM Groups";  // Assuming 'Groups' is the table name

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Assuming that groupbox2, groupbox3, and groupbox4 are textboxes for displaying the number of groups
                            groupbox2.Clear();
                            groupbox3.Clear();
                            groupbox4.Clear();

                            int groupCount = 0;
                            while (reader.Read())
                            {
                                string groupNumber = reader["GroupNumber"]?.ToString() ?? string.Empty;

                                if (!string.IsNullOrEmpty(groupNumber))
                                {
                                    // Dynamically set the values in the textboxes based on the retrieved group numbers
                                    // This is a placeholder logic, depending on your exact requirements
                                    // Here, we assume you want to distribute groups evenly across textboxes
                                    if (groupCount % 3 == 0)
                                        groupbox2.AppendText(groupNumber + Environment.NewLine);
                                    else if (groupCount % 3 == 1)
                                        groupbox3.AppendText(groupNumber + Environment.NewLine);
                                    else
                                        groupbox4.AppendText(groupNumber + Environment.NewLine);

                                    groupCount++;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading groups: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LoadTimeShifts()
        {
            string connectionString = "Server=127.0.0.1;Port=3306;Database=clinicalrotationplanner;;Uid=root;Pwd=;";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT TimeShiftName FROM TimeShifts";  // Assuming 'TimeShifts' is the table name

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string timeShiftName = reader["TimeShiftName"]?.ToString() ?? string.Empty;
                                lstTimeShifts.Items.Add(timeShiftName);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading time shifts: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Path for saving the Excel file
            string filePath = Path.Combine(@"C:\excellsheet", "RotationSchedule.xlsx");

            using (var workbook = File.Exists(filePath) ? new XLWorkbook(filePath) : new XLWorkbook()) // Open existing workbook or create new one
            {
                // Check if the worksheet exists, otherwise add a new one
                var worksheet = workbook.Worksheets.FirstOrDefault(ws => ws.Name == "Rotation Schedule")
                                ?? workbook.Worksheets.Add("Rotation Schedule");

                try
                {
                    // Retrieve number of rotations from TextBox (optional)
                    int numberOfRotations = 1; // Default to 1 if not provided
                    if (!string.IsNullOrWhiteSpace(txtNumberOfWeeks.Text) && int.TryParse(txtNumberOfWeeks.Text, out int parsedRotations))
                    {
                        numberOfRotations = parsedRotations;
                    }

                    // Retrieve selected shift times from TimeShiftList ListBox (optional)
                    var selectedShifts = lstTimeShifts.SelectedItems.Cast<string>().ToArray();
                    if (selectedShifts.Length == 0)
                    {
                        selectedShifts = new[] { "7am to 3pm", "3pm to 11pm", "11pm to 7am" }; // Add default shifts, including the new 11pm to 7am
                    }

                    // Retrieve year levels from ListBoxYearLevels (optional)
                    var yearLevels = lstYearLevels.SelectedItems.Cast<string>().Select(s => s.Trim()).ToArray();
                    if (yearLevels.Length == 0)
                    {
                        yearLevels = new[] { "2nd Year", "3rd Year", "4th Year" }; // Default year levels
                    }

                    // Retrieve groups from textboxes (use the entered values)
                    int groupCount2ndYear = int.TryParse(groupbox2.Text, out int groupBox2Groups) ? groupBox2Groups : 0;
                    int groupCount3rdYear = int.TryParse(groupbox3.Text, out int groupBox3Groups) ? groupBox3Groups : 0;
                    int groupCount4thYear = int.TryParse(groupbox4.Text, out int groupBox4Groups) ? groupBox4Groups : 0;

                    // Retrieve start and end dates from the DateTimePickers
                    DateTime startDate = dtpStartDate.Value;
                    DateTime endDate = dtpEndDate.Value;
                    if (startDate > endDate)
                    {
                        MessageBox.Show("Start date cannot be after the end date. Using default values.");
                        startDate = DateTime.Now;
                        endDate = startDate.AddDays(7 * numberOfRotations); // Default to one week per rotation
                    }

                    Dictionary<string, int> yearLevelStartRow = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase)
        {
            { "2nd Year", 2 },  // Start at row 2
            { "3rd Year", 18 },  // Skip 13 rows from 2nd Year
            { "4th Year", 34 }   // Skip 13 rows from 3rd Year
        };

                    // Map the group counts to the corresponding year levels
                    Dictionary<string, int> groupCounts = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase)
        {
            { "2nd Year", groupCount2ndYear },
            { "3rd Year", groupCount3rdYear },
            { "4th Year", groupCount4thYear }
        };

                    // Adjust column widths for better readability
                    worksheet.Column(1).Width = 18;  // Year level and labels
                    worksheet.Column(2).Width = 25;  // Rotation info
                    worksheet.Column(3).Width = 25;  // Date range
                    worksheet.Column(4).Width = 25;  // Timeshift
                    worksheet.Column(5).Width = 25;  // Hours

                    // Find the last used column in the second year (to align all year levels)
                    int secondYearRow = yearLevelStartRow["2nd Year"];
                    int lastUsedColumn = worksheet.LastColumnUsed()?.ColumnNumber() ?? 1;

                    // Find the last rotation number from the last populated rotation in the second year
                    int lastRotationNumber = 0;
                    for (int col = 2; col <= lastUsedColumn; col++)
                    {
                        if (int.TryParse(worksheet.Cell(secondYearRow, col).GetString(), out int rotationNumber))
                        {
                            lastRotationNumber = Math.Max(lastRotationNumber, rotationNumber);
                        }
                    }

                    // Increment the rotation number for the new set of shifts
                    lastRotationNumber++;  // Start with the next rotation number after the last one

                    // Start appending new rotations for all year levels from the same column as the second year
                    int currentCol = lastUsedColumn + 1;

                    // Insert year labels and labels for all year levels before adding the rotations
                    foreach (var yearLevel in yearLevels)
                    {
                        int currentRow = yearLevelStartRow[yearLevel];

                        // Insert the year level label (e.g., "2nd Year", "3rd Year")
                        worksheet.Range(currentRow - 1, 1, currentRow - 1, 4).Merge();
                        worksheet.Cell(currentRow - 1, 1).Value = yearLevel;
                        worksheet.Cell(currentRow - 1, 1).Style.Font.SetBold(true).Font.SetFontSize(16);
                        worksheet.Cell(currentRow - 1, 1).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center)
                                                                  .Alignment.SetVertical(XLAlignmentVerticalValues.Center);

                        // Insert labels for Rotation, Date, Timeshift, Hours
                        worksheet.Cell(currentRow, 1).Value = "Rotation";
                        worksheet.Cell(currentRow + 1, 1).Value = "Date";
                        worksheet.Cell(currentRow + 2, 1).Value = "Timeshift";
                        worksheet.Cell(currentRow + 3, 1).Value = "Hours";

                        worksheet.Cell(currentRow, 1).Style.Font.SetBold(true);
                        worksheet.Cell(currentRow + 1, 1).Style.Font.SetBold(true);
                        worksheet.Cell(currentRow + 2, 1).Style.Font.SetBold(true);
                        worksheet.Cell(currentRow + 3, 1).Style.Font.SetBold(true);

                        // Center-align the text in the labels
                        worksheet.Range(currentRow, 1, currentRow + 3, 1).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center)
                                                                                  .Alignment.SetVertical(XLAlignmentVerticalValues.Center);
                    }

                    // Process rotations for all shifts and year levels
                    for (int rotation = 0; rotation < numberOfRotations; rotation++)
                    {
                        // Loop through each shift
                        for (int shiftIndex = 0; shiftIndex < selectedShifts.Length; shiftIndex++)
                        {
                            // Process each year level
                            foreach (var yearLevel in yearLevels)
                            {
                                int currentRow = yearLevelStartRow[yearLevel];
                                int groupCount = groupCounts[yearLevel];  // Get the number of groups for the current year level

                                // Process the second year and determine the rotation number
                                worksheet.Column(currentCol).Width = 20;

                                // Calculate the start date for the current week
                                DateTime currentWeekStartDate = startDate.AddDays(7 * rotation);
                                DateTime currentWeekEndDate = currentWeekStartDate.AddDays(6);

                                // Ensure the week stays within the bounds of the end date
                                if (currentWeekEndDate > endDate)
                                {
                                    currentWeekEndDate = endDate;
                                }

                                // Populate the rotation number, week range, shift times, and hours
                                worksheet.Cell(yearLevelStartRow[yearLevel], currentCol).Value = $"{lastRotationNumber}";
                                worksheet.Cell(yearLevelStartRow[yearLevel] + 1, currentCol).Value = $"{currentWeekStartDate:MMM dd} - {currentWeekEndDate:MMM dd}";
                                worksheet.Cell(yearLevelStartRow[yearLevel] + 2, currentCol).Value = selectedShifts[shiftIndex];
                                worksheet.Cell(yearLevelStartRow[yearLevel] + 3, currentCol).Value = "48 HOURS";

                                // Apply center alignment dynamically
                                worksheet.Cell(currentRow, currentCol).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center)
                                                                   .Alignment.SetVertical(XLAlignmentVerticalValues.Center);

                                worksheet.Cell(currentRow + 1, currentCol).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center)
                                                                   .Alignment.SetVertical(XLAlignmentVerticalValues.Center);

                                worksheet.Cell(currentRow + 2, currentCol).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center)
                                                                   .Alignment.SetVertical(XLAlignmentVerticalValues.Center);

                                worksheet.Cell(currentRow + 3, currentCol).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center)
                                                                   .Alignment.SetVertical(XLAlignmentVerticalValues.Center);

                                // Apply alternating background color for shifts
                                XLColor backgroundColor = (shiftIndex % 2 == 0) ? XLColor.White : XLColor.LightGreen;

                                worksheet.Cell(yearLevelStartRow[yearLevel], currentCol).Style.Fill.SetBackgroundColor(backgroundColor);
                                worksheet.Cell(yearLevelStartRow[yearLevel] + 1, currentCol).Style.Fill.SetBackgroundColor(backgroundColor);
                                worksheet.Cell(yearLevelStartRow[yearLevel] + 2, currentCol).Style.Fill.SetBackgroundColor(backgroundColor);
                                worksheet.Cell(yearLevelStartRow[yearLevel] + 3, currentCol).Style.Fill.SetBackgroundColor(backgroundColor);

                                // Insert the groups below the "Hours" row
                                for (int i = 0; i < groupCount; i++)
                                {
                                    // Calculate the group row, i.e., the row just below "Hours"
                                    int groupRow = yearLevelStartRow[yearLevel] + 4 + i;

                                    // Insert the group in the left-most column (column 1)
                                    worksheet.Cell(groupRow, 1).Value = $"Group {i + 1}";

                                    // Apply center alignment for groups
                                    worksheet.Cell(groupRow, 1).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);

                                    // Set background color to light blue
                                    worksheet.Cell(groupRow, 1).Style.Fill.SetBackgroundColor(XLColor.LightBlue);
                                }
                            }

                            // Move to the next column
                            currentCol++;
                        }

                        // Increment the rotation number after all shifts in this rotation are done
                        lastRotationNumber++;
                    }

                    // Save the Excel file
                    workbook.SaveAs(filePath);
                    MessageBox.Show($"Excel file updated successfully at {filePath}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }


            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Path for the existing Excel file
            string filePath = Path.Combine(@"C:\excellsheet\RotationSchedule.xlsx");

            try
            {
                // Check if the file exists before attempting to delete it
                if (File.Exists(filePath))
                {
                    // Delete the file
                    File.Delete(filePath);
                    MessageBox.Show("The Excel file has been successfully deleted.");
                }
                else
                {
                    MessageBox.Show("The file does not exist.");
                }
            }
            catch (Exception ex)
            {
                // Display any errors that occur during the file deletion process
                MessageBox.Show($"An error occurred while trying to delete the file: {ex.Message}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Path for the existing Excel file
                string filePath = @"C:\excellsheet\RotationSchedule.xlsx";

                // Check if the file exists
                if (File.Exists(filePath))
                {
                    // Open the file using the default application (Excel)
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                    {
                        FileName = filePath,
                        UseShellExecute = true // This ensures it opens with the default program
                    });
                }
                else
                {
                    MessageBox.Show("The Excel file does not exist at the specified location.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while trying to open the file: {ex.Message}");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                // Find all running Excel processes
                foreach (var process in System.Diagnostics.Process.GetProcessesByName("EXCEL"))
                {
                    if (!process.HasExited)
                    {
                        process.Kill(); // Forcefully close the Excel application
                        process.WaitForExit(); // Ensure the process is closed before continuing
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while trying to close Excel: {ex.Message}");
            }
        }



        private void lstYearLevels_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Path for saving the Excel file
            string filePath = Path.Combine(@"C:\excellsheet\", "RotationSchedule.xlsx");

            using (var workbook = File.Exists(filePath) ? new XLWorkbook(filePath) : new XLWorkbook()) // Open existing workbook or create new one
            {
                var worksheet = workbook.Worksheets.FirstOrDefault(ws => ws.Name == "Rotation Schedule")
                                ?? workbook.Worksheets.Add("Rotation Schedule");

                try
                {
                    // Define a structure to track each Clinical Instructor's information
                    var clinicalInstructorsInfo = new Dictionary<string, (XLColor Color, int LastWeek)>();

                    // Retrieve the selected Clinical Instructor
                    string selectedCI = lstClinicalInstructors.SelectedItem?.ToString()?.Trim() ?? "Unknown";

                    if (string.IsNullOrEmpty(selectedCI))
                    {
                        MessageBox.Show("No Clinical Instructor selected.");
                        return;
                    }

                    // Retrieve the C.I.'s colors from the database (background and text color)
                    var (backgroundColor, textColor) = GetInstructorColorsFromDatabase(selectedCI);

                    // Retrieve the number of groups from the textboxes
                    int groupsIn2ndYear = int.TryParse(groupbox2.Text, out int g2) ? g2 : 0;
                    int groupsIn3rdYear = int.TryParse(groupbox3.Text, out int g3) ? g3 : 0;
                    int groupsIn4thYear = int.TryParse(groupbox4.Text, out int g4) ? g4 : 0;

                    // Combine all groups into a single list
                    List<int> allGroups = new List<int>();
                    for (int i = 1; i <= groupsIn2ndYear; i++) allGroups.Add(i); // Add groups from 2nd year
                    for (int i = 1; i <= groupsIn3rdYear; i++) allGroups.Add(i + 100); // Add groups from 3rd year (100 series)
                    for (int i = 1; i <= groupsIn4thYear; i++) allGroups.Add(i + 200); // Add groups from 4th year (200 series)

                    // Retrieve the selected areas from listbox1
                    var selectedAreas = listBox1.SelectedItems.Cast<string>().Select(s => s.Trim()).ToArray();
                    if (selectedAreas.Length == 0)
                    {
                        MessageBox.Show("No areas selected.");
                        return;
                    }

                    // Define starting rows and map year levels to integer values
                    Dictionary<string, (int StartRow, int YearInt)> yearLevelStartRows = new Dictionary<string, (int, int)>(StringComparer.OrdinalIgnoreCase) {
            { "2nd year", (6, 2) },  // Start row and integer mapping for 2nd Year
            { "3rd year", (22, 3) },  // Start row and integer mapping for 3rd Year
            { "4th year", (38, 4) }   // Start row and integer mapping for 4th Year
        };

                    // Define the base columns for each timeshift
                    Dictionary<string, int> baseTimeshiftColumns = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase) {
            { "7am to 3pm", 2 },   // Base column for 7am to 3pm
            { "3pm to 11pm", 3 },  // Base column for 3pm to 11pm
            { "11pm to 7am", 4 }   // Base column for 11pm to 7am
        };

                    // Retrieve the selected year levels
                    var selectedYearLevels = lstYearLevels.SelectedItems.Cast<string>().Select(s => s.Trim().ToLowerInvariant()).ToArray();
                    if (selectedYearLevels.Length == 0)
                    {
                        MessageBox.Show("No year levels selected.");
                        return;
                    }

                    // Retrieve selected timeshifts
                    var selectedTimeshifts = lstTimeShifts.SelectedItems.Cast<string>().Select(s => s.Trim()).ToArray();
                    if (selectedTimeshifts.Length == 0)
                    {
                        MessageBox.Show("No timeshifts selected.");
                        return;
                    }

                    // Validate input for number of rotations if required
                    int numberOfRotations;
                    bool isRotationsValid = int.TryParse(textBox1.Text, out numberOfRotations) && numberOfRotations > 0;

                    // Validate input for 16-hour shift week
                    int weekFor16HourShift;
                    bool is16HourShiftValid = int.TryParse(textBox16hrs.Text, out weekFor16HourShift) && weekFor16HourShift > 0;

                    if (!isRotationsValid && !is16HourShiftValid)
                    {
                        MessageBox.Show("Invalid number of rotations or 16-hour shift week must be specified.");
                        return;
                    }

                    // Initialize random number generator
                    Random random = new Random();

                    // Function to find the last week for the specific Clinical Instructor (based on color coding)
                    int GetLastWeekForCIBasedOnColor(XLColor ciColor)
                    {
                        int lastWeek = 0;

                        // Loop through each timeshift
                        foreach (var timeshift in baseTimeshiftColumns.Keys)
                        {
                            int timeshiftColumn = baseTimeshiftColumns[timeshift];

                            // Loop through each year level to find the last week where a C.I. rotation exists based on color
                            foreach (var yearLevel in yearLevelStartRows.Keys)
                            {
                                int startingRowForYearLevel = yearLevelStartRows[yearLevel].StartRow;

                                // Loop through the weeks to find the last filled week for the C.I.
                                for (int week = 0; week < 50; week++) // Assuming 50 as the maximum number of weeks
                                {
                                    int weekOffset = week * 3; // Each week starts 3 columns later
                                    int targetColumn = timeshiftColumn + weekOffset;

                                    bool isWeekFilledForCI = false;

                                    // Check each group for that week and timeshift
                                    for (int groupNumber = 1; groupNumber <= 10; groupNumber++) // Assuming 10 groups
                                    {
                                        int targetRow = startingRowForYearLevel + groupNumber - 1;

                                        // Check if the current cell matches the C.I.'s color
                                        if (worksheet.Cell(targetRow, targetColumn).Style.Fill.BackgroundColor == ciColor)
                                        {
                                            isWeekFilledForCI = true;
                                            break;
                                        }
                                    }

                                    // If this week was filled for the CI, update the last filled week
                                    if (isWeekFilledForCI)
                                    {
                                        lastWeek = Math.Max(lastWeek, week + 1);
                                    }
                                }
                            }
                        }

                        return lastWeek;
                    }

                    // Global tracking dictionary to avoid conflicts across C.I.s
                    var globalGroupAssignments = new Dictionary<(int yearLevel, string timeshift, int week), HashSet<int>>();

                    // Get the last week for the selected C.I. using its color from the database
                    int lastWeekForCI = GetLastWeekForCIBasedOnColor(backgroundColor);

                    // Retrieve weeks to exclude from the week excluder checklistbox
                    var excludedWeeks = new HashSet<int>(
                        checklistboxExclude.CheckedItems.Cast<string>().Select(int.Parse)
                    );

                    // Track the assigned weeks for each combination of year level (as an integer) and timeshift
                    var assignedWeeks = new Dictionary<(int yearLevel, string timeshift), HashSet<int>>();

                    // Initialize the tracking dictionary for all combinations of year levels and timeshifts
                    foreach (var yearLevel in selectedYearLevels)
                    {
                        var yearLevelInt = yearLevelStartRows[yearLevel].YearInt; // Get the integer representation of the year level

                        foreach (var timeshift in selectedTimeshifts)
                        {
                            assignedWeeks[(yearLevelInt, timeshift)] = new HashSet<int>();
                        }
                    }

                    // Find the first available week that's not excluded
                    int startingWeek = lastWeekForCI + 1;
                    while (excludedWeeks.Contains(startingWeek))
                    {
                        startingWeek++; // Keep incrementing until we find a non-excluded week
                    }

                    // Insert the rotations if a valid number of rotations is provided
                    if (isRotationsValid)
                    {
                        // Original logic to process rotations for Clinical Instructors
                        foreach (var timeshift in selectedTimeshifts)
                        {
                            // Copy the list of all available groups
                            List<int> groupsForRotationCycle = new List<int>(allGroups);

                            // Ensure the number of groups does not exceed the number of rotations
                            if (groupsForRotationCycle.Count > numberOfRotations)
                            {
                                // Shuffle and take only the first 'numberOfRotations' groups
                                groupsForRotationCycle = groupsForRotationCycle.OrderBy(g => random.Next()).Take(numberOfRotations).ToList();
                            }

                            int currentRotation = 0; // Track current rotation count

                            // Start the week count at the determined starting week
                            int week = startingWeek;
                            while (currentRotation < numberOfRotations)
                            {
                                // Skip the weeks that are marked as excluded or if the week has already been assigned for this combination
                                if (excludedWeeks.Contains(week) || assignedWeeks.Values.Any(weeks => weeks.Contains(week)))
                                {
                                    week++;
                                    continue; // Move to the next week if the current one is excluded or already assigned
                                }

                                int weekOffset = (week - 1) * 3;
                                int timeshiftColumn = baseTimeshiftColumns[timeshift];
                                int targetColumn = timeshiftColumn + weekOffset;

                                bool rotationAssigned = false;

                                foreach (var yearLevel in selectedYearLevels)
                                {
                                    var yearLevelInt = yearLevelStartRows[yearLevel].YearInt; // Get the integer representation

                                    // Check if the current week has already been assigned for this year level and timeshift
                                    if (assignedWeeks[(yearLevelInt, timeshift)].Contains(week))
                                    {
                                        continue; // Skip if this combination already has an assigned rotation in this week
                                    }

                                    // Check the global dictionary to avoid conflicts across C.I.s
                                    if (!globalGroupAssignments.ContainsKey((yearLevelInt, timeshift, week)))
                                    {
                                        globalGroupAssignments[(yearLevelInt, timeshift, week)] = new HashSet<int>();
                                    }

                                    int startingRowForYearLevel = yearLevelStartRows[yearLevel].StartRow;

                                    // Randomly select one group to assign for the week
                                    int randomGroupIndex = random.Next(groupsForRotationCycle.Count);
                                    int groupToAssign = groupsForRotationCycle[randomGroupIndex];

                                    // Check if the group has already been assigned globally
                                    if (globalGroupAssignments[(yearLevelInt, timeshift, week)].Contains(groupToAssign))
                                    {
                                        continue; // Skip if the group is already assigned by another C.I. in the same week and timeshift
                                    }

                                    // Assign the group
                                    groupsForRotationCycle.RemoveAt(randomGroupIndex); // Remove selected group from the cycle

                                    int actualGroupNumber;
                                    if (groupToAssign > 200) actualGroupNumber = groupToAssign - 200;
                                    else if (groupToAssign > 100) actualGroupNumber = groupToAssign - 100;
                                    else actualGroupNumber = groupToAssign;

                                    int targetRow = startingRowForYearLevel + actualGroupNumber - 1;

                                    if (string.IsNullOrWhiteSpace(worksheet.Cell(targetRow, targetColumn).GetString()))
                                    {
                                        int randomAreaIndex = random.Next(selectedAreas.Length);
                                        string areaToAssign = selectedAreas[randomAreaIndex];

                                        worksheet.Cell(targetRow, targetColumn).Value = areaToAssign;
                                        worksheet.Cell(targetRow, targetColumn).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                                        worksheet.Cell(targetRow, targetColumn).Style.Fill.SetBackgroundColor(backgroundColor);

                                        // Mark this week as assigned for the current year level and timeshift
                                        assignedWeeks[(yearLevelInt, timeshift)].Add(week);

                                        // Add the group to the global tracking dictionary
                                        globalGroupAssignments[(yearLevelInt, timeshift, week)].Add(groupToAssign);

                                        // Increment rotation count and set the flag to indicate successful assignment
                                        currentRotation++;
                                        rotationAssigned = true;
                                        break; // Move on to the next week once a rotation is assigned for this year level
                                    }
                                    else
                                    {
                                        MessageBox.Show($"Conflict detected in year level {yearLevel}, group {actualGroupNumber}, timeshift {timeshift}, week {week + 1}.");
                                    }
                                }

                                if (rotationAssigned)
                                {
                                    // Move to the next week after a successful assignment to avoid multiple rotations in the same week
                                    week++;
                                }
                            }
                        }
                    }

                    // Process the 16-hour shift independently if a valid week is specified
                    if (is16HourShiftValid)
                    {
                        // Determine the target column based on the timeshift selection
                        int targetColumnFor16hrShift;
                        if (selectedTimeshifts.Contains("3pm to 11pm"))
                        {
                            // Use the "7am to 3pm" column if "3pm to 11pm" is selected
                            targetColumnFor16hrShift = baseTimeshiftColumns["7am to 3pm"];
                        }
                        else
                        {
                            // Otherwise, default to "3pm to 11pm" as the column for the 16-hour shift
                            targetColumnFor16hrShift = baseTimeshiftColumns["3pm to 11pm"];
                        }

                        int weekOffsetFor16hrShift = (weekFor16HourShift - 1) * 3;
                        int finalColumnFor16hrShift = targetColumnFor16hrShift + weekOffsetFor16hrShift;

                        foreach (var yearLevel in selectedYearLevels)
                        {
                            var yearLevelInt = yearLevelStartRows[yearLevel].YearInt;

                            if (!globalGroupAssignments.ContainsKey((yearLevelInt, "16hr_shift", weekFor16HourShift)))
                            {
                                globalGroupAssignments[(yearLevelInt, "16hr_shift", weekFor16HourShift)] = new HashSet<int>();
                            }

                            int startingRowForYearLevel = yearLevelStartRows[yearLevel].StartRow;

                            // Randomly select one group to assign for the 16-hour shift
                            int randomGroupIndex = random.Next(allGroups.Count);
                            int groupToAssign = allGroups[randomGroupIndex];

                            // Check if the group has already been assigned globally for this 16-hour shift
                            if (globalGroupAssignments[(yearLevelInt, "16hr_shift", weekFor16HourShift)].Contains(groupToAssign))
                            {
                                continue; // Skip if the group is already assigned in this 16-hour shift
                            }

                            allGroups.RemoveAt(randomGroupIndex); // Remove selected group from the pool

                            int actualGroupNumber;
                            if (groupToAssign > 200) actualGroupNumber = groupToAssign - 200;
                            else if (groupToAssign > 100) actualGroupNumber = groupToAssign - 100;
                            else actualGroupNumber = groupToAssign;

                            int targetRow = startingRowForYearLevel + actualGroupNumber - 1;

                            if (string.IsNullOrWhiteSpace(worksheet.Cell(targetRow, finalColumnFor16hrShift).GetString()))
                            {
                                int randomAreaIndex = random.Next(selectedAreas.Length);
                                string areaToAssign = selectedAreas[randomAreaIndex];

                                worksheet.Cell(targetRow, finalColumnFor16hrShift).Value = areaToAssign;
                                worksheet.Cell(targetRow, finalColumnFor16hrShift).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                                worksheet.Cell(targetRow, finalColumnFor16hrShift).Style.Fill.SetBackgroundColor(backgroundColor);

                                // Mark this group as assigned globally for the 16-hour shift
                                globalGroupAssignments[(yearLevelInt, "16hr_shift", weekFor16HourShift)].Add(groupToAssign);
                            }
                        }
                    }


                    // Save the workbook
                    workbook.SaveAs(filePath);
                    MessageBox.Show($"Excel file updated successfully at {filePath}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }

                // Clear text and selections after processing
                lstTimeShifts.ClearSelected();
                lstYearLevels.ClearSelected();
                listBox1.ClearSelected();
                lstClinicalInstructors.ClearSelected();

                textBox1.Clear();
                textBox16hrs.Clear();
                groupbox2.Text = string.Empty;
                groupbox3.Text = string.Empty;
                groupbox4.Text = string.Empty;

            }






            // Function to retrieve background and text color from the database
            (XLColor backgroundColor, XLColor textColor) GetInstructorColorsFromDatabase(string instructorName)
            {
                string backgroundColorName = "";
                string textColorName = "";

                // SQL connection and query to retrieve the background and text colors
                string connectionString = "Server=127.0.0.1;Port=3306;Database=clinicalrotationplanner;Uid=root;"; // Replace with your actual connection string
                string query = "SELECT backgroundColor, textColor FROM ClinicalInstructors WHERE InstructorName = @InstructorName";

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@instructorName", instructorName);

                        // Execute the query and retrieve the colors
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                backgroundColorName = reader["backgroundColor"]?.ToString() ?? "NoColor"; // Use default "NoColor"
                                textColorName = reader["textColor"]?.ToString() ?? "Black"; // Default to "Black"
                            }
                            else
                            {
                                MessageBox.Show($"No colors found for the Clinical Instructor: {instructorName}");
                                return (XLColor.NoColor, XLColor.Black); // Default to no color and black text if not found
                            }
                        }
                    }
                }
                // line 948 to line 1056 is to be fixed later 

                // Map the color names to XLColor for ClosedXML
                XLColor backgroundColor = MapColorNameToXLColor(backgroundColorName);
                XLColor textColor = MapColorNameToXLColor(textColorName);

                return (backgroundColor, textColor);
            }

            // Helper function to map color names from the database to XLColor
            XLColor MapColorNameToXLColor(string colorName)
            {
                switch (colorName?.ToLower()) // Ensure colorName is not null
                {
                    case "red":
                        return XLColor.Red;
                    case "blue":
                        return XLColor.Blue;
                    case "green":
                        return XLColor.Green;
                    case "yellow":
                        return XLColor.Yellow;
                    case "pink":
                        return XLColor.Pink;
                    case "brown":
                        return XLColor.Brown;
                    case "gray":
                        return XLColor.Gray;
                    case "orange":
                        return XLColor.Orange;
                    case "violet":
                        return XLColor.Violet;
                    // Add more colors as needed
                    default:
                        return XLColor.NoColor; // Default to no color if not recognized



                }
            }
        }


        // empty functions means that it would no be used anymore
        private void button5_Click(object sender, EventArgs e)
        {
            // nothing here it is already changed 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // nothing to follow it is already changed 
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lstTimeShifts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lstClinicalInstructors_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            // Path for saving the Excel file
            string filePath = Path.Combine(@"C:\excellsheet\", "RotationSchedule.xlsx");

            using (var workbook = File.Exists(filePath) ? new XLWorkbook(filePath) : new XLWorkbook()) // Open existing workbook or create new one
            {
                var worksheet = workbook.Worksheets.FirstOrDefault(ws => ws.Name == "Rotation Schedule")
                                ?? workbook.Worksheets.Add("Rotation Schedule");

                try
                {
                    // Retrieve all C.I. colors from the database once and store in a dictionary
                    var ciColors = GetAllInstructorColorsFromDatabase();

                    // Retrieve the selected C.I.
                    string selectedCI = lstClinicalInstructors.SelectedItem?.ToString()?.Trim() ?? "Unknown";
                    if (string.IsNullOrEmpty(selectedCI) || !ciColors.ContainsKey(selectedCI))
                    {
                        MessageBox.Show("No Clinical Instructor selected or color not found in database.");
                        return;
                    }

                    // Get selected C.I.'s background color
                    var backgroundColor = ciColors[selectedCI].backgroundColor;

                    // Define base columns for each timeshift
                    Dictionary<string, int> baseTimeshiftColumns = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase)
        {
            { "7am to 3pm", 2 },
            { "3pm to 11pm", 3 },
            { "11pm to 7am", 4 }
        };

                    // Retrieve selected year levels, timeshifts, number of weeks, and specific weeks
                    var selectedYearLevels = lstYearLevels.SelectedItems.Cast<string>().Select(s => s.Trim().ToLowerInvariant()).ToArray();
                    var selectedTimeshifts = lstTimeShifts.SelectedItems.Cast<string>().Select(s => s.Trim()).ToArray();
                    int numberOfWeeks = int.TryParse(txtNumberOfWeeks.Text, out int parsedWeeks) ? parsedWeeks : 0;
                    var specifiedWeeks = textBoxSpecifiedWeeks.Text.Split(',')
                                              .Select(s => int.TryParse(s.Trim(), out int week) ? week : -1)
                                              .Where(w => w > 0).ToList();

                    if (selectedYearLevels.Length == 0 || selectedTimeshifts.Length == 0 || (numberOfWeeks == 0 && specifiedWeeks.Count == 0))
                    {
                        MessageBox.Show("Please select year levels, timeshifts, and at least one of number of weeks or specific weeks.");
                        return;
                    }

                    // Define starting rows for year levels
                    Dictionary<string, int> yearLevelStartRows = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase)
        {
            { "2nd year", 6 },
            { "3rd year", 22 },
            { "4th year", 38 }
        };

                    // Clear areas based on selected C.I.'s color coding, consecutive weeks, and specific weeks
                    foreach (var yearLevel in selectedYearLevels)
                    {
                        if (!yearLevelStartRows.ContainsKey(yearLevel))
                        {
                            MessageBox.Show($"Year level '{yearLevel}' is not defined.");
                            continue;
                        }

                        int startingRowForYearLevel = yearLevelStartRows[yearLevel];

                        foreach (var timeshift in selectedTimeshifts)
                        {
                            if (!baseTimeshiftColumns.ContainsKey(timeshift))
                            {
                                MessageBox.Show($"Timeshift '{timeshift}' is not defined.");
                                continue;
                            }

                            int timeshiftColumn = baseTimeshiftColumns[timeshift];

                            // Clear consecutive weeks
                            ClearCellsForWeeks(worksheet, startingRowForYearLevel, timeshiftColumn, numberOfWeeks, backgroundColor);

                            // Clear specific weeks if they aren't already in the consecutive range
                            foreach (int week in specifiedWeeks.Where(w => w > numberOfWeeks))
                            {
                                int weekOffset = (week - 1) * 3;
                                int targetColumn = timeshiftColumn + weekOffset;
                                ClearCellsForSingleWeek(worksheet, startingRowForYearLevel, targetColumn, backgroundColor);
                            }
                        }
                    }

                    // Save the updated Excel file
                    workbook.SaveAs(filePath);
                    MessageBox.Show("Areas cleared successfully based on Clinical Instructor color coding, number of weeks, and specified weeks.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }

                // Clear selections and inputs after processing
                ClearSelections();
            }

            // Batch retrieve all Clinical Instructor colors from the database
            Dictionary<string, (XLColor backgroundColor, XLColor textColor)> GetAllInstructorColorsFromDatabase()
            {
                var colors = new Dictionary<string, (XLColor, XLColor)>(StringComparer.OrdinalIgnoreCase);
                string connectionString = "Server=127.0.0.1;Port=3306;Database=clinicalrotationplanner;Uid=root;";
                string query = "SELECT InstructorName, backgroundColor, textColor FROM ClinicalInstructors";

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string instructorName = reader["InstructorName"].ToString() ?? "Unknown";
                                string backgroundColorName = reader["backgroundColor"]?.ToString() ?? "NoColor";
                                string textColorName = reader["textColor"]?.ToString() ?? "Black";
                                colors[instructorName] = (MapColorNameToXLColor(backgroundColorName), MapColorNameToXLColor(textColorName));
                            }
                        }
                    }
                }
                return colors;
            }

            // Map color names to XLColor for ClosedXML
            XLColor MapColorNameToXLColor(string colorName)
            {
                return colorName.ToLower() switch
                {
                    "red" => XLColor.Red,
                    "blue" => XLColor.Blue,
                    "green" => XLColor.Green,
                    "yellow" => XLColor.Yellow,
                    "pink" => XLColor.Pink,
                    "brown" => XLColor.Brown,
                    "gray" => XLColor.Gray,
                    "orange" => XLColor.Orange,
                    "violet" => XLColor.Violet,
                    _ => XLColor.NoColor
                };
            }

            // Clear cells for consecutive weeks
            void ClearCellsForWeeks(IXLWorksheet worksheet, int startRow, int timeshiftColumn, int numberOfWeeks, XLColor backgroundColor)
            {
                for (int week = 1; week <= numberOfWeeks; week++)
                {
                    int weekOffset = (week - 1) * 3;
                    int targetColumn = timeshiftColumn + weekOffset;

                    for (int groupNumber = 1; groupNumber <= 10; groupNumber++) // Assuming 10 groups
                    {
                        int targetRow = startRow + groupNumber - 1;
                        var cell = worksheet.Cell(targetRow, targetColumn);

                        if (cell.Style.Fill.BackgroundColor == backgroundColor)
                        {
                            cell.Clear();
                        }
                    }
                }
            }

            // Clear cells for a specific week
            void ClearCellsForSingleWeek(IXLWorksheet worksheet, int startRow, int targetColumn, XLColor backgroundColor)
            {
                for (int groupNumber = 1; groupNumber <= 10; groupNumber++)
                {
                    int targetRow = startRow + groupNumber - 1;
                    var cell = worksheet.Cell(targetRow, targetColumn);

                    if (cell.Style.Fill.BackgroundColor == backgroundColor)
                    {
                        cell.Clear();
                    }
                }
            }

            // Helper function to clear selections and reset inputs
            void ClearSelections()
            {
                lstTimeShifts.ClearSelected();
                lstYearLevels.ClearSelected();
                listBox1.ClearSelected();
                lstClinicalInstructors.ClearSelected();

                textBox1.Clear();
                textBox16hrs.Clear();
                textBoxSpecifiedWeeks.Clear();
                txtNumberOfWeeks.Clear();
                groupbox2.Text = string.Empty;
                groupbox3.Text = string.Empty;
                groupbox4.Text = string.Empty;
            }






        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Path for saving the Excel file
            // new button for the area putting
            string filePath = Path.Combine(@"C:\excellsheet", "RotationSchedule.xlsx");

            using (var workbook = File.Exists(filePath) ? new XLWorkbook(filePath) : new XLWorkbook()) // Open existing workbook or create new one
            {
                // Check if the worksheet exists, otherwise add a new one
                var worksheet = workbook.Worksheets.FirstOrDefault(ws => ws.Name == "Rotation Schedule")
                                ?? workbook.Worksheets.Add("Rotation Schedule");

                try
                {
                    // Retrieve selected areas from lstDepartments, trimming spaces
                    var selectedAreas = lstDepartments.SelectedItems.Cast<string>().Select(s => s.Trim()).ToArray();
                    if (selectedAreas.Length == 0)
                    {
                        MessageBox.Show("No areas selected.");
                        return;
                    }

                    // Retrieve selected year levels from lstYearLevels, trimming spaces and converting to lowercase
                    var selectedYearLevels = lstYearLevels.SelectedItems.Cast<string>().Select(s => s.Trim().ToLowerInvariant()).ToArray();
                    if (selectedYearLevels.Length == 0)
                    {
                        MessageBox.Show("No year levels selected.");
                        return;
                    }

                    // Retrieve selected timeshift from lstTimeShifts (assuming only one timeshift selected)
                    var selectedTimeshift = lstTimeShifts.SelectedItem?.ToString()?.Trim().ToLowerInvariant();
                    if (string.IsNullOrEmpty(selectedTimeshift))
                    {
                        MessageBox.Show("No timeshift selected.");
                        return;
                    }

                    // Get the number of weeks from user input (assuming it's input via a TextBox or another control)
                    if (!int.TryParse(txtNumberOfWeeks.Text, out int numberOfWeeks) || numberOfWeeks <= 0)
                    {
                        MessageBox.Show("Invalid number of weeks.");
                        return;
                    }

                    // Define starting rows for year levels
                    Dictionary<string, int> yearLevelStartRows = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase)
        {
            { "2nd year", 6 },  // Start row for 2nd Year
            { "3rd year", 22 },  // Start row for 3rd Year
            { "4th year", 38 }  // Start row for 4th Year
        };

                    // Define the base columns for each timeshift
                    Dictionary<string, int> baseTimeshiftColumns = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase)
        {
            { "7am to 3pm", 2 },   // Base column for 7am to 3pm
            { "3pm to 11pm", 3 },  // Base column for 3pm to 11pm
            { "11pm to 7am", 4 }   // Base column for 11pm to 7am
        };

                    if (!baseTimeshiftColumns.ContainsKey(selectedTimeshift))
                    {
                        MessageBox.Show($"Timeshift '{selectedTimeshift}' is not defined.");
                        return;
                    }

                    // Read the number of groups from the textboxes in groupbox2, groupbox3, and groupbox4
                    int[] numberOfGroups = new int[3]; // Array to store the number of groups for each year level

                    bool validInput = int.TryParse(groupbox2.Text, out numberOfGroups[0]) &&
                                      int.TryParse(groupbox3.Text, out numberOfGroups[1]) &&
                                      int.TryParse(groupbox4.Text, out numberOfGroups[2]);

                    if (!validInput || numberOfGroups.Any(g => g <= 0))
                    {
                        MessageBox.Show("Invalid number of groups.");
                        return;
                    }

                    // Function to read the number of available groups from Excel
                    int GetAvailableGroups(int startRow, IXLWorksheet worksheet)
                    {
                        int availableGroups = 0;
                        int currentRow = startRow;

                        // Check column 1 (or a relevant column) for non-empty cells
                        while (!string.IsNullOrWhiteSpace(worksheet.Cell(currentRow, 1).GetString()))
                        {
                            availableGroups++;
                            currentRow++;
                        }

                        return availableGroups;
                    }

                    // Validate if selected groups exist for the selected year levels
                    for (int i = 0; i < selectedYearLevels.Length; i++)
                    {
                        var yearLevel = selectedYearLevels[i];
                        if (!yearLevelStartRows.ContainsKey(yearLevel))
                        {
                            MessageBox.Show($"Year level '{yearLevel}' is not defined.");
                            return;
                        }

                        int startingRow = yearLevelStartRows[yearLevel];

                        // Get available groups dynamically from Excel
                        int availableGroups = GetAvailableGroups(startingRow, worksheet);

                        if (numberOfGroups[i] > availableGroups)
                        {
                            MessageBox.Show($"The number of groups for '{yearLevel}' exceeds the available groups. Maximum groups: {availableGroups}.");
                            return;
                        }
                    }

                    // Find the next available week for the selected timeshift
                    int week = 0;
                    int timeshiftColumn = baseTimeshiftColumns[selectedTimeshift];

                    // Iterate through the weeks to find the first unfilled week
                    while (true)
                    {
                        int weekOffset = week * 3; // Each week starts 3 columns later (since there are 3 timeshifts per week)
                        int targetColumn = timeshiftColumn + weekOffset;

                        bool isWeekFilled = false;
                        foreach (var yearLevel in selectedYearLevels)
                        {
                            int startingRowForYearLevel = yearLevelStartRows[yearLevel];
                            bool isYearLevelFilled = false;

                            // Check if any group in the current week and timeshift is already filled
                            for (int g = 0; g < numberOfGroups[selectedYearLevels.ToList().IndexOf(yearLevel)]; g++)
                            {
                                int targetRow = startingRowForYearLevel + g;
                                if (!string.IsNullOrWhiteSpace(worksheet.Cell(targetRow, targetColumn).GetString()))
                                {
                                    isYearLevelFilled = true;
                                    break; // If any group is filled, the week is considered filled for this year level
                                }
                            }

                            if (isYearLevelFilled)
                            {
                                isWeekFilled = true;
                                break; // If the week is filled for any year level, move to the next week
                            }
                        }

                        if (!isWeekFilled)
                        {
                            break; // If the week is not filled for any year level, stop searching and start filling this week
                        }

                        week++; // Move to the next week
                    }

                    // Now insert the areas starting from the first available week
                    for (int w = 0; w < numberOfWeeks; w++)
                    {
                        int weekOffset = (week + w) * 3; // Calculate the offset for each week dynamically
                        int targetColumn = timeshiftColumn + weekOffset;

                        // Insert areas for each selected year level and groups
                        for (int i = 0; i < selectedYearLevels.Length; i++)
                        {
                            var yearLevel = selectedYearLevels[i];
                            int startingRowForYearLevel = yearLevelStartRows[yearLevel];
                            int areaIndex = 0; // Track the current area being placed

                            // Insert areas only for the number of groups specified for this year level
                            for (int g = 0; g < numberOfGroups[i]; g++)
                            {
                                if (areaIndex >= selectedAreas.Length) // If we run out of areas, reset the index to start over
                                {
                                    areaIndex = 0;
                                }

                                int targetRow = startingRowForYearLevel + g; // Adjust row based on group number

                                // Place the area in the timeshift column for the current group
                                worksheet.Cell(targetRow, targetColumn).Value = selectedAreas[areaIndex];
                                worksheet.Cell(targetRow, targetColumn).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                                worksheet.Cell(targetRow, targetColumn).Style.Fill.SetBackgroundColor(XLColor.White); // Optional: Adjust color

                                areaIndex++; // Move to the next area
                            }
                        }
                    }

                    // Save the Excel file
                    workbook.SaveAs(filePath);
                    MessageBox.Show($"Excel file updated successfully at {filePath}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");

                    // Clear text and selections after processing
                    lstTimeShifts.ClearSelected();
                    lstYearLevels.ClearSelected();
                    listBox1.ClearSelected();
                    lstClinicalInstructors.ClearSelected();


                    textBox1.Clear();
                    textBox16hrs.Clear();
                    groupbox2.Text = string.Empty;
                    groupbox3.Text = string.Empty;
                    groupbox4.Text = string.Empty;
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Close the current form (if needed)
            this.Close();

            // Instantiate the HOMEPAGE form
            Dashboard dashboardForm = new Dashboard();

            // Show the HOMEPAGE form
            dashboardForm.Show();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Close or hide the current form
            this.Hide();

            // Instantiate the ExcelPreview form
            ExcelPreview ExcelPreviewForm = new ExcelPreview();

            // Show the ExcelPreview form
            ExcelPreviewForm.Show();

        }
    }
}
