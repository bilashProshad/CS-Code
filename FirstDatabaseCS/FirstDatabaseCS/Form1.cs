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

namespace FirstDatabaseCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string connectionString = "Data Source=DESKTOP-D7E5QRU\\BILASH;Initial Catalog=ConnectionDB;User ID=sa;Password=1234";

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string query = "insert into Test(id, name, age, amount) values('" + txtID.Text.ToString() + "','" + txtName.Text.ToString() + "','"+txtAge.Text.ToString()+"','"+txtAmount.Text.ToString()+"')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Inserted");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            string query = "select * from Test where id ='" + txtID.Text.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query,con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            txtID.Text = dt.Rows[0][0].ToString();
            txtName.Text = dt.Rows[0][1].ToString();
            txtAge.Text = dt.Rows[0][2].ToString();
            txtAmount.Text = dt.Rows[0][3].ToString();
        }
    }
}
