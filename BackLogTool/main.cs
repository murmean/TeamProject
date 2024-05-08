using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackLogTool
{
    public partial class main : Form
    {
        public static main instance;
        public main()
        {
            InitializeComponent();
            instance = this;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            monitoring monitPage = new monitoring();
            monitPage.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            backlog backlogPage = new backlog();
            backlogPage.Show();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void mainTeamManagementButton_Click(object sender, EventArgs e)
        {

        }
    }
}
