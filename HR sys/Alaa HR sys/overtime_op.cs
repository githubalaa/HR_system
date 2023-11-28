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
using System.Reflection.Emit;

namespace Alaa_HR_sys
{
    public partial class overtime_op : Form
    {
        public overtime_op()
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
            cmd.CommandText = "insert into overtime values('" + textBox3.Text + "','" + dateTimePicker1.Value + "'," + textBox6.Text + ",'" + posted + "'," + textBox8.Text + ")";
            cmd.ExecuteNonQuery();

            textBox3.Text = "";
            dateTimePicker1.Value = DateTime.Today;
            textBox6.Text = "";
            checkBox1.Checked = false;
            textBox8.Text = "";

            conn.Close();

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

            //select employee record from database where id alreaddy in database

            cmd.CommandText = "select * FROM [overtime] where over_id='" + textBox3.Text + "' and over_date ='" + dateTimePicker1.Value + "'";
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                textBox3.Text = reader["over_id"].ToString();
                dateTimePicker1.Value = (DateTime)reader["over_date"];
                textBox6.Text = reader["over_hours"].ToString();
                checkBox1.Checked = (reader.GetBoolean(reader.GetOrdinal("over_status")));
                textBox8.Text = reader["over_factor"].ToString();

            }
            conn.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //assign values in chechBox 
            if (checkBox1.Checked)
                posted = 1;
            else
                posted = 0;

            //connect with SYSTEM_HR database

            SqlConnection conn = new SqlConnection("Database=SYSTEM_HR; server=LAPTOP-ID00VBN0\\SQLEXPRESS; Integrated Security=true;");
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;

            //select record from database where id alreaddy in database
            cmd.CommandText = "update [overtime] set over_hours='" + textBox6.Text + "', over_factor='" + textBox8.Text + "' , over_status='" + posted + "' where over_id='" + textBox3.Text + "' and over_date ='" + dateTimePicker1.Value + "'";
            MessageBox.Show("updated!");
            cmd.ExecuteNonQuery();
            textBox3.Text = "";
            dateTimePicker1.Value = DateTime.Today;
            textBox6.Text = "";
            checkBox1.Checked = false;
            textBox8.Text = "";
            conn.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //connect with SYSTEM_HR database

            SqlConnection conn = new SqlConnection("Database=SYSTEM_HR; server=LAPTOP-ID00VBN0\\SQLEXPRESS; Integrated Security=true;");
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;

            //delete record from database where id alreaddy in database
            cmd.CommandText = "delete from [overtime]  where over_id='" + textBox3.Text + "' and over_date ='" + dateTimePicker1.Value + "'";
            MessageBox.Show("deleted!");
            cmd.ExecuteNonQuery();
            textBox3.Text = "";
            dateTimePicker1.Value = DateTime.Today;
            textBox6.Text = "";
            checkBox1.Checked = false;
            textBox8.Text = "";
            conn.Close();

        }
    }
}
