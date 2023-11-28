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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Alaa_HR_sys
{
    public partial class Exp_op : Form
    {
        public Exp_op()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            //connect with SYSTEM_HR database

            SqlConnection conn = new SqlConnection("Database=SYSTEM_HR; server=LAPTOP-ID00VBN0\\SQLEXPRESS; Integrated Security=true;");
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;

            //select record from database where id alreaddy in database

            cmd.CommandText = "select * FROM [expencess] where emp_id='" + textBox3.Text + "' and exp_code='" + textBox4.Text + "' and exp_date='" + dateTimePicker1.Value + "' ";
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                textBox3.Text = reader["emp_id"].ToString();
                textBox4.Text = reader["exp_code"].ToString();
                dateTimePicker1.Value = (DateTime)reader["exp_date"];
                textBox2.Text = reader["exp_amount"].ToString();
                textBox5.Text = reader["exp_descrip"].ToString();

            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Database=SYSTEM_HR; server=LAPTOP-ID00VBN0\\SQLEXPRESS; Integrated Security=true;");
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into expencess values('" + textBox3.Text + "','" + textBox4.Text + "','" + dateTimePicker1.Value + "','" + textBox2.Text + "','" + textBox5.Text + "')";
            MessageBox.Show("Added!");
            cmd.ExecuteNonQuery();
            textBox5.Text = "";
            textBox2.Text = "";
            dateTimePicker1.Value = DateTime.Today;
            textBox3.Text = "";
            textBox4.Text = "";
            conn.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Database=SYSTEM_HR; server=LAPTOP-ID00VBN0\\SQLEXPRESS; Integrated Security=true;");
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandText = "update expencess set exp_amount='" + textBox2.Text + "', exp_descrip= '" + textBox5.Text + "' where emp_id= '" + textBox3.Text + "' and exp_code= '" + textBox4.Text + "'and exp_date='" + dateTimePicker1.Value + "'";
            MessageBox.Show("updated!");
            cmd.ExecuteNonQuery();
            textBox5.Text = "";
            textBox2.Text = "";
            dateTimePicker1.Value = DateTime.Today;
            textBox3.Text = "";
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
            cmd.CommandText = "delete from expencess wherewhere emp_id= '" + textBox3.Text + "' and exp_code= '" + textBox4.Text + "'and exp_date='" + dateTimePicker1.Value + "'";
            MessageBox.Show("Deleted!");
            cmd.ExecuteNonQuery();
            textBox5.Text = "";
            textBox2.Text = "";
            dateTimePicker1.Value = DateTime.Today;
            textBox3.Text = "";
            textBox4.Text = "";

            conn.Close();
        }
    }
}
