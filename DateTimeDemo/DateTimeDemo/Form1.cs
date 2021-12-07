using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DateTimeDemo;

namespace DateTimeDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string date = dateTimePicker1.Value.ToString();
            string query = "insert into DateTest values('" + date + "')";
            DataConnection.ExecuteQuery(query);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "select Date from DateTest where Id="+int.Parse(txtID.Text)+"";
            DataTable dt = DataConnection.LoadData(query);
            string date = dt.Rows[0][0].ToString();
            DateTime borrowDate = DateTime.Parse(date);
            DateTime today = DateTime.Now;
            TimeSpan ts = today - borrowDate;
            double totalDay = ts.TotalDays;
            string day = totalDay.ToString("0");
            MessageBox.Show(day);
        }
    }
}
