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

namespace Alaa_HR_sys
{
    public partial class gndr : Form
    {
        public gndr()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //make connection with database and insert data in the employees table in the database
            SqlConnection conn = new SqlConnection("Database=SYSTEM_HR; server=LAPTOP-ID00VBN0\\SQLEXPRESS; Integrated Security=true;");
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into gndr values(" + textBox3.Text + " ,'" + textBox4.Text + "')";
            MessageBox.Show(cmd.CommandText);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
