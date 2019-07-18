using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace tryA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string Username
        {
            get { return textBox1.Text; }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            SqlConnection conm = new SqlConnection($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={DatabaseConnection.program_location}\testlogin.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from  login where username ='" + textBox1.Text + "' and password='" + textBox2.Text + "'", conm );
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Main mm = new Main(textBox1.Text);
                mm.Show();
            }
            else
                MessageBox.Show("Please enter correct username and password", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);

            
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Regi mm = new Regi();
            mm.Show();
        }

        
    }
}
