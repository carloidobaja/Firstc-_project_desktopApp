using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tryA
{
    public partial class Main : Form
    {
        string s_username;

        public Main(string Username)
        {
            InitializeComponent();

            s_username = Username;


            //to display the value of s_username
            
            lblUsername.Text =  s_username;
        }

     

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transaction mm = new Transaction(s_username);
            mm.Show();
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form4 mm = new Form4();
            mm.Show();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 mm = new Form1();
            mm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
