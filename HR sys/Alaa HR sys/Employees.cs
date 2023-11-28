using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alaa_HR_sys
{
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.CustomFormat = " ";


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        char gender = '1';
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = '1';

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = '2';
        }

        int in_test;
        int vac_init = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            //assign values in chechBox 
            if (checkBox1.Checked)
                in_test = 1;
            else
                in_test = 0;


            //make connection with database and insert data in the employees table in the database
            SqlConnection conn = new SqlConnection("Database=SYSTEM_HR; server=LAPTOP-ID00VBN0\\SQLEXPRESS; Integrated Security=true;");
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into employees values('" + textBox1.Text + "','" + textBox16.Text + "','" + textBox2.Text + "','" + comboBox1.SelectedValue + "'," + textBox3.Text + ",'" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + comboBox2.SelectedValue + "','" + textBox12.Text + "','" + comboBox4.SelectedValue + "','" + gender + "','" + textBox18.Text + "','" + textBox17.Text + "','" + comboBox3.SelectedValue + "','" + dateTimePicker3.Value + "','" + dateTimePicker1.Value + "','" + dateTimePicker2.Value + "', " + vac_init + " , " + vac_init + " ,'" + textBox15.Text + "','" + textBox14.Text + "','" + in_test + "')";
            MessageBox.Show("Added!");
            cmd.ExecuteNonQuery();
            if (comboBox1.SelectedValue.ToString() == "1")
            {
                cmd.CommandText = "update employees set vac_open_balance=30 , vac_balance=30 where emp_id='" + textBox1.Text + "'";
                cmd.ExecuteNonQuery();
            }
            else
            {
                cmd.CommandText = "update employees set vac_open_balance=21 , vac_balance=21 where emp_id='" + textBox1.Text + "'";
                cmd.ExecuteNonQuery();
            }
            conn.Close();
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            //connect with SYSTEM_HR database

            SqlConnection conn = new SqlConnection("Database=SYSTEM_HR; server=LAPTOP-ID00VBN0\\SQLEXPRESS; Integrated Security=true;");
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;

            //retrive data from database into combobox

            cmd.CommandText = "SELECT [emp_stat_id],[emp_stat_name] FROM [emp_status]";
            SqlDataReader rdr1 = cmd.ExecuteReader();
            DataTable dataTable1 = new DataTable();
            dataTable1.Load(rdr1);

            comboBox1.DataSource = dataTable1;
            comboBox1.DisplayMember = "emp_stat_name";
            comboBox1.ValueMember = "emp_stat_id";


            cmd.CommandText = "SELECT[religion_id] ,[religion_name] FROM.[religions]";
            SqlDataReader rdr2 = cmd.ExecuteReader();
            DataTable dataTable2 = new DataTable();
            dataTable2.Load(rdr2);

            comboBox2.DataSource = dataTable2;
            comboBox2.DisplayMember = "religion_name";
            comboBox2.ValueMember = "religion_id";

            cmd.CommandText = "SELECT [mrtl_stat_id] ,[mrtl_stat_name] FROM [marital_status]";
            SqlDataReader rdr3 = cmd.ExecuteReader();
            DataTable dataTable3 = new DataTable();
            dataTable3.Load(rdr3);

            comboBox3.DataSource = dataTable3;
            comboBox3.DisplayMember = "mrtl_stat_name";
            comboBox3.ValueMember = "mrtl_stat_id";

            cmd.CommandText = "SELECT [natinol_id] ,[national_name] FROM [nationality]";
            SqlDataReader rdr4 = cmd.ExecuteReader();
            DataTable dataTable4 = new DataTable();
            dataTable4.Load(rdr4);

            comboBox4.DataSource = dataTable4;
            comboBox4.DisplayMember = "national_name";
            comboBox4.ValueMember = "natinol_id";

            //close connection with database
            conn.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {

            //connect with SYSTEM_HR database

            SqlConnection conn = new SqlConnection("Database=SYSTEM_HR; server=LAPTOP-ID00VBN0\\SQLEXPRESS; Integrated Security=true;");
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;

            //update employee record in the database where employee id = textBox1.Text   
            cmd.CommandText = "UPDATE [employees]  SET  [emp_name] = '" + textBox16.Text + "'  , position = '" + textBox2.Text + "' , emp_stat_id = '" + comboBox1.SelectedValue + "' , emp_salary = " + textBox3.Text + " , dep_id = '" + textBox4.Text + "' , sec_id = '" + textBox5.Text + "' , cost_level1 = '" + textBox6.Text + "' , cost_level2 = '" + textBox7.Text + "' , religion_id = '" + comboBox2.SelectedValue + "' , emp_ssn = '" + textBox12.Text + "' , natinol_id = '" + comboBox4.SelectedValue + "' , gndr_id = '" + gender + "'  , emp_phone = '" + textBox18.Text + "' , emp_address = '" + textBox17.Text + "' , mrtl_stat_id = '" + comboBox3.SelectedValue + "' , emp_birthdate = '" + dateTimePicker3.Value + "' , emp_join_date = '" + dateTimePicker1.Value + "' , emp_resigned_date = '" + dateTimePicker2.Value + "'  , emp_atm = '" + textBox15.Text + "' , emp_email = '" + textBox14.Text + "' , emp_in_test = '" + in_test + "'  WHERE emp_id='" + textBox1.Text + "'";

            cmd.ExecuteNonQuery();


            //close connection with database
            conn.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            //connect with SYSTEM_HR database

            SqlConnection conn = new SqlConnection("Database=SYSTEM_HR; server=LAPTOP-ID00VBN0\\SQLEXPRESS; Integrated Security=true;");
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;

            //delect employee record from database where employee id = textBox1.Text

            cmd.CommandText = "Delete FROM [employees] where emp_id='"+textBox1.Text+"'";

            cmd.ExecuteNonQuery();


            //close connection with database
            conn.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.CustomFormat = "mm/dd/yyyy";
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            //connect with SYSTEM_HR database

            SqlConnection conn = new SqlConnection("Database=SYSTEM_HR; server=LAPTOP-ID00VBN0\\SQLEXPRESS; Integrated Security=true;");
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;

            //select employee record from database where employee id = textBox1.Text

            cmd.CommandText = "select * FROM [employees] where emp_id='" + textBox1.Text + "'";
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {

                textBox1.Text= reader["emp_id"].ToString();
                textBox16.Text= reader["emp_name"].ToString();
                textBox2.Text= reader["position"].ToString();
                comboBox1.Text = reader["emp_stat_id"].ToString();
                textBox3.Text= reader["emp_salary"].ToString();
                textBox4.Text= reader["dep_id"].ToString();
                textBox5.Text= reader["sec_id"].ToString();
                textBox6.Text= reader["cost_level1"].ToString();
                textBox7.Text= reader["cost_level2"].ToString();
                comboBox2.Text = reader["religion_id"].ToString();
                textBox12.Text= reader["emp_ssn"].ToString();
                comboBox4.Text = reader["natinol_id"].ToString();
                textBox18.Text= reader["emp_phone"].ToString();
                textBox17.Text= reader["emp_address"].ToString();
                comboBox3.Text = reader["emp_stat_id"].ToString();
                dateTimePicker3.Value = (DateTime)reader["emp_birthdate"];
                dateTimePicker1.Value = (DateTime)reader["emp_join_date"];
                dateTimePicker2.Value = (DateTime)reader["emp_resigned_date"];
                textBox15.Text = reader["emp_atm"].ToString();
                textBox14.Text = reader["emp_email"].ToString();
                checkBox1.Checked = (reader.GetBoolean(reader.GetOrdinal("emp_in_test")));
                char genderval;
                genderval = Convert.ToChar(reader["gndr_id"].ToString());
                if (genderval == '1') { radioButton1.Checked = true; }
                else { radioButton2.Checked = true; }


                }

            //close connection with database
            conn.Close();
        }
    }
}
