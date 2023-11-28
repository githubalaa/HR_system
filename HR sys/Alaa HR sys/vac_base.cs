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
    public partial class vac_base : Form
    {
        public vac_base()
        {
            InitializeComponent();
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
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            gender = '3';
        }

        int yearly_rest;
        private void button1_Click(object sender, EventArgs e)
        {
            //assign values in chechBox 
            if (checkBox1.Checked)
                yearly_rest = 1;
            else
                yearly_rest = 0;

            //make connection with database and insert data in the employees table in the database
            SqlConnection conn = new SqlConnection("Database=SYSTEM_HR; server=LAPTOP-ID00VBN0\\SQLEXPRESS; Integrated Security=true;");
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into vacation_base values('" + textBox3.Text + "' ,'" + textBox4.Text + "','" + textBox2.Text + "','" + gender + "','" + comboBox2.SelectedValue + "','" + yearly_rest + "')";
            MessageBox.Show("Added!");
            cmd.ExecuteNonQuery();
            textBox3.Text = "";
            textBox4.Text = "";
            textBox2.Text = "";
            checkBox1.Checked = false;
            comboBox2.SelectedIndex = 0;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;

            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void vac_base_Load(object sender, EventArgs e)
        {

            //connect with SYSTEM_HR database

            SqlConnection conn = new SqlConnection("Database=SYSTEM_HR; server=LAPTOP-ID00VBN0\\SQLEXPRESS; Integrated Security=true;");
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;

            //retrive data from database into combobox
            cmd.CommandText = "SELECT[religion_id] ,[religion_name] FROM.[religions]";
            SqlDataReader rdr2 = cmd.ExecuteReader();
            DataTable dataTable2 = new DataTable();
            dataTable2.Load(rdr2);

            comboBox2.DataSource = dataTable2;
            comboBox2.DisplayMember = "religion_name";
            comboBox2.ValueMember = "religion_id";
            //close connection with database
            conn.Close();
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            //connect with SYSTEM_HR database

            SqlConnection conn = new SqlConnection("Database=SYSTEM_HR; server=LAPTOP-ID00VBN0\\SQLEXPRESS; Integrated Security=true;");
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;

            //select employee record from database where id alreaddy in database

            cmd.CommandText = "select * FROM [vacation_base] where vac_code='" + textBox3.Text + "' ";
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                textBox3.Text = reader["vac_code"].ToString();
                textBox4.Text = reader["vac_type"].ToString();
                textBox2.Text = reader["vac_factor"].ToString();
                comboBox2.Text = reader["religion_id"].ToString();
                checkBox1.Checked = (reader.GetBoolean(reader.GetOrdinal("yearly_rest")));
                char genderval;
                genderval = Convert.ToChar(reader["gndr_id"].ToString());
                if (genderval == '1') { radioButton1.Checked = true; }
                else if (genderval == '2') { radioButton2.Checked = true; }
                else { radioButton3.Checked = true; }
            }
            conn.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //assign values in chechBox 
            if (checkBox1.Checked)
                yearly_rest = 1;
            else
                yearly_rest = 0;

            //make connection with database and insert data in the employees table in the database
            SqlConnection conn = new SqlConnection("Database=SYSTEM_HR; server=LAPTOP-ID00VBN0\\SQLEXPRESS; Integrated Security=true;");
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandText = "update vacation_base set vac_type='" + textBox4.Text + "', vac_factor='" + textBox2.Text + "', gndr_id = '" + gender + "', religion_id ='" + comboBox2.SelectedValue + "', yearly_rest='" + yearly_rest + "'where vac_code='" + textBox3.Text + "' ";
            MessageBox.Show("updated!");
            cmd.ExecuteNonQuery();
            textBox3.Text = "";
            textBox4.Text = "";
            textBox2.Text = "";
            checkBox1.Checked = false;
            comboBox2.SelectedIndex = 0;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //make connection with database and insert data in the employees table in the database
            SqlConnection conn = new SqlConnection("Database=SYSTEM_HR; server=LAPTOP-ID00VBN0\\SQLEXPRESS; Integrated Security=true;");
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandText = "delete from vacation_base where vac_code='" + textBox3.Text + "' ";
            MessageBox.Show("Deleted !");
            cmd.ExecuteNonQuery();
            textBox3.Text = "";
            textBox4.Text = "";
            textBox2.Text = "";
            checkBox1.Checked = false;
            comboBox2.SelectedIndex = 0;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            conn.Close();
        }
    }
    }

