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
using System.IO;

namespace Image
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string connectionString = "Data Source=DESKTOP-D7E5QRU\\BILASH;Initial Catalog=Test;User ID=sa;Password=1234";
        SqlConnection connection = new SqlConnection(connectionString);
        string imageLocation = "";
        SqlCommand cmd;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "jpg files(*.jpg)|*.jpg|png files(*.png)|*.png|All files(*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imageLocation = dialog.FileName.ToString();
                pictureBox1.ImageLocation = imageLocation;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] images = null;
            FileStream stream = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(stream);
            images = brs.ReadBytes((int)stream.Length);

            connection.Open();
            string query = "Insert into Book(ID,Name,Image) values('" + textBox1.Text + "', '" + textBox2.Text + "', @images)";
            cmd = new SqlCommand(query, connection);
            cmd.Parameters.Add(new SqlParameter("@images", images));
            int N = cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show(N.ToString() + "Data saved successfully...!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection.Open();
            connection = new SqlConnection(connectionString);
            string query = "select Name,Image from Book where id='" + textBox1.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            textBox2.Text = dt.Rows[0][0].ToString();

            byte[] img = (byte[])dt.Rows[0][1];

            MemoryStream ms = new MemoryStream(img);

            pictureBox1.Image = Image.FromStream(ms);
        }
    }
}
