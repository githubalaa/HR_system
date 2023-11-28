namespace Alaa_HR_sys
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employees e1 = new Employees();
            e1.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            emp_status emp_stat = new emp_status();
            emp_stat.ShowDialog();
        }

        private void departmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            departments dep = new departments();
            dep.ShowDialog();
        }

        private void costCentersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cost_center cc = new cost_center();
            cc.ShowDialog();
        }

        private void vacationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vac_base vac_b = new vac_base();
            vac_b.ShowDialog();
        }

        private void expencessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exp_base exp_b = new exp_base();
            exp_b.ShowDialog();
        }

        private void recievesAndDeductionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rec_ded_base r_d_base = new rec_ded_base();
            r_d_base.ShowDialog();
        }

        private void religionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            religions rlgn = new religions();
            rlgn.ShowDialog();

        }

        private void nationalitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nationalities nation = new Nationalities();
            nation.ShowDialog();
        }

        private void gendersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gndr gen = new gndr();
            gen.ShowDialog();
        }

        private void maritalStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {

            mrtl_stat m_stat = new mrtl_stat();
            m_stat.ShowDialog();
        }

        private void vacatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vac_op vac = new Vac_op();
            vac.ShowDialog();
        }

        private void overtimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            overtime_op over_Op = new overtime_op();
            over_Op.ShowDialog();
        }

        private void expencessToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Exp_op expencess = new Exp_op();
            expencess.ShowDialog();
        }

        private void recievesAndDedutionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rec_ded_op rec_Ded = new rec_ded_op();
            rec_Ded.ShowDialog();
        }

        private void loansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loans_op loan = new loans_op();
            loan.ShowDialog();
        }

        private void payrollsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            payroll pay = new payroll();
            pay.ShowDialog();
        }

        private void attendancesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            attend_op attend = new attend_op();
            attend.ShowDialog();
        }

        private void bounsTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bouns_base bouns_b = new Bouns_base();
            bouns_b.ShowDialog();
        }

        private void bounsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bouns b = new Bouns();
            b.ShowDialog();
        }
    }
}