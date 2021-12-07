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

namespace Data_Table
{
    public partial class Form1 : Form
    {

        string connectionString = "Data Source=DESKTOP-D7E5QRU\\BILASH;Initial Catalog=Test;User ID=sa;Password=1234";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            string query = "select * from Info";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            // Method 1
            dgv1.DataSource = dt;

            //Method 2
            dgv2.AutoGenerateColumns = false;
            dgv2.DataSource = dt;
        }
    }
}
