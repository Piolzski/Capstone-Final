using SpreadsheetGear;
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
    public partial class ExcelPreview : Form
    {
        private IRange? usedRange; // Make nullable to handle uninitialized state

        public ExcelPreview()
        {
            InitializeComponent();
            // Set up event handler for virtual mode
            dataGridView1.CellValueNeeded += DataGridView1_CellValueNeeded;
        }

        private void btnLoadRotationSchedule_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Excel Files|*.xlsx;*.xls";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Load the selected Excel file into the DataGridView with formatting
                    LoadExcelWithFormatting(openFileDialog.FileName);
                }
            }
        }

        private void LoadExcelWithFormatting(string filePath)
        {
            // Suspend layout to improve performance during data load
            dataGridView1.SuspendLayout();

            // Set DataGridView properties to enhance performance
            dataGridView1.VirtualMode = true; // Enable virtual mode for large data sets
            dataGridView1.DoubleBuffered(true); // Enable double buffering (extension method)
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToResizeColumns = false;

            // Clear existing data
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            // Load the workbook using SpreadsheetGear
            IWorkbook workbook = Factory.GetWorkbook(filePath);
            IWorksheet worksheet = workbook.Worksheets[0];
            usedRange = worksheet.UsedRange; // Store for use in virtual mode

            // Set up columns based on the Excel columns
            for (int col = 0; col < usedRange.ColumnCount; col++)
            {
                var headerText = usedRange.Cells[0, col].Text ?? $"Column{col}";
                dataGridView1.Columns.Add($"Column{col}", headerText);

                // Set a default column width based on Excel column width, with a multiplier for approximation
                double excelColumnWidth = usedRange.Cells[0, col].ColumnWidth;
                int gridColumnWidth = Convert.ToInt32(excelColumnWidth * 7); // Adjust multiplier as needed
                dataGridView1.Columns[col].Width = Math.Max(50, Math.Min(300, gridColumnWidth));
            }

            // Set row count for virtual mode
            dataGridView1.RowCount = usedRange.RowCount;

            // Resume layout updates
            dataGridView1.ResumeLayout();
        }

        private void DataGridView1_CellValueNeeded(object? sender, DataGridViewCellValueEventArgs e) // Nullable sender
        {
            {
                if (usedRange == null) return; // Ensure usedRange is populated

                var cell = usedRange.Cells[e.RowIndex, e.ColumnIndex];
                e.Value = cell.Value;

                // Get the background color from the cell
                System.Drawing.Color cellColor;

                // If the color is black or undefined, set it to white
                var spreadsheetGearColor = cell.Interior.Color;
                if (spreadsheetGearColor.ToArgb() == 0 || spreadsheetGearColor.ToArgb() == System.Drawing.Color.Black.ToArgb())
                {
                    cellColor = System.Drawing.Color.White; // Default to white if color is undefined or black
                }
                else
                {
                    cellColor = System.Drawing.Color.FromArgb(spreadsheetGearColor.ToArgb());
                }

                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = cellColor;

                // Apply bold font style if applicable
                if (cell.Font.Bold)
                {
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.Font =
                        new Font(dataGridView1.Font, FontStyle.Bold);
                }

                // Apply font color from Excel cell
                System.Drawing.Color fontColor = System.Drawing.Color.FromArgb(cell.Font.Color.ToArgb());
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = fontColor;

                // Handle merged cells by hiding values in subsequent cells to simulate merging
                if (cell.MergeCells && cell.MergeArea.ColumnCount > 1)
                {
                    for (int mergeCol = 1; mergeCol < cell.MergeArea.ColumnCount; mergeCol++)
                    {
                        if (e.ColumnIndex + mergeCol < dataGridView1.ColumnCount)
                        {
                            dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex + mergeCol].Value = null;
                        }
                    }
                }
            }
        }
    }

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


