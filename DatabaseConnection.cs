using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryA
{
   public class DatabaseConnection
    {

        public static string program_location = System.IO.Directory.GetCurrentDirectory();
        static string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={program_location}\testlogin.mdf;Integrated Security=True;Connect Timeout=30";

        public static DataTable Connection1(string query)
        {
            SqlConnection conm = new SqlConnection(connectionString);
            SqlDataAdapter sda = new SqlDataAdapter(query, conm);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            

            return dt;
        }


        public static DataSet Connection2(string query)
        {
            SqlConnection con;
            SqlCommand cmd;
            SqlDataAdapter da;
            DataSet ds;

            try
            {
                con = new SqlConnection(connectionString);
                cmd = new SqlCommand(query, con);
                con.Open();

                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, "Table");
                con.Close();
            }
            catch(Exception)
            {
                ds = new DataSet();
            }

            return ds;
        }
    }
}
