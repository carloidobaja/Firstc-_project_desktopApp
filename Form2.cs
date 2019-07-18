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
    public partial class Regi : Form

    {
        public static string program_location = System.IO.Directory.GetCurrentDirectory();
        static string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={program_location}\testlogin.mdf;Integrated Security=True;Connect Timeout=30";

       
        public Regi()
        {
            InitializeComponent();
        }

        private void Regi_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
                       
            SqlConnection conm = new SqlConnection($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={DatabaseConnection.program_location}\testlogin.mdf;Integrated Security=True;Connect Timeout=30");
            conm.Open();
            if (lblTest.ForeColor == System.Drawing.Color.Green)
            {
                if (textBox2.Text == textBox3.Text)
                {
                    SqlCommand cmd = new SqlCommand("Insert into [login] (username, password) Values('" + textBox1.Text + "','" + textBox3.Text + "')", conm);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Registered! ");
                    conm.Close();
                }
                else
                {
                    MessageBox.Show("Password Doesn't Match");
                }
            }
            else
            {
                MessageBox.Show("Please Use Another UserName!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 mm = new Form1();
            mm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conm = new SqlConnection($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={DatabaseConnection.program_location}\testlogin.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from  [login] where username  ='" + textBox1.Text + "'", conm);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (int.Parse(dt.Rows[0][0].ToString()) == 0)
            {
                lblTest.Text = textBox1.Text + "   is Available";
                lblTest.ForeColor = System.Drawing.Color.Green;
        
            }
            else
            {
                lblTest.Text = textBox1.Text + "  is not Available";
                lblTest.ForeColor = System.Drawing.Color.Red;
            }
            
               
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conm = new SqlConnection($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={DatabaseConnection.program_location}\testlogin.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from  [login] where username  ='" + textBox1.Text + "'", conm);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (int.Parse(dt.Rows[0][0].ToString()) == 0)
            {
                lblTest.Text = textBox1.Text + "is Available";
                lblTest.ForeColor = System.Drawing.Color.Green;

            }
            else
            {
                lblTest.Text = textBox1.Text + "is not Available";
                lblTest.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
