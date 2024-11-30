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
using System.Data.SQLite;

namespace WinFormsApp3
{
    public partial class RotationFiller : Form
    {
        public RotationFiller()
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
            string connectionString = @"Data Source=clinicalrotationplanner.db;Version=3;";

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT InstructorName FROM clinicalinstructors";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
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
            string connectionString = @"Data Source=clinicalrotationplanner.db;Version=3;";

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT YearLevel FROM yearlevels";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
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

            string connectionString = @"Data Source=clinicalrotationplanner.db;Version=3;";
            string query = "SELECT AreaName FROM hospitaldepartments"; // Correctly targeting the DepartmentName column

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            lstDepartments.Items.Clear(); // Clear the existing items in the ListBox to avoid duplicates

                            while (reader.Read())
                            {
                                // Fetch the DepartmentName value from the reader
                                string departmentName = reader["AreaName"]?.ToString() ?? string.Empty;

                                if (!string.IsNullOrEmpty(departmentName)) // Only add non-empty department names
                                {
                                    lstDepartments.Items.Add(departmentName);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading Areas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }




        private void LoadGroups()
        {
            string connectionString = @"Data Source=clinicalrotationplanner.db;Version=3;";

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT GroupNumber FROM groups"; // Assuming 'groups' is the table name

                    using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            // Assuming groupbox2, groupbox3, and groupbox4 are textboxes
                            groupbox2.Clear();
                            groupbox3.Clear();
                            groupbox4.Clear();

                            int groupCount = 0;
                            while (reader.Read())
                            {
                                string groupNumber = reader["GroupNumber"]?.ToString() ?? string.Empty;

                                if (!string.IsNullOrEmpty(groupNumber))
                                {
                                    // Distribute group numbers across textboxes
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
            string connectionString = @"Data Source=clinicalrotationplanner.db;Version=3;";

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT TimeShiftName FROM timeshifts"; // Assuming 'timeshifts' is the table name

                    using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            lstTimeShifts.Items.Clear(); // Clear existing items in the ListBox to avoid duplicates

                            while (reader.Read())
                            {
                                string timeShiftName = reader["TimeShiftName"]?.ToString() ?? string.Empty;

                                if (!string.IsNullOrEmpty(timeShiftName)) // Only add non-empty time shifts
                                {
                                    lstTimeShifts.Items.Add(timeShiftName);
                                }
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

                // Clear inputs
                lstTimeShifts.ClearSelected(); // Clears the selection in the list box
                lstYearLevels.ClearSelected(); // Clears the selection in the year level list box
                txtNumberOfWeeks.Text = "";    // Clears the text in the textbox
                groupbox2.Text = "";           // Clears the text in the textbox for groupbox2
                groupbox3.Text = "";           // Clears the text in the textbox for groupbox3
                groupbox4.Text = "";           // Clears the text in the textbox for groupbox4


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

            if (!File.Exists(filePath))
            {
                MessageBox.Show("Error: The file 'RotationSchedule.xlsx' does not exist. Deployment cannot proceed.",
                                "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit if the file does not exist
            }

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
                    var (backgroundColor, fontColor) = GetInstructorColorsFromDatabase(selectedCI);

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
                    var selectedAreas = lstDepartments.SelectedItems.Cast<string>().Select(s => s.Trim()).ToArray();
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

                    // Function to find the last week for the specific Clinical Instructor (based on both color coding and white background)
                    int GetLastWeekForCIBasedOnColor(XLColor ciBackgroundColor, XLColor ciFontColor)
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

                                        // Check if the current cell matches the C.I.'s font color and is white background
                                        if ((worksheet.Cell(targetRow, targetColumn).Style.Fill.BackgroundColor == ciBackgroundColor ||
                                             (ciBackgroundColor == XLColor.White && worksheet.Cell(targetRow, targetColumn).Style.Fill.BackgroundColor == XLColor.NoColor)) &&
                                            worksheet.Cell(targetRow, targetColumn).Style.Font.FontColor == ciFontColor)
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

                    // Use the modified function to get the last week for the selected C.I. based on both background and font colors
                    int lastWeekForCI = GetLastWeekForCIBasedOnColor(backgroundColor, fontColor);

                    // Global tracking dictionary to avoid conflicts across C.I.s
                    var globalGroupAssignments = new Dictionary<(int yearLevel, string timeshift, int week), HashSet<int>>();
                    var globalUsedGroups = new HashSet<int>(); // Track globally used groups
                    var yearLevelUsedGroups = new Dictionary<int, HashSet<int>>(); // Track used groups per year level


                    // Retrieve weeks to exclude from the week excluder checklistbox
                    var excludedWeeks = new HashSet<int>(
                        checklistboxExclude.CheckedItems.Cast<string>().Select(int.Parse)
                    );

                    int CalculateTotalAllocatedWeeks(IXLWorksheet worksheet, Dictionary<string, int> baseTimeshiftColumns)
                    {
                        int maxWeek = 0;

                        foreach (var timeshift in baseTimeshiftColumns.Keys)
                        {
                            // Get the base column for this timeshift
                            int timeshiftColumn = baseTimeshiftColumns[timeshift];

                            int lastUsedColumn = 0;

                            // Loop through columns to find the last column with data
                            for (int col = timeshiftColumn; col <= worksheet.ColumnsUsed().Count(); col++)
                            {
                                if (worksheet.Column(col).CellsUsed().Any()) // Check if any cell in this column has data
                                {
                                    lastUsedColumn = col; // Update the last used column
                                }
                            }

                            // Calculate the number of weeks based on the last used column
                            if (lastUsedColumn >= timeshiftColumn)
                            {
                                int weeksForThisTimeshift = (lastUsedColumn - timeshiftColumn) / 3 + 1; // Each week spans 3 columns
                                maxWeek = Math.Max(maxWeek, weeksForThisTimeshift); // Update the maximum week count
                            }
                        }

                        return maxWeek;
                    }

                    // Track the assigned weeks for each combination of year level (as an integer) and timeshift
                    var assignedWeeks = new Dictionary<(int yearLevel, string timeshift), HashSet<int>>();

                    foreach (var yearLevel in selectedYearLevels)
                    {
                        var yearLevelInt = yearLevelStartRows[yearLevel].YearInt; // Get the integer representation of the year level
                        yearLevelUsedGroups[yearLevelInt] = new HashSet<int>(); // Initialize tracking for each year level

                        foreach (var timeshift in selectedTimeshifts)
                        {
                            assignedWeeks[(yearLevelInt, timeshift)] = new HashSet<int>();
                        }
                    }
                    // Function to get the next available group for assignment
                    int GetNextAvailableGroup(List<int> groupsPool, HashSet<int> localUsedGroups, HashSet<int> globalUsedGroups, int yearLevel)
                    {
                        // Prioritize groups not yet used in the current year level
                        var unusedInYearLevel = groupsPool.Where(group => !yearLevelUsedGroups[yearLevel].Contains(group)).ToList();

                        if (unusedInYearLevel.Any())
                        {
                            // Randomly pick from the unused groups within the year level
                            return unusedInYearLevel[new Random().Next(unusedInYearLevel.Count)];
                        }

                        // Prioritize groups not yet assigned globally
                        var unusedGlobally = groupsPool.Where(group => !globalUsedGroups.Contains(group)).ToList();

                        if (unusedGlobally.Any())
                        {
                            // Randomly pick from the unused globally groups
                            return unusedGlobally[new Random().Next(unusedGlobally.Count)];
                        }

                        // If all groups are used globally, prioritize groups not used locally
                        var unusedLocally = groupsPool.Where(group => !localUsedGroups.Contains(group)).ToList();

                        if (unusedLocally.Any())
                        {
                            return unusedLocally[new Random().Next(unusedLocally.Count)];
                        }

                        // If all groups are used both locally and globally, pick any group from the pool
                        return groupsPool[new Random().Next(groupsPool.Count)];
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
                        foreach (var timeshift in selectedTimeshifts)
                        {
                            List<int> groupsForRotationCycle = new List<int>(allGroups);

                            if (groupsForRotationCycle.Count > numberOfRotations)
                            {
                                groupsForRotationCycle = groupsForRotationCycle.OrderBy(g => random.Next()).Take(numberOfRotations).ToList();
                            }

                            int currentRotation = 0;

                            int totalWeeksAllocated = CalculateTotalAllocatedWeeks(worksheet, baseTimeshiftColumns);

                            if (numberOfRotations > totalWeeksAllocated)
                            {
                                MessageBox.Show($"Error: Only {totalWeeksAllocated} weeks are allocated in the schedule. " +
                                                $"You have requested {numberOfRotations} rotations, which exceeds the limit.",
                                                "Week Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            int week = startingWeek;
                            while (currentRotation < numberOfRotations)
                            {
                                if (excludedWeeks.Contains(week) || assignedWeeks.Values.Any(weeks => weeks.Contains(week)))
                                {
                                    week++;
                                    continue;
                                }

                                int weekOffset = (week - 1) * 3;
                                int timeshiftColumn = baseTimeshiftColumns[timeshift];
                                int targetColumn = timeshiftColumn + weekOffset;

                                bool rotationAssigned = false;

                                foreach (var yearLevel in selectedYearLevels)
                                {
                                    var yearLevelInt = yearLevelStartRows[yearLevel].YearInt;

                                    if (assignedWeeks[(yearLevelInt, timeshift)].Contains(week))
                                    {
                                        continue;
                                    }

                                    if (!globalGroupAssignments.ContainsKey((yearLevelInt, timeshift, week)))
                                    {
                                        globalGroupAssignments[(yearLevelInt, timeshift, week)] = new HashSet<int>();
                                    }

                                    int startingRowForYearLevel = yearLevelStartRows[yearLevel].StartRow;

                                    int groupToAssign = GetNextAvailableGroup(groupsForRotationCycle,
                                                                              globalGroupAssignments[(yearLevelInt, timeshift, week)],
                                                                              globalUsedGroups,
                                                                              yearLevelInt);

                                    groupsForRotationCycle.Remove(groupToAssign);

                                    int actualGroupNumber = groupToAssign > 200 ? groupToAssign - 200 :
                                                            groupToAssign > 100 ? groupToAssign - 100 : groupToAssign;

                                    int targetRow = startingRowForYearLevel + actualGroupNumber - 1;

                                    if (string.IsNullOrWhiteSpace(worksheet.Cell(targetRow, targetColumn).GetString()))
                                    {
                                        int randomAreaIndex = random.Next(selectedAreas.Length);
                                        string areaToAssign = selectedAreas[randomAreaIndex];

                                        worksheet.Cell(targetRow, targetColumn).Value = areaToAssign;
                                        worksheet.Cell(targetRow, targetColumn).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                                        worksheet.Cell(targetRow, targetColumn).Style.Fill.SetBackgroundColor(backgroundColor);
                                        worksheet.Cell(targetRow, targetColumn).Style.Font.FontColor = fontColor;

                                        assignedWeeks[(yearLevelInt, timeshift)].Add(week);
                                        globalGroupAssignments[(yearLevelInt, timeshift, week)].Add(groupToAssign);
                                        globalUsedGroups.Add(groupToAssign);
                                        yearLevelUsedGroups[yearLevelInt].Add(groupToAssign); // Track usage in the current year level

                                        currentRotation++;
                                        rotationAssigned = true;
                                        break;
                                    }
                                    else
                                    {
                                        MessageBox.Show($"Conflict detected in year level {yearLevel}, group {actualGroupNumber}, timeshift {timeshift}, week {week + 1}.");
                                    }
                                }

                                if (rotationAssigned)
                                {
                                    week++;
                                }
                            }
                        }
                    }

                    // Ensure 16-hour shift groups follow the same enhancements
                    if (is16HourShiftValid)
                    {
                        int targetColumnFor16hrShift = baseTimeshiftColumns[selectedTimeshifts[0]];

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

                            int groupToAssign = GetNextAvailableGroup(
                                allGroups,
                                globalGroupAssignments[(yearLevelInt, "16hr_shift", weekFor16HourShift)],
                                globalUsedGroups,
                                yearLevelInt
                            );

                            if (globalGroupAssignments[(yearLevelInt, "16hr_shift", weekFor16HourShift)].Contains(groupToAssign))
                            {
                                continue;
                            }

                            allGroups.Remove(groupToAssign);

                            int actualGroupNumber = groupToAssign > 200 ? groupToAssign - 200 :
                                                    groupToAssign > 100 ? groupToAssign - 100 : groupToAssign;

                            int targetRow = startingRowForYearLevel + actualGroupNumber - 1;

                            if (string.IsNullOrWhiteSpace(worksheet.Cell(targetRow, finalColumnFor16hrShift).GetString()))
                            {
                                int randomAreaIndex = random.Next(selectedAreas.Length);
                                string areaToAssign = selectedAreas[randomAreaIndex];

                                worksheet.Cell(targetRow, finalColumnFor16hrShift).Value = areaToAssign;
                                worksheet.Cell(targetRow, finalColumnFor16hrShift).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                                worksheet.Cell(targetRow, finalColumnFor16hrShift).Style.Fill.SetBackgroundColor(backgroundColor);
                                worksheet.Cell(targetRow, finalColumnFor16hrShift).Style.Font.FontColor = fontColor;

                                globalGroupAssignments[(yearLevelInt, "16hr_shift", weekFor16HourShift)].Add(groupToAssign);
                                globalUsedGroups.Add(groupToAssign);
                                yearLevelUsedGroups[yearLevelInt].Add(groupToAssign); // Track usage in the current year level
                            }
                        }
                    }



                    // Hardcoded offsets for each year level
                    int ciOffsetRow = 54; // Clinical Instructor (C.I.) entries always start at row 54

                    // Dictionary to track the current total rotations for each Clinical Instructor
                    Dictionary<string, int> currentRotations = new Dictionary<string, int>();

                    // Add or update each Clinical Instructor's entry
                    foreach (var ci in lstClinicalInstructors.SelectedItems.Cast<string>())
                    {
                        // Retrieve the C.I.'s colors
                        var (ciBackgroundColor, ciFontColor) = GetInstructorColorsFromDatabase(ci);

                        // Retrieve the current rotation count from the Excel sheet if available
                        if (!currentRotations.ContainsKey(ci))
                        {
                            currentRotations[ci] = GetCurrentRotationCountFromSheet(worksheet, ci);
                        }

                        // Include the 16-hour shift rotations in the total count
                        if (is16HourShiftValid)
                        {
                            currentRotations[ci]++; // Increment for the 16-hour shift
                        }

                        // Increment the total rotations for this C.I. based on the new number of rotations
                        currentRotations[ci] += numberOfRotations;

                        // Check if the C.I. already exists in the row
                        int existingColumn = FindColumnForInstructor(worksheet, ciOffsetRow, ci);

                        if (existingColumn > 0)
                        {
                            // Update the existing entry
                            var rotationCell = worksheet.Cell(ciOffsetRow + 1, existingColumn);
                            rotationCell.Value = $"Rotations: {currentRotations[ci]}"; // Update rotation count
                        }
                        else
                        {
                            // Add a new entry for the C.I.
                            int currentColumn = GetNextAvailableColumn(worksheet, ciOffsetRow);

                            // Add the C.I.'s name
                            var nameCell = worksheet.Cell(ciOffsetRow, currentColumn);
                            nameCell.Value = ci;
                            nameCell.Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                            nameCell.Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
                            nameCell.Style.Font.Bold = true;
                            nameCell.Style.Font.FontColor = ciFontColor;
                            nameCell.Style.Fill.SetBackgroundColor(ciBackgroundColor);

                            // Add the rotation count below the name
                            var rotationCell = worksheet.Cell(ciOffsetRow + 1, currentColumn);
                            rotationCell.Value = $"Rotations: {currentRotations[ci]}";
                            rotationCell.Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                            rotationCell.Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
                            rotationCell.Style.Font.Bold = true;
                            rotationCell.Style.Font.FontColor = ciFontColor;
                            rotationCell.Style.Fill.SetBackgroundColor(XLColor.White);
                        }
                    }

                    // Helper method to find the column for an existing C.I.
                    int FindColumnForInstructor(IXLWorksheet worksheet, int row, string ciName)
                    {
                        foreach (var cell in worksheet.Row(row).CellsUsed())
                        {
                            if (cell.GetString().Equals(ciName, StringComparison.OrdinalIgnoreCase))
                            {
                                return cell.Address.ColumnNumber; // Return the column number if found
                            }
                        }
                        return -1; // Return -1 if the C.I. is not found
                    }

                    // Helper method to find the next available column if the C.I. is new
                    int GetNextAvailableColumn(IXLWorksheet worksheet, int row)
                    {
                        int column = 1; // Start from column 1
                        while (!worksheet.Cell(row, column).IsEmpty())
                        {
                            column++;
                        }
                        return column;
                    }

                    // Helper method to get the current rotation count from the sheet
                    int GetCurrentRotationCountFromSheet(IXLWorksheet worksheet, string ciName)
                    {
                        foreach (var cell in worksheet.CellsUsed())
                        {
                            if (cell.GetString().Equals(ciName, StringComparison.OrdinalIgnoreCase))
                            {
                                var rotationCell = worksheet.Cell(cell.Address.RowNumber + 1, cell.Address.ColumnNumber);
                                string rotationText = rotationCell.GetString();

                                if (rotationText.StartsWith("Rotations:", StringComparison.OrdinalIgnoreCase))
                                {
                                    if (int.TryParse(rotationText.Split(':')[1].Trim(), out int rotationCount))
                                    {
                                        return rotationCount;
                                    }
                                }
                            }
                        }
                        return 0; // Default to 0 if no rotation count is found
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
                lstDepartments.ClearSelected();
                lstClinicalInstructors.ClearSelected();

                textBox1.Clear();
                textBox16hrs.Clear();
                groupbox2.Text = string.Empty;
                groupbox3.Text = string.Empty;
                groupbox4.Text = string.Empty;
            }




            // Function to map and validate colors for both background and font
            (XLColor backgroundColor, XLColor fontColor) GetInstructorColorsFromDatabase(string instructorName)
            {
                string backgroundColorName = "";
                string textColorName = "";

                string connectionString = @"Data Source=clinicalrotationplanner.db;Version=3;";
                string query = "SELECT backgroundColor, textColor FROM clinicalinstructors WHERE InstructorName = @InstructorName";

                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@InstructorName", instructorName.Trim());

                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Retrieve color names from the database
                                backgroundColorName = reader["backgroundColor"]?.ToString()?.Trim() ?? "NoColor";
                                textColorName = reader["textColor"]?.ToString()?.Trim() ?? "Black";
                            }
                            else
                            {
                                // Fallback if no colors are found
                                MessageBox.Show($"No colors found for the Clinical Instructor: {instructorName}");
                                return (XLColor.NoColor, XLColor.Black);
                            }
                        }
                    }
                }

                // Map the colors dynamically using the MapColorNameToXLColor function
                XLColor backgroundColor = MapColorNameToXLColor(backgroundColorName);
                XLColor fontColor = MapColorNameToXLColor(textColorName);


                // Validate both colors and handle invalid entries
                if (backgroundColor == XLColor.NoColor)
                {
                    MessageBox.Show($"Invalid background color: {backgroundColorName}. Defaulting to NoColor.");
                }

                if (fontColor == XLColor.NoColor)
                {
                    MessageBox.Show($"Invalid font color: {textColorName}. Defaulting to Black.");
                }

                // Return validated colors
                return (backgroundColor, fontColor);
            }
            XLColor MapColorNameToXLColor(string colorName)
            {
                if (string.IsNullOrWhiteSpace(colorName)) return XLColor.NoColor;

                // Trim spaces and ensure case-insensitive matching
                colorName = colorName.Trim().ToLower();

                // Use a dictionary of predefined colors
                var xlColors = typeof(XLColor)
                    .GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static)
                    .Where(p => p.PropertyType == typeof(XLColor))
                    .ToDictionary(p => p.Name.ToLower(), p => (XLColor)p.GetValue(null)!);

                if (xlColors.TryGetValue(colorName, out var xlColor)) return xlColor;

                // Handle hex and RGB colors
                if (colorName.StartsWith("#"))
                {
                    try { return XLColor.FromHtml(colorName); } catch { return XLColor.NoColor; }
                }

                if (colorName.Contains(","))
                {
                    try
                    {
                        var rgb = colorName.Split(',').Select(int.Parse).ToArray();
                        return XLColor.FromArgb(rgb[0], rgb[1], rgb[2]);
                    }
                    catch { return XLColor.NoColor; }
                }

                // Default to NoColor if unrecognized
                return XLColor.NoColor;
            }






        }


        // empty functions means that it would no be used anymore
        private void button5_Click(object sender, EventArgs e)
        {
            // nothing here it is already changed 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Path for saving the Excel file
            string filePath = Path.Combine(@"C:\excellsheet\", "RotationSchedule.xlsx");

            using (var workbook = File.Exists(filePath) ? new XLWorkbook(filePath) : new XLWorkbook()) // Open existing workbook or create new one
            {
                var worksheet = workbook.Worksheets.FirstOrDefault(ws => ws.Name == "Rotation Schedule")
                                ?? workbook.Worksheets.Add("Rotation Schedule");

                try
                {
                    // Retrieve the selected Clinical Instructor
                    string selectedCI = lstClinicalInstructors.SelectedItem?.ToString()?.Trim() ?? "Unknown";

                    if (string.IsNullOrEmpty(selectedCI))
                    {
                        MessageBox.Show("No Clinical Instructor selected.");
                        return;
                    }

                    // Retrieve the C.I.'s colors from the database (background and text color)
                    var (backgroundColor, fontColor) = GetInstructorColorsFromDatabase(selectedCI);

                    // Define the base columns for each timeshift
                    Dictionary<string, int> baseTimeshiftColumns = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase)
        {
            { "7am to 3pm", 2 },
            { "3pm to 11pm", 3 },
            { "11pm to 7am", 4 }
        };

                    // Retrieve selected year levels, timeshifts, number of weeks, and specific weeks
                    var selectedYearLevels = lstYearLevels.SelectedItems.Cast<string>().Select(s => s.Trim().ToLowerInvariant()).ToArray();
                    var selectedTimeshifts = lstTimeShifts.SelectedItems.Cast<string>().Select(s => s.Trim()).ToArray();

                    // Number of consecutive weeks
                    int numberOfWeeks = int.TryParse(txtNumberOfWeeks.Text, out int parsedWeeks) ? parsedWeeks : 0;

                    // Parse specific weeks from input, e.g., "3,6,9"
                    var specifiedWeeks = textBoxSpecifiedWeeks.Text.Split(',')
                                              .Select(s => int.TryParse(s.Trim(), out int week) ? week : -1)
                                              .Where(w => w > 0)
                                              .ToList();

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

                    // Track cleared rotations for this C.I.
                    int clearedRotations = 0;

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

                            // First, clear areas for the consecutive weeks (from week 1 up to the specified number of weeks)
                            for (int week = 1; week <= numberOfWeeks; week++)
                            {
                                int weekOffset = (week - 1) * 3;
                                int targetColumn = timeshiftColumn + weekOffset;

                                for (int groupNumber = 1; groupNumber <= 10; groupNumber++) // Assuming 10 groups
                                {
                                    int targetRow = startingRowForYearLevel + groupNumber - 1;

                                    var cell = worksheet.Cell(targetRow, targetColumn);

                                    // Clear cell only if it matches the selected C.I.'s background color and font color
                                    if (cell.Style.Fill.BackgroundColor == backgroundColor && cell.Style.Font.FontColor == fontColor)
                                    {
                                        cell.Clear();
                                        clearedRotations++; // Increment cleared rotations count
                                    }
                                }
                            }

                            // Then, clear areas for specific weeks if they aren't already included in the consecutive range
                            foreach (int week in specifiedWeeks.Where(w => w > numberOfWeeks))
                            {
                                int weekOffset = (week - 1) * 3;
                                int targetColumn = timeshiftColumn + weekOffset;

                                for (int groupNumber = 1; groupNumber <= 10; groupNumber++) // Assuming 10 groups
                                {
                                    int targetRow = startingRowForYearLevel + groupNumber - 1;

                                    var cell = worksheet.Cell(targetRow, targetColumn);

                                    // Clear cell only if it matches the selected C.I.'s background color and font color
                                    if (cell.Style.Fill.BackgroundColor == backgroundColor && cell.Style.Font.FontColor == fontColor)
                                    {
                                        cell.Clear();
                                        clearedRotations++; // Increment cleared rotations count
                                    }
                                }
                            }
                        }
                    }

                    // Decrement the C.I.'s rotation count based on cleared areas
                    if (clearedRotations > 0)
                    {
                        int ciOffsetRow = 54; // Starting row for Clinical Instructor entries
                        int ciColumn = FindColumnForInstructor(worksheet, ciOffsetRow, selectedCI);

                        if (ciColumn > 0)
                        {
                            // Retrieve current rotation count
                            var rotationCell = worksheet.Cell(ciOffsetRow + 1, ciColumn);
                            string rotationText = rotationCell.GetString();
                            int currentRotationCount = 0;

                            if (rotationText.StartsWith("Rotations:", StringComparison.OrdinalIgnoreCase))
                            {
                                int.TryParse(rotationText.Split(':')[1].Trim(), out currentRotationCount);
                            }

                            // Update rotation count
                            currentRotationCount = Math.Max(0, currentRotationCount - clearedRotations);
                            if (currentRotationCount == 0)
                            {
                                // Remove the C.I. from the worksheet and shift others left
                                ClearInstructorColumnAndShiftLeft(worksheet, ciOffsetRow, ciColumn);
                            }
                            else
                            {
                                rotationCell.Value = $"Rotations: {currentRotationCount}";
                            }
                        }
                    }

                    int FindColumnForInstructor(IXLWorksheet worksheet, int row, string ciName)
                    {
                        foreach (var cell in worksheet.Row(row).CellsUsed())
                        {
                            if (cell.GetString().Equals(ciName, StringComparison.OrdinalIgnoreCase))
                            {
                                return cell.Address.ColumnNumber; // Return the column number if the C.I. is found
                            }
                        }
                        return -1; // Return -1 if the C.I. is not found
                    }

                    void ClearInstructorColumnAndShiftLeft(IXLWorksheet worksheet, int ciRow, int ciColumn)
                    {
                        int lastColumn = worksheet.Row(ciRow).LastCellUsed().Address.ColumnNumber;

                        // Clear the current column (Clinical Instructor's name and rotations)
                        worksheet.Cell(ciRow, ciColumn).Clear(); // Clear C.I.'s name
                        worksheet.Cell(ciRow + 1, ciColumn).Clear(); // Clear C.I.'s rotation count

                        // Shift the remaining columns to the left
                        for (int col = ciColumn + 1; col <= lastColumn; col++)
                        {
                            foreach (var row in new[] { ciRow, ciRow + 1 }) // Shift both name and rotation cells
                            {
                                worksheet.Cell(row, col - 1).Value = worksheet.Cell(row, col).Value;
                                worksheet.Cell(row, col - 1).Style = worksheet.Cell(row, col).Style;
                                worksheet.Cell(row, col).Clear(); // Clear the source cell after shifting
                            }
                        }
                    }



                    // Save the updated Excel file
                    workbook.SaveAs(filePath);
                    MessageBox.Show("Areas cleared successfully and rotations updated.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }

                // Clear selections and inputs after processing
                ClearSelections();
            }



            // Function to map and validate colors for both background and font
            (XLColor backgroundColor, XLColor fontColor) GetInstructorColorsFromDatabase(string instructorName)
            {
                string backgroundColorName = "";
                string textColorName = "";

                string connectionString = @"Data Source=clinicalrotationplanner.db;Version=3;";
                string query = "SELECT backgroundColor, textColor FROM clinicalinstructors WHERE InstructorName = @InstructorName";

                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@InstructorName", instructorName.Trim());

                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Retrieve color names from the database
                                backgroundColorName = reader["backgroundColor"]?.ToString()?.Trim() ?? "NoColor";
                                textColorName = reader["textColor"]?.ToString()?.Trim() ?? "Black";
                            }
                            else
                            {
                                // Fallback if no colors are found
                                MessageBox.Show($"No colors found for the Clinical Instructor: {instructorName}");
                                return (XLColor.NoColor, XLColor.Black);
                            }
                        }
                    }
                }

