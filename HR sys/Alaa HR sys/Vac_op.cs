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
using System.Reflection.PortableExecutable;

namespace Alaa_HR_sys
{
    public partial class Vac_op : Form
    {
        public Vac_op()
        {
            InitializeComponent();
        }

        int posted;
        private void button1_Click(object sender, EventArgs e)
        {
            //assign values in chechBox 
            if (checkBox1.Checked)
                posted = 1;
            else
                posted = 0;


            SqlConnection conn = new SqlConnection("Database=SYSTEM_HR; server=LAPTOP-ID00VBN0\\SQLEXPRESS; Integrated Security=true;");
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            TimeSpan d = dateTimePicker2.Value - dateTimePicker1.Value;
            int days = d.Days + 1;
            cmd.CommandText = "insert into vacation values('" + textBox1.Text + "','" + textBox2.Text + "','" + dateTimePicker1.Value + "','" + dateTimePicker2.Value + "','" + posted + "'," + days + ")";
            MessageBox.Show(cmd.CommandText);
            cmd.ExecuteNonQuery();
            cmd.CommandText = "update employees set vac_balance=vac_balance-'" + days + "'";
            cmd.ExecuteNonQuery();
            textBox1.Text = "";
            textBox2.Text = "";
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
            checkBox1.Checked = false;
            label5.Text = "";
            conn.Close();

        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            //connect with SYSTEM_HR database

            SqlConnection conn = new SqlConnection("Database=SYSTEM_HR; server=LAPTOP-ID00VBN0\\SQLEXPRESS; Integrated Security=true;");
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;

            //select employee record from database where id alreaddy in database

            cmd.CommandText = "select * FROM [vacation] where emp_id='" + textBox1.Text + "' and vac_code='" + textBox2.Text + "' and from_date='" + dateTimePicker1.Value + "' ";
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                textBox1.Text = reader["emp_id"].ToString();
                textBox2.Text = reader["vac_code"].ToString();
                dateTimePicker1.Value = (DateTime)reader["from_date"];
                dateTimePicker2.Value = (DateTime)reader["end_date"];
                checkBox1.Checked = (reader.GetBoolean(reader.GetOrdinal("vac_posted")));
                label5.Text = reader["vac_days"].ToString();

            }
            conn.Close();
        }

        private void dateTimePicker2_Validating(object sender, CancelEventArgs e)
        {
            TimeSpan d = dateTimePicker2.Value - dateTimePicker1.Value;
            int days = d.Days + 1;
            label5.Text = days.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //connect with SYSTEM_HR database

            SqlConnection conn = new SqlConnection("Database=SYSTEM_HR; server=LAPTOP-ID00VBN0\\SQLEXPRESS; Integrated Security=true;");
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            TimeSpan d = dateTimePicker2.Value - dateTimePicker1.Value;
            int days = d.Days + 1;
            //select employee record from database where id alreaddy in database
            cmd.CommandText = "update [vacation] set end_date='" + dateTimePicker2.Value + "', vac_posted='" + posted + "',vac_days=" + days + " where emp_id='" + textBox1.Text + "' and vac_code='" + textBox2.Text + "' and from_date='" + dateTimePicker1.Value + "' ";
            MessageBox.Show("updated!");
            cmd.ExecuteNonQuery(); 
            textBox1.Text = "";
            textBox2.Text = "";
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
            checkBox1.Checked = false;
            label5.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //make connection with database and insert data in the employees table in the database
            SqlConnection conn = new SqlConnection("Database=SYSTEM_HR; server=LAPTOP-ID00VBN0\\SQLEXPRESS; Integrated Security=true;");
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandText = "delete from vacation where emp_id='" + textBox1.Text + "' and vac_code='" + textBox2.Text + "' ";
            MessageBox.Show("Deleted!");
            cmd.ExecuteNonQuery();
            textBox1.Text = "";
            textBox2.Text = "";
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
            checkBox1.Checked = false;
            label5.Text = "";

            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
