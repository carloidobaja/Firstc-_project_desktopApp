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

namespace tryA
{
    public partial class Transaction : Form
    {

        string s_username = "";

        public Transaction()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Passes username value
        /// </summary>
        /// <param name="UserName"></param>
        public Transaction(string UserName)
        {
            InitializeComponent();

            s_username = UserName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main mm = new Main(s_username);
            mm.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            DataTable dt;
            string query;


            query = $@"
SELECT username from [login]
where username = ''
";

            dt = DatabaseConnection.Connection1(query);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query;
            DataSet ds;
            DataRow drow;

            String username = s_username;

            DatabaseConnection.Connection2("Insert into [Transaction]  (Username, Description,Category,JAN,FEB,MAR,APR,MAY,JUN,JUL,AUG,SEP,OCT,NOV,DEC) Values('"+username+"','" + txtDes.Text + "','" + cmbCat.Text +
                "','" + txtJan.Text + 
                "','" + txtFeb.Text +
                "','" + txtMar.Text +
                "','" + txtApr.Text +
                "','" + txtMay.Text +
                "','" + txtJun.Text +
                "','" + txtJul.Text +
                "','" + txtAug.Text +
                "','" + txtSep.Text +
                "','" + txtOct.Text +
                "','" + txtNov.Text +
                "','" + txtDec.Text + "')");

            dataGridView1.Rows.Clear();

            query = @"
select 
[Description]
,Category
,JAN
,FEB
,MAR
,APR
,MAY
,JUN
,JUL
,AUG
,SEP
,OCT
,NOV
,DEC
 from [Transaction]
 where Username = '" + s_username + @"'
";

         

            ds = DatabaseConnection.Connection2(query);


            int CTR, TOTAL;
            TOTAL = ds.Tables[0].Rows.Count;

            string description, category;
            double jan, feb, mar, apr, may, jun, jul, aug, sep, oct, nov, dec;
            double total_jan_util = 0;
            double total_jan_rent = 0;
            double total_jan_food = 0;
            double total_jan = 0;

            double total_feb_util = 0;
            double total_feb_rent = 0;
            double total_feb_food = 0;
            double total_feb = 0;

            double total_mar_util = 0;
            double total_mar_rent = 0;
            double total_mar_food = 0;
            double total_mar = 0;
            
            double total_apr_util = 0;
            double total_apr_rent = 0;
            double total_apr_food = 0;
            double total_apr = 0;

            double total_may_util = 0;
            double total_may_rent = 0;
            double total_may_food = 0;
            double total_may = 0;

            double total_jun_util = 0;
            double total_jun_rent = 0;
            double total_jun_food = 0;
            double total_jun = 0;

            double total_jul_util = 0;
            double total_jul_rent = 0;
            double total_jul_food = 0;
            double total_jul = 0;

            double total_aug_util = 0;
            double total_aug_rent = 0;
            double total_aug_food = 0;
            double total_aug = 0;

            double total_sep_util = 0;
            double total_sep_rent = 0;
            double total_sep_food = 0;
            double total_sep = 0;

            double total_oct_util = 0;
            double total_oct_rent = 0;
            double total_oct_food = 0;
            double total_oct = 0;

            double total_nov_util = 0;
            double total_nov_rent = 0;
            double total_nov_food = 0;
            double total_nov = 0;

            double total_dec_util = 0;
            double total_dec_rent = 0;
            double total_dec_food = 0;
            double total_dec = 0;


            for (CTR = 0; CTR < TOTAL; CTR++)
            {
                drow = ds.Tables[0].Rows[CTR];

                description = drow.ItemArray.GetValue(0).ToString();
                category = drow.ItemArray.GetValue(1).ToString();
                
                try
                {
                    jan = double.Parse(drow.ItemArray.GetValue(2).ToString());

                }
                catch (Exception)
                {
                    jan = 0;
                }

                try
                {
                    feb = double.Parse(drow.ItemArray.GetValue(3).ToString());
                }
                catch (Exception)
                {
                    feb = 0;
                }

                try
                {
                    mar = double.Parse(drow.ItemArray.GetValue(4).ToString());
                }
                catch (Exception)
                {
                    mar = 0;
                }
                try
                {
                    apr = double.Parse(drow.ItemArray.GetValue(5).ToString());
                }
                catch (Exception)
                {
                    apr = 0;
                }

                try
                {
                    may = double.Parse(drow.ItemArray.GetValue(6).ToString());
                }
                catch (Exception)
                {
                    may = 0;
                }
                try
                {
                    jun = double.Parse(drow.ItemArray.GetValue(7).ToString());
                }
                catch (Exception)
                {
                    jun = 0;
                }
                try
                {
                    jul = double.Parse(drow.ItemArray.GetValue(8).ToString());
                }
                catch (Exception)
                {
                    jul = 0;
                }
                try
                {
                    aug = double.Parse(drow.ItemArray.GetValue(9).ToString());
                }
                catch (Exception)
                {
                    aug = 0;
                }
                try
                {
                    sep = double.Parse(drow.ItemArray.GetValue(10).ToString());
                }
                catch (Exception)
                {
                    sep = 0;
                }
                try
                {
                    oct = double.Parse(drow.ItemArray.GetValue(11).ToString());
                }
                catch (Exception)
                {
                    oct = 0;
                }
                try
                {
                    nov = double.Parse(drow.ItemArray.GetValue(12).ToString()); 
                }
                catch (Exception)
                {
                    nov = 0;
                }
                try
                {
                    dec = double.Parse(drow.ItemArray.GetValue(13).ToString());
                }
                catch (Exception)
                {
                    dec = 0;
                }
                total_jan += jan;
                total_feb += feb;
                total_mar += mar;
                total_apr += apr;
                total_may += may;
                total_jun += jun;
                total_jul += jul;
                total_aug += aug;
                total_sep += sep;
                total_oct += oct;
                total_nov += nov;
                total_dec += dec;

                if (category.ToUpper().Replace(" ","").Equals("UTILITY"))
                {
                    total_jan_util += jan;
                    total_feb_util += feb;
                    total_mar_util += mar;
                    total_apr_util += apr;
                    total_may_util += may;
                    total_jun_util += jun;
                    total_jul_util += jul;
                    total_aug_util += aug;
                    total_sep_util += sep;
                    total_oct_util += oct;
                    total_nov_util += nov;
                    total_dec_util += dec;
                }
                else if(category.ToUpper().Replace(" ","").Equals("RENT"))
                {
                    total_jan_rent += jan;
                    total_feb_rent += feb;
                    total_mar_rent += mar;
                    total_may_rent += may;
                    total_jun_rent += jun;
                    total_jul_rent += jul;
                    total_aug_rent += aug;
                    total_sep_rent += sep;
                    total_oct_rent += oct;
                    total_nov_rent += nov;
                    total_dec_rent += dec;
                }
                else if (category.ToUpper().Replace(" ", "").Equals("FOOD"))
                {
                    total_jan_food += jan;
                    total_feb_food += feb;
                    total_mar_food += mar;
                    total_may_food += may;
                    total_jun_food += jun;
                    total_jul_food += jul;
                    total_aug_food += aug;
                    total_sep_food += sep;
                    total_oct_food += oct;
                    total_nov_food += nov;
                    total_dec_food += dec;
                }

                //add
                dataGridView1.Rows.Add(description,category, jan, feb,mar,apr,may
                    ,jun
                    ,jul
                    ,aug
                    ,sep
                    ,oct
                    ,nov
                    ,dec);
            }


            dataGridView1.Rows.Add("TOTAL", "UTILITY", total_jan_util, total_feb_util,total_mar_util, total_may_util, total_jun_util, total_jul_util
                ,total_aug_util,
                total_sep_util
                , total_oct_util
                , total_nov_util
                , total_dec_util);
            dataGridView1.Rows.Add("TOTAL", "RENT", total_jan_rent,total_feb_rent,total_mar_rent
                , total_apr_rent
                , total_may_rent
                , total_jun_rent
                , total_jul_rent
                , total_aug_rent
                , total_sep_rent
                , total_oct_rent
                , total_nov_rent
                , total_dec_rent);
            dataGridView1.Rows.Add("TOTAL", "FOOD", total_jan_food, total_feb_food, total_mar_food
                , total_apr_food
                , total_may_food
                , total_jun_food
                , total_jul_food
                , total_aug_food
                , total_sep_food
                , total_oct_food
                , total_nov_food
                , total_dec_food);
            dataGridView1.Rows.Add("TOTAL", "OVERALL", total_jan,total_feb,total_mar
                , total_apr
                , total_may
                , total_jun
                , total_jul
                , total_aug
                , total_sep
                , total_oct
                , total_nov
                , total_dec);

          
        }

        
    }
}
