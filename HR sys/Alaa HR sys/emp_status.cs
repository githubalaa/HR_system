using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Alaa_HR_sys
{
    public partial class emp_status : Form
    {
        public emp_status()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            //connect with SYSTEM_HR database

            SqlConnection conn = new SqlConnection("Database=SYSTEM_HR; server=LAPTOP-ID00VBN0\\SQLEXPRESS; Integrated Security=true;");
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;

            //select employee record from database where id alreaddy in database

            cmd.CommandText = "select * FROM [emp_status] where emp_stat_id='" + textBox2.Text + "'";
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                textBox2.Text = reader["emp_stat_id"].ToString();
                textBox4.Text = reader["emp_stat_name"].ToString();
            }

            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //make connection with database and insert data in the employees table in the database
            SqlConnection conn = new SqlConnection("Database=SYSTEM_HR; server=LAPTOP-ID00VBN0\\SQLEXPRESS; Integrated Security=true;");
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into emp_status values(" + textBox2.Text + " ,'" + textBox4.Text + "')";
            MessageBox.Show("Added !");
            cmd.ExecuteNonQuery();
            textBox2.Text = "";
            textBox4.Text = "";

            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //make connection with database and insert data in the employees table in the database
            SqlConnection conn = new SqlConnection("Database=SYSTEM_HR; server=LAPTOP-ID00VBN0\\SQLEXPRESS; Integrated Security=true;");
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandText = "update emp_status set emp_stat_name='" + textBox4.Text + "' where emp_stat_id= " + textBox2.Text;
            MessageBox.Show("Updated !");
            cmd.ExecuteNonQuery();
            textBox2.Text = "";
            textBox4.Text = "";

            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //make connection with database and insert data in the employees table in the database
            SqlConnection conn = new SqlConnection("Database=SYSTEM_HR; server=LAPTOP-ID00VBN0\\SQLEXPRESS; Integrated Security=true;");
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandText = "delete from emp_status where emp_stat_id= " + textBox2.Text;
            MessageBox.Show("Deleted !");
            cmd.ExecuteNonQuery();
            textBox2.Text = "";
            textBox4.Text = "";

            conn.Close();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
