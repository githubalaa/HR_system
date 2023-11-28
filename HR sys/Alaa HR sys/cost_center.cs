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
    public partial class cost_center : Form
    {
        public cost_center()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Database=SYSTEM_HR; server=LAPTOP-ID00VBN0\\SQLEXPRESS; Integrated Security=true;");
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into cost_center values('" + textBox2.Text + "','" + textBox4.Text + "','" + textBox1.Text + "')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Added !");
            textBox2.Text = "";
            textBox4.Text = "";
            textBox1.Text = "";
            conn.Close();

        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Database=SYSTEM_HR; server=LAPTOP-ID00VBN0\\SQLEXPRESS; Integrated Security=true;");
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandText = "update cost_center set cost_name='" + textBox1.Text + "' where cost_level1='" + textBox2.Text + "' and cost_level2 = '" + textBox4.Text + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated !");
            textBox2.Text = "";
            textBox4.Text = "";
            textBox1.Text = "";
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Database=SYSTEM_HR; server=LAPTOP-ID00VBN0\\SQLEXPRESS; Integrated Security=true;");
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandText = "delete from cost_center where cost_level1='" + textBox2.Text + "' and cost_level2 = '" + textBox4.Text + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Deleted !");
            textBox2.Text = "";
            textBox4.Text = "";
            textBox1.Text = "";
            conn.Close();
        }

        private void textBox2_Validating_1(object sender, CancelEventArgs e)
        {
            //connect with SYSTEM_HR database

            SqlConnection conn = new SqlConnection("Database=SYSTEM_HR; server=LAPTOP-ID00VBN0\\SQLEXPRESS; Integrated Security=true;");
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;

            //select employee record from database where id alreaddy in database

            cmd.CommandText = "select * FROM [cost_center] where cost_level1='" + textBox2.Text + "' and cost_level2 = '" + textBox4.Text + "'";
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                textBox1.Text = reader["cost_name"].ToString();
            }

            conn.Close();

        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            //connect with SYSTEM_HR database

            SqlConnection conn = new SqlConnection("Database=SYSTEM_HR; server=LAPTOP-ID00VBN0\\SQLEXPRESS; Integrated Security=true;");
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;

            //select employee record from database where id alreaddy in database

            cmd.CommandText = "select * FROM [cost_center] where cost_level1='" + textBox2.Text + "' and cost_level2 = '" + textBox4.Text + "'";
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                textBox1.Text = reader["cost_name"].ToString();
            }

        }
    }
}
