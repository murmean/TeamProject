using ClosedXML.Excel;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace BackLogTool
{
    public partial class monitoring : Form
    {
        string connectionString = "Server=DESKTOP-GKKFAUK\\SQLEXPRESS;Database=Backlog;Integrated Security=True;";

        public monitoring()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void monitoring_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
            
        }

        private void LoadData()
        {
            // Load data for dataGridView2
            DataTable dataTable2 = new DataTable();
            string query2 = "SELECT Num, Test_Case, TogglesToday FROM monitoring";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    using (SqlCommand command = new SqlCommand(query2, connection))
                    {
                        connection.Open();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable2);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data for dataGridView2: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            dataGridView2.DataSource = dataTable2;
            dataGridView2.ReadOnly = true;

            // Load data for dataGridView3
            DataTable dataTable3 = new DataTable();
            string query3 = "SELECT Num, Test_Case, FailRatio FROM monitoring";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    using (SqlCommand command = new SqlCommand(query3, connection))
                    {
                        connection.Open();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable3);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data for dataGridView3: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            dataGridView3.DataSource = dataTable3;
            dataGridView3.ReadOnly = true;
        }

        private void GenerateExcel()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (var workbook = new XLWorkbook())
                {
                    if (dataGridView2.DataSource != null)
                    {
                        DataTable dataTable2 = (DataTable)dataGridView2.DataSource;
                        var worksheet2 = workbook.Worksheets.Add(dataTable2, "Sheet1");

                        // Apply thin border to all cells in the worksheet
                        worksheet2.RangeUsed().Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                        worksheet2.RangeUsed().Style.Border.InsideBorder = XLBorderStyleValues.Thin;
                    }

                    if (dataGridView3.DataSource != null)
                    {
                        DataTable dataTable3 = (DataTable)dataGridView3.DataSource;
                        var worksheet3 = workbook.Worksheets.Add(dataTable3, "Sheet2");

                        // Apply thin border to all cells in the worksheet
                        worksheet3.RangeUsed().Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                        worksheet3.RangeUsed().Style.Border.InsideBorder = XLBorderStyleValues.Thin;
                    }

                    try
                    {
                        workbook.SaveAs(saveFileDialog.FileName);
                        MessageBox.Show("Excel file generated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error saving Excel file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GenerateExcel();
        }
    }
}
