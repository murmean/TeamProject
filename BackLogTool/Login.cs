using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BackLogTool
{
    public partial class Login : Form
    {
        private string connectionString = "Server=DESKTOP-GKKFAUK\\SQLEXPRESS;Database=Backlog;Integrated Security=True;";

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Load saved credentials if they exist
            txtUsername.Text = Properties.Settings.Default.Username;
            txtPassword.Text = Properties.Settings.Default.Password;

            if (!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Text))
            {
                checkBox1.Checked = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            string query = "SELECT COUNT(*) FROM users WHERE Username = @username AND Password = @password";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    int result = (int)cmd.ExecuteScalar();

                    if (result > 0)
                    {
                        // Save credentials if "Remember Me" is checked
                        if (checkBox1.Checked)
                        {
                            Properties.Settings.Default.Username = username;
                            Properties.Settings.Default.Password = password;
                            Properties.Settings.Default.Save();
                        }
                        else
                        {
                            Properties.Settings.Default.Username = string.Empty;
                            Properties.Settings.Default.Password = string.Empty;
                            Properties.Settings.Default.Save();
                        }

                        main mainPage = new main();
                        mainPage.Show();
                        Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem connecting to the database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void register_Click(object sender, EventArgs e)
        {
            registerPage registerPage = new registerPage();
            registerPage.Show();
            this.Hide();
        }
    }
}
