using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackLogTool
{
    public partial class backlog : Form
    {
        public backlog()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            editEntry editEntryPage = new editEntry();
            editEntryPage.Show();

        }

        private void backlog_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'backlogToolDatabaseDataSet.Backlog' table. You can move, or remove it, as needed.
            this.backlogTableAdapter.Fill(this.backlogToolDatabaseDataSet.Backlog);

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backlogOwnerTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
