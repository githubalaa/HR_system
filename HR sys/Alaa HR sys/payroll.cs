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
    public partial class payroll : Form
    {
        public payroll()
        {
            InitializeComponent();
        }
        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            //connect with SYSTEM_HR database

            SqlConnection conn = new SqlConnection("Database=SYSTEM_HR; server=LAPTOP-ID00VBN0\\SQLEXPRESS; Integrated Security=true;");
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;

            //select employee record from database where id alreaddy in database 

            cmd.CommandText = "select * FROM [payroll] where emp_id='" + textBox3.Text + "' and Pay_month= " + dateTimePicker2.Text + " and pay_year= " + dateTimePicker3.Text;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                label20.Text = reader["dep_id"].ToString();
                label19.Text = reader["sec_id"].ToString();
                label18.Text = reader["cost_level1"].ToString();
                label31.Text = reader["cost_level2"].ToString();
                label33.Text = reader["emp_salary"].ToString();
                label23.Text = reader["over_amount"].ToString();
                label22.Text = reader["bouns_amount"].ToString();
                label21.Text = reader["exp_amount"].ToString();
                label26.Text = reader["loan_instal_amount"].ToString();
                label25.Text = reader["recieve_amount"].ToString();
                label24.Text = reader["deduct_amount"].ToString();
                label29.Text = reader["vac_amount"].ToString();
                label28.Text = reader["tax_due_amount"].ToString();
                label27.Text = reader["income_tax"].ToString();
                label30.Text = reader["net_pay"].ToString();
            }

            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //make connection with database and insert data in the employees table in the database
            SqlConnection conn = new SqlConnection("Database=SYSTEM_HR; server=LAPTOP-ID00VBN0\\SQLEXPRESS; Integrated Security=true;");
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            SqlCommand cmmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandText = $"insert into payroll (emp_id, Pay_month, pay_year,pay_date) values('" + textBox3.Text + "' , " + dateTimePicker2.Text + ", " + dateTimePicker3.Text + ",'" + dateTimePicker1.Text + "'); insert into Payroll(dep_id, sec_id, cost_level1, cost_level2, emp_salary, over_amount, bouns_amount, exp_amount, loan_instal_amount, recieve_amount, deduct_amount, vac_amount, tax_due_amount, income_tax, net_pay)(select dep_id, sec_id, cost_level1, cost_level2, emp_salary from employees where employees.emp_id = '" + textBox3.Text + "')(select round(sum(overtime.over_hours * employees.emp_salary / 240), 2) as over_amount from employees inner join overtime on employees.emp_id = overtime.emp_id where overtime.over_date between '" + dateTimePicker2.Text + "/01/" + dateTimePicker3.Text + "' and '" + dateTimePicker2.Text + "/31/" + dateTimePicker3.Text + "' group by employees.emp_id )(select sum(employees.emp_salary * bouns_base.bouns_factor) as bouns_amount from bouns inner join employees on employees.emp_id = bouns.emp_id inner join bouns_base on bouns.bouns_id = bouns_base.bouns_id where bouns.bouns_date between '" + dateTimePicker2.Text + "/01/" + dateTimePicker3.Text + "' and '" + dateTimePicker2.Text + "/31/" + dateTimePicker3.Text + "' group by employees.emp_id )(select exp_amount from expencess inner join employees on employees.emp_id = expencess.emp_id inner join expencess_base on expencess.exp_code= expencess_base.exp_code where expencess.exp_date between '" + dateTimePicker2.Text + "/01/" + dateTimePicker3.Text + "' and '" + dateTimePicker2.Text + "/31/" + dateTimePicker3.Text + "' group by employees.emp_id )(select loan_instal_amount as loan_instal_amount from loans inner join employees on employees.emp_id = loans.emp_id where loan_suspend = 0 and loan_balance != loan_amount and loans.loan_start_month <= " + dateTimePicker2.Text + " and loan_start_year <= " + dateTimePicker3.Text + ")(select sum(recieve_amount) as recieve_amount, sum(deduct_amount) as deduct_amount from recieve_deduct inner join employees on employees.emp_id = recieve_deduct.emp_id where recieve_deduct.rec_dedc_date between '" + dateTimePicker2.Text + "/01/" + dateTimePicker3.Text + "' and '" + dateTimePicker2.Text + "/31/" + dateTimePicker3.Text + "' group by employees.emp_id)(select sum(vac_days) * vac_factor as vac_total_days  from vacation inner join employees on employees.emp_id = vacation.emp_id inner join vacation_base on vacation.vac_code = vacation_base.vac_code where vacation.vac_posted = 1 and vacation.end_date between '" + dateTimePicker2.Text + "/01/" + dateTimePicker3.Text + "' and '" + dateTimePicker2.Text + "/31/" + dateTimePicker3.Text + "')(select dbo.get_tax((select round(sum(overtime.over_hours * employees.emp_salary / 240), 2) as over_amount from employees inner join overtime on employees.emp_id = overtime.emp_id where overtime.over_date between '" + dateTimePicker2.Text + "/01/" + dateTimePicker3.Text + "' and '" + dateTimePicker2.Text + "/31/" + dateTimePicker3.Text + "' group by employees.emp_id) + (select sum(employees.emp_salary * bouns_base.bouns_factor) as bouns_amount from bouns inner join employees on employees.emp_id = bouns.emp_id inner join bouns_base on bouns.bouns_id = bouns_base.bouns_id where bouns.bouns_date between '" + dateTimePicker2.Text + "/01/" + dateTimePicker3.Text + "' and '" + dateTimePicker2.Text + "/31/" + dateTimePicker3.Text + "' group by employees.emp_id) + (select dbo.get_tax(emp_salary) as income_tax from employees)) as tax_due_amount from employees, bouns, bouns_base, overtime)(select dbo.get_tax(emp_salary) as income_tax from employees)(select emp_salary + round(sum(overtime.over_hours * employees.emp_salary / 240), 2) + sum(employees.emp_salary * bouns_base.bouns_factor) + sum(recieve_amount) - (sum(exp_amount) + sum(loan_instal_amount) + sum(deduct_amount) + sum(vac_days * vac_factor) + dbo.get_tax((select round(sum(overtime.over_hours * employees.emp_salary / 240), 2) as over_amount from employees inner join overtime on employees.emp_id = overtime.emp_id where overtime.over_date between '" + dateTimePicker2.Text + "/01/" + dateTimePicker3.Text + "' and '" + dateTimePicker2.Text + "/31/" + dateTimePicker3.Text + "' group by employees.emp_id) + (select sum((employees.emp_salary) * (bouns_base.bouns_factor)) as bouns_amount from bouns inner join employees on employees.emp_id = bouns.emp_id inner join bouns_base on bouns.bouns_id = bouns_base.bouns_id where bouns.bouns_date between '" + dateTimePicker2.Text + "/01/" + dateTimePicker3.Text + "' and '" + dateTimePicker2.Text + "/31/" + dateTimePicker3.Text + "' group by employees.emp_id) + (select dbo.get_tax(emp_salary) as income_tax from employees))) as net_pay from employees, overtime, bouns, bouns_base, expencess, expencess_base, loans, recieve_deduct, vacation_base, vacation where employees.emp_id='" + textBox3.Text + "' and bouns.bouns_date between '" + dateTimePicker2.Text + "/01/" + dateTimePicker3.Text + "' and '" + dateTimePicker2.Text + "/31/" + dateTimePicker3.Text + "' and overtime.over_date between '" + dateTimePicker2.Text + "/01/" + dateTimePicker3.Text + "' and '" + dateTimePicker2.Text + "/31/" + dateTimePicker3.Text + "' and vacation.vac_posted=1 and vacation.end_date between '" + dateTimePicker2.Text + "/01/" + dateTimePicker3.Text + "' and '" + dateTimePicker2.Text + "/31/" + dateTimePicker3.Text + "' and recieve_deduct.rec_dedc_date between '" + dateTimePicker2.Text + "/01/" + dateTimePicker3.Text + "' and '" + dateTimePicker2.Text + "/31/" + dateTimePicker3.Text + "' and expencess.exp_date between '" + dateTimePicker2.Text + "/01/" + dateTimePicker3.Text + "' and '" + dateTimePicker2.Text + "/31/" + dateTimePicker3.Text + "' group by emp_salary, employees.emp_id)";
            MessageBox.Show("Done!");
            cmd.ExecuteNonQuery();
            textBox3.Text = "";
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
            dateTimePicker3.Value = DateTime.Today;
            label20.Text = "";
            label19.Text = "";
            label18.Text = "";
            label31.Text = "";
            label33.Text = "";
            label23.Text = "";
            label22.Text = "";
            label21.Text = "";
            label26.Text = "";
            label25.Text = "";
            label24.Text = "";
            label29.Text = "";
            label28.Text = "";
            label27.Text = "";
            label30.Text = "";
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //make connection with database and insert data in the employees table in the database
            SqlConnection conn = new SqlConnection("Database=SYSTEM_HR; server=LAPTOP-ID00VBN0\\SQLEXPRESS; Integrated Security=true;");
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            SqlCommand cmmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandText = "delete from payroll where emp_id= '" + textBox3.Text + "', Pay_month= " + dateTimePicker2.Text + " , pay_year= " + dateTimePicker3.Text ;
            MessageBox.Show("Done!");
            cmd.ExecuteNonQuery();
            textBox3.Text = "";
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
            dateTimePicker3.Value = DateTime.Today;
            label20.Text = "";
            label19.Text = "";
            label18.Text = "";
            label31.Text = "";
            label33.Text = "";
            label23.Text = "";
            label22.Text = "";
            label21.Text = "";
            label26.Text = "";
            label25.Text = "";
            label24.Text = "";
            label29.Text = "";
            label28.Text = "";
            label27.Text = "";
            label30.Text = "";
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

/*





*/