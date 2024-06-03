using Atlassian.Jira;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BackLogTool
{
    public partial class registerPage : Form
    {
        private string connectionString = "Server=DESKTOP-GKKFAUK\\SQLEXPRESS;Database=Backlog;Integrated Security=True;";

        public registerPage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void register_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string email = txtEmail.Text;
            string team = txtTeam.Text;
            string password = txtPassword.Text;

            // Check if the email already exists
            if (IsEmailExists(email))
            {
                MessageBox.Show("Email already exists. Please use a different email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the email is valid
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Invalid email format. Please use a valid email address (e.g. <name>@<domain>.com).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the team value is valid
            if (!IsValidTeam(team))
            {
                MessageBox.Show("Invalid team value. Team must be either 'Admin' or 'User'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check password requirement for Admin team
            if (team == "Admin" && password != "Adm!n")
            {
                MessageBox.Show("Invalid password for Admin team.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Insert new user if email is unique, valid, and team value is valid
            string query = "INSERT INTO users (Username, Email, Team, Password) VALUES (@username, @email, @team, @password)";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@team", team);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Problem in register: " + ex.Message);
            }

            Login loginPage = new Login();
            loginPage.Show();
            this.Hide();
        }


        private bool IsEmailExists(string email)
        {
            string query = "SELECT COUNT(*) FROM users WHERE Email = @email";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@email", email);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        private bool IsValidEmail(string email)
        {
            // Regular expression pattern for basic email validation
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            return Regex.IsMatch(email, pattern);
        }

        private bool IsValidTeam(string team)
        {
            // Ensure the team value is either "Admin" or "User"
            return team == "Admin" || team == "User";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
