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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Alaa_HR_sys
{
    public partial class departments : Form
    {
        public departments()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Database=SYSTEM_HR; server=LAPTOP-ID00VBN0\\SQLEXPRESS; Integrated Security=true;");
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into department values('" + textBox3.Text + "'," + textBox2.Text + "','" + textBox4.Text + ",'" + textBox1.Text + "')";
            MessageBox.Show("Added !");
            cmd.ExecuteNonQuery();
            textBox3.Text = "";
            textBox4.Text = "";
            textBox2.Text = "";
            textBox1.Text = "";
            conn.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //make connection with database and insert data in the employees table in the database
            SqlConnection conn = new SqlConnection("Database=SYSTEM_HR; server=LAPTOP-ID00VBN0\\SQLEXPRESS; Integrated Security=true;");
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandText = "update department set dep_name='" + textBox4.Text + "' , sec_name='" + textBox1.Text + "' where dep_id= '" + textBox3.Text + "' and sec_id= '" + textBox2.Text + "'";
            MessageBox.Show("Updated !");
            cmd.ExecuteNonQuery();
            textBox3.Text = "";
            textBox4.Text = "";
            textBox2.Text = "";
            textBox1.Text = "";

            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //make connection with database and insert data in the employees table in the database
            SqlConnection conn = new SqlConnection("Database=SYSTEM_HR; server=LAPTOP-ID00VBN0\\SQLEXPRESS; Integrated Security=true;");
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandText = "delete from department where dep_id= '" + textBox3.Text + "' and sec_id= '" + textBox2.Text + "'";
            MessageBox.Show("Deleted !");
            cmd.ExecuteNonQuery();
            textBox3.Text = "";
            textBox4.Text = "";
            textBox2.Text = "";
            textBox1.Text = "";

            conn.Close();
        }

        private void textBox3_Validating_1(object sender, CancelEventArgs e)
        {
            //connect with SYSTEM_HR database

            SqlConnection conn = new SqlConnection("Database=SYSTEM_HR; server=LAPTOP-ID00VBN0\\SQLEXPRESS; Integrated Security=true;");
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;

            //select employee record from database where id alreaddy in database

            cmd.CommandText = "select * FROM [department] where dep_id='" + textBox3.Text + "' and sec_id= '" + textBox2.Text + "'";
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                textBox3.Text = reader["dep_id"].ToString();
                textBox4.Text = reader["dep_name"].ToString();
                textBox2.Text = reader["sec_id"].ToString();
                textBox1.Text = reader["sec_name"].ToString();

            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            //connect with SYSTEM_HR database

            SqlConnection conn = new SqlConnection("Database=SYSTEM_HR; server=LAPTOP-ID00VBN0\\SQLEXPRESS; Integrated Security=true;");
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;

            //select employee record from database where id alreaddy in database

            cmd.CommandText = "select * FROM [department] where dep_id='" + textBox3.Text + "'and sec_id= '" + textBox2.Text + "'";
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                textBox3.Text = reader["dep_id"].ToString();
                textBox4.Text = reader["dep_name"].ToString();
                textBox2.Text = reader["sec_id"].ToString();
                textBox1.Text = reader["sec_name"].ToString();

            }
        }
    }
}

