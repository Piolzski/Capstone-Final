using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace WinFormsApp3
{
    public partial class ExcelPreview : Form
    {
        public ExcelPreview()
        {
            InitializeComponent();
            this.Load += ExcelPreview_Load;
        }

        private void ExcelPreview_Load(object? sender, EventArgs e)
        {
            string filePath = @"C:\excellsheet\RotationSchedule.xlsx";

            if (File.Exists(filePath))
            {
                LoadExcelWithFormatting(filePath);
            }
            else
            {
                MessageBox.Show("File not found in C:\\excellsheet. Please check the file path and ensure the file is named 'Rotation Schedule.xlsx'.");
            }
        }

        private void LoadExcelWithFormatting(string filePath)
        {
            // Enable double buffering to reduce flickering
            dataGridView1.DoubleBuffered(true);

            dataGridView1.SuspendLayout();
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            using (var workbook = new XLWorkbook(filePath))
            {
                var worksheet = workbook.Worksheet(1);
                var usedRange = worksheet.RangeUsed();

                if (usedRange == null)
                {
                    MessageBox.Show("No data found in the worksheet.");
                    return;
                }

                // Set up columns based on Excel header row
                for (int col = 1; col <= usedRange.ColumnCount(); col++)
                {
                    var headerText = usedRange.Cell(1, col).GetString() ?? $"Column{col}";
                    dataGridView1.Columns.Add($"Column{col}", headerText);
                }

                // Populate rows with data from the worksheet
                for (int row = 2; row <= usedRange.RowCount(); row++) // Start after header
                {
                    var rowData = new DataGridViewRow();

                    for (int col = 1; col <= usedRange.ColumnCount(); col++)
                    {
                        var cell = usedRange.Cell(row, col);
                        var cellValue = cell.GetString();
                        var dataCell = new DataGridViewTextBoxCell { Value = cellValue };

                        // Set background color if present
                        if (!cell.Style.Fill.BackgroundColor.Equals(XLColor.NoColor))
                        {
                            dataCell.Style.BackColor = Color.FromArgb(cell.Style.Fill.BackgroundColor.Color.ToArgb());
                        }

                        // Apply bold font style if applicable
                        if (cell.Style.Font.Bold)
                        {
                            dataCell.Style.Font = new Font(dataGridView1.Font, FontStyle.Bold);
                        }

                        // Apply font color from Excel cell
                        dataCell.Style.ForeColor = Color.FromArgb(cell.Style.Font.FontColor.Color.ToArgb());

                        rowData.Cells.Add(dataCell);
                    }

                    dataGridView1.Rows.Add(rowData);
                }
            }

            dataGridView1.ResumeLayout();
            dataGridView1.AutoResizeColumns();
        }
    }
    // changed from spreadsheetgear to closedXML
    // Extension method to enable double buffering in DataGridView
    public static class ExtensionMethods
    {
        public static void DoubleBuffered(this DataGridView dgv, bool setting)
        {
            typeof(DataGridView).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.SetProperty,
                null, dgv, new object[] { setting });
        }
    }
}
