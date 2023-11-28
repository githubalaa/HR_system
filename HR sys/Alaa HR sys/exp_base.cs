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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Alaa_HR_sys
{
    public partial class exp_base : Form
    {
        public exp_base()
        {
            InitializeComponent();
        }

        int with_tax;

        private void button1_Click(object sender, EventArgs e)
        {
            //assign values in chechBox 
            if (checkBox1.Checked)
                with_tax = 1;
            else
                with_tax = 0;

            //make connection with database and insert data in the employees table in the database
            SqlConnection conn = new SqlConnection("Database=SYSTEM_HR; server=LAPTOP-ID00VBN0\\SQLEXPRESS; Integrated Security=true;");
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into expencess_base values('" + textBox3.Text + "' ,'" + textBox4.Text + "','" + with_tax + "')";
            MessageBox.Show("Added!");
            cmd.ExecuteNonQuery();
            textBox4.Text = "";
            textBox3.Text = "";
            checkBox1.Checked = false;
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

            //select  record from database where id alreaddy in database

            cmd.CommandText = "select * FROM [expencess_base] where exp_code='" + textBox3.Text + "' ";
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                textBox3.Text = reader["exp_code"].ToString();
                textBox4.Text = reader["exp_type"].ToString();
                checkBox1.Checked = (reader.GetBoolean(reader.GetOrdinal("has_tax")));

            }
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //assign values in chechBox 
            if (checkBox1.Checked)
                with_tax = 1;
            else
                with_tax = 0;

            //make connection with database and insert data in the employees table in the database
            SqlConnection conn = new SqlConnection("Database=SYSTEM_HR; server=LAPTOP-ID00VBN0\\SQLEXPRESS; Integrated Security=true;");
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandText = "update expencess_base set exp_type= '" + textBox4.Text + "', has_tax= '" + with_tax + "' where exp_code= '" + textBox3.Text + "'";
            MessageBox.Show("Upadeted!");
            cmd.ExecuteNonQuery();
            textBox4.Text = "";
            textBox3.Text = "";
            checkBox1.Checked = false;
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //make connection with database and insert data in the employees table in the database
            SqlConnection conn = new SqlConnection("Database=SYSTEM_HR; server=LAPTOP-ID00VBN0\\SQLEXPRESS; Integrated Security=true;");
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandText = "delete from expencess_base where exp_code='" + textBox3.Text + "' ";
            MessageBox.Show("Deleted !");
            cmd.ExecuteNonQuery();
            textBox3.Text = "";
            textBox4.Text = "";
            checkBox1.Checked = false;
            conn.Close();
        }
    }
}
