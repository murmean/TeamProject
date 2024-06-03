using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BackLogTool
{
    public partial class editEntry : Form
    {

        private string connectionString = "Server=DESKTOP-GKKFAUK\\SQLEXPRESS;Database=Backlog;Integrated Security=True;";
        public editEntry()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void editEntry_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void editEntryDoneButton_Click(object sender, EventArgs e)
        {
            string owner = editEntryOwnerTextBox.Text;
            string status = editEntryStatusTextBox.Text;
            string jira = editEntryJiraTextBox.Text;
            string defect = editEntryDefectTextBox.Text;
            string prio = editEntryPrioTextBox.Text;

            try
            {

                if (status != "Ongoing" && status != "Closed" && status != "Unassigned")
                {
                    MessageBox.Show("Status must be 'Ongoing', 'Closed', or 'Unassigned'.", "Invalid Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO backlog (Owner, Status, Jira, Defect, Prio) VALUES (@Owner, @Status, @Jira, @Defect, @Prio)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Explicitly specify parameter types
                        command.Parameters.Add("@Owner", System.Data.SqlDbType.NVarChar).Value = owner;
                        command.Parameters.Add("@Status", System.Data.SqlDbType.NVarChar).Value = status;
                        command.Parameters.Add("@Jira", System.Data.SqlDbType.NVarChar).Value = jira;
                        command.Parameters.Add("@Defect", System.Data.SqlDbType.NVarChar).Value = defect;
                        command.Parameters.Add("@Prio", System.Data.SqlDbType.NVarChar).Value = prio;

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Entity inserted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to insert entity.");
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("Problem in editEntryButton" + ex.Message);
            }
            
        }

      

    }
}
