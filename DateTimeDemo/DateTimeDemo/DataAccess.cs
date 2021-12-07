using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    public static class DataAccess
    {
        private static string _connectionString = "Data Source=DESKTOP-D7E5QRU\\BILASH;Initial Catalog=Test;Persist Security Info=True;User ID=sa;Password=1234";


        public static DataTable LoadData(string query)
        {
            try
            {
                SqlConnection con = new SqlConnection(_connectionString);
                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);

                DataTable dt = ds.Tables[0];

                return dt;
            }
            catch (Exception)
            {
                return new DataTable();
            }
        }

        public static int ExecuteQuery(string query)
        {
            try
            {
                SqlConnection con = new SqlConnection(_connectionString);
                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);
                int row = cmd.ExecuteNonQuery();
                return row;
            }
            catch (Exception)
            {
                return -1;
            }
        }
    }
}
