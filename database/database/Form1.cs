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

namespace database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string conString = "Data Source=DESKTOP-D7E5QRU\\BILASH;Initial Catalog=ConnectionDB;User ID=sa;Password=1234";

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            if (con.State == System.Data.ConnectionState.Open)
            {
                string query = "insert into Test(id, name) values('" + txtID.Text.ToString() + "','" + txtName.Text.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                
				/*
				int i = cmd.ExecuteNonQuery();
				if(i>=1){
					MessageBox.Show("Inserted");
				}
				else{
					MessageBox.Show("Insert Failed");
				}
				*/
				
                MessageBox.Show("Connection made successfully");
            }
        }
    }
}
