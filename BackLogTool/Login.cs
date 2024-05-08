using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BackLogTool
{
    public partial class Login : Form
    {
        private MySqlConnection connection;
        private string connectionString = "Data Source=040-DIGI-ALEX-L\\SQLEXPRESS;Initial Catalog=BacklogToolDatabase;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=True";

        public Login()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main mainPage = new main();
            mainPage.Show();
            Visible = false;
            // Code to connect to database without separate OpenConnection method
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelPassword_Click(object sender, EventArgs e)
        {

        }

        private void register_Click(object sender, EventArgs e)
        {
            registerPage registerPage = new registerPage();
            registerPage.Show();
            this.Hide();
        }
    }
}
