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

namespace CURD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-D7E5QRU\\BILASH;Initial Catalog=CRUD_N;Persist Security Info=True;User ID=sa;Password=1234");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO member(ID, Name, Age) VALUES(@ID, @Name, @Age)", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Age", int.Parse(textBox3.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            MessageBox.Show("Successfully Inserted");
        }

        void BindData()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-D7E5QRU\\BILASH;Initial Catalog=CRUD_N;Persist Security Info=True;User ID=sa;Password=1234");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from member");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataTable dt = 
        }
    }
}