                // Map the colors dynamically using the MapColorNameToXLColor function
                XLColor backgroundColor = MapColorNameToXLColor(backgroundColorName);
                XLColor fontColor = MapColorNameToXLColor(textColorName);


                // Validate both colors and handle invalid entries
                if (backgroundColor == XLColor.NoColor)
                {
                    MessageBox.Show($"Invalid background color: {backgroundColorName}. Defaulting to NoColor.");
                }

                if (fontColor == XLColor.NoColor)
                {
                    MessageBox.Show($"Invalid font color: {textColorName}. Defaulting to Black.");
                }

                // Return validated colors
                return (backgroundColor, fontColor);
            }
            XLColor MapColorNameToXLColor(string colorName)
            {
                if (string.IsNullOrWhiteSpace(colorName)) return XLColor.NoColor;

                // Trim spaces and ensure case-insensitive matching
                colorName = colorName.Trim().ToLower();

                // Use a dictionary of predefined colors
                var xlColors = typeof(XLColor)
                    .GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static)
                    .Where(p => p.PropertyType == typeof(XLColor))
                    .ToDictionary(p => p.Name.ToLower(), p => (XLColor)p.GetValue(null)!);

                if (xlColors.TryGetValue(colorName, out var xlColor)) return xlColor;

                // Handle hex and RGB colors
                if (colorName.StartsWith("#"))
                {
                    try { return XLColor.FromHtml(colorName); } catch { return XLColor.NoColor; }
                }

                if (colorName.Contains(","))
                {
                    try
                    {
                        var rgb = colorName.Split(',').Select(int.Parse).ToArray();
                        return XLColor.FromArgb(rgb[0], rgb[1], rgb[2]);
                    }
                    catch { return XLColor.NoColor; }
                }

                // Default to NoColor if unrecognized
                return XLColor.NoColor;
            }





            // Helper function to clear selections and reset inputs
            void ClearSelections()
            {
                lstTimeShifts.ClearSelected();
                lstYearLevels.ClearSelected();
                lstDepartments.ClearSelected();
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
            //this code has been altered to removed sooner if no errors persiss
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // this code will be used for another reference if needed 
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
            // Hide the current form (if needed)
            this.Hide();

            // Instantiate the ExcelPreview form
            ExcelPreview excelPreviewForm = new ExcelPreview();

            // Show the ExcelPreview form
            excelPreviewForm.Show();

            // Optionally, handle the FormClosed event to close the current form when ExcelPreview is closed
            excelPreviewForm.FormClosed += (s, args) => this.Close();

        }
        // to be assessed soon 
        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

     
    }
}
