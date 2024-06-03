using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Atlassian.Jira;
using System.Collections.Generic;
using System.Linq;

namespace BackLogTool
{
    public partial class backlog : Form
    {
        string connectionString = "Server=DESKTOP-GKKFAUK\\SQLEXPRESS;Database=Backlog;Integrated Security=True;";

        public backlog()
        {
            InitializeComponent();
            LoadTestData();
        }
     

        private void LoadTestData()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM backlog";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            dataGridView1.DataSource = dataTable;
        }

        private void backlogEditEntryButton_Click(object sender, EventArgs e)
        {
            editEntry editEntryPage = new editEntry();
            editEntryPage.ShowDialog();
        }

        private void backlogPrio0CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (backlogPrio0CheckBox.Checked)
            {
                FilterBacklogByPriority(0);
            }
            else
            {
                LoadTestData(); // Reload original data
            }
        }

        private void backlogPrio1CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (backlogPrio1CheckBox.Checked)
            {
                FilterBacklogByPriority(1);
            }
            else
            {
                LoadTestData(); // Reload original data
            }
        }

        private void backlogPrio2CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (backlogPrio2CheckBox.Checked)
            {
                FilterBacklogByPriority(2);
            }
            else
            {
                LoadTestData(); // Reload original data
            }
        }

        private void backlogUnassignedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (backlogUnassignedCheckBox.Checked)
            {
                FilterBacklogByStatus("Unassigned");
            }
            else
            {
                LoadTestData(); // Reload original data
            }
        }

        private void backlogClosedCheckBox_CheckedChanged_1(object sender, EventArgs e)
        {
            if (backlogClosedCheckBox.Checked)
            {
                FilterBacklogByStatus("Closed");
            }
            else
            {
                LoadTestData(); // Reload original data
            }
        }

        private void backlogOngoingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (backlogOngoingCheckBox.Checked)
            {
                FilterBacklogByStatus("Ongoing");
            }
            else
            {
                LoadTestData(); // Reload original data
            }
        }

        private void FilterBacklogByPriority(int priority)
        {
            string query = $"SELECT * FROM backlog WHERE Prio = {priority}";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    DataTable dataTable = new DataTable();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }

                    dataGridView1.DataSource = dataTable;
                }
            }
        }

        private void FilterBacklogByStatus(string status)
        {
            string query = $"SELECT * FROM backlog WHERE Status = '{status}'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    DataTable dataTable = new DataTable();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }

                    dataGridView1.DataSource = dataTable;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadTestData();
        }
    }

    public class JiraIssue
    {
        public string Key { get; set; }
        public Fields Fields { get; set; }
    }

    public class Fields
    {
        public string Summary { get; set; }
    }
}
