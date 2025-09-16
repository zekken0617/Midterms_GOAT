namespace ChoicePayroll
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double birate, bihours, biincome,
                honorate, honohours, honoincome,
                otherrate, otherhours, otherincome,
                grossincome;

            birate = Convert.ToDouble(bi_rate.Text);
            bihours = Convert.ToDouble(bi_hours.Text);
            honorate = Convert.ToDouble(hono_rate.Text);
            honohours = Convert.ToDouble(hono_hours.Text);
            otherrate = Convert.ToDouble(oth_rate.Text);
            otherhours = Convert.ToDouble(oth_hours.Text);

            biincome = birate * bihours;
            honoincome = honorate * honohours;
            otherincome = otherrate * otherhours;
            grossincome = biincome + honoincome + otherincome;
            gross_income.Text = grossincome.ToString("0.00");
            bi_income.Text = biincome.ToString("0.00");
            hono_income.Text = honoincome.ToString("0.00");
            oth_income.Text = otherincome.ToString("0.00");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sssloan, pagibigloan, fsdeposit, fsloan, salaryloan, otherloan,
                totaldeduction, netincome, grossincome,
                phcon, pagibigcon, ssscon, incometaxcon;

            sssloan = Convert.ToDouble(sss_loan.Text);
            pagibigloan = Convert.ToDouble(pagibig_loan.Text);
            fsdeposit = Convert.ToDouble(fs_deposit.Text);
            fsloan = Convert.ToDouble(fs_loan.Text);
            salaryloan = Convert.ToDouble(salary_loan.Text);
            otherloan = Convert.ToDouble(other_loan.Text);
            grossincome = Convert.ToDouble(gross_income.Text);
            //philhealth contribution value
            if (grossincome == 10000)
            {
                phcon = 500;
            }
            else if (grossincome > 10000 && grossincome < 100000)
            {
                phcon = grossincome * 0.05;
            }
            else if (grossincome >= 100000)
            {
                phcon = 5000;
            }
            else
            {
                phcon = 0;
            }


            //income tax contribution value
            if (grossincome <= 250000)
            {
                incometaxcon = 0;
            }
            else if (grossincome > 250000 && grossincome < 400000)
            {
                incometaxcon = grossincome * 0.15;
            }
            else if (grossincome >= 400000 && grossincome < 800000)
            {
                incometaxcon = (grossincome * 0.20) + 22500;
            }
            else if (grossincome >= 800000 && grossincome < 2000000)
            {
                incometaxcon = (grossincome * 0.25) + 102500;
            }
            else if (grossincome >= 2000000 && grossincome < 8000000)
            {
                incometaxcon = (grossincome * 0.30) + 402500;
            }
            else
            {
                incometaxcon = (grossincome * 0.35) + 2202500;
            }


            pagibigcon = Convert.ToDouble(pagibig_con.Text);
            ssscon = Convert.ToDouble(sss_con.Text);

            totaldeduction = sssloan + pagibigloan + fsdeposit + fsloan + salaryloan + otherloan + pagibigcon + ssscon + incometaxcon + phcon;
            inc_con.Text = incometaxcon.ToString("0.00");
            ph_con.Text = phcon.ToString("0.00");
            total.Text = totaldeduction.ToString("0.00");
            netincome = grossincome - totaldeduction;
            net_income.Text = netincome.ToString("0.00");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            bi_rate.Text = "0.00";
            bi_hours.Text = "0.00";
            bi_income.Clear();
            hono_rate.Text = "0.00";
            hono_hours.Text = "0.00";
            hono_income.Clear();
            oth_rate.Text = "0.00";
            oth_hours.Text = "0.00";
            oth_income.Clear();
            gross_income.Clear();
            net_income.Clear();
            sss_loan.Text = "0.00";
            pagibig_loan.Text = "0.00";
            fs_deposit.Text = "0.00";
            fs_loan.Text = "0.00";
            salary_loan.Text = "0.00";
            other_loan.Text = "0.00";
            sss_con.Clear();
            ph_con.Clear();
            pagibig_con.Text = "200.00";
            inc_con.Clear();
            total.Clear();
            employee_num.Clear();
            department.Clear();
            first_name.Clear();
            middle_name.Clear();
            surname.Clear();
            civil_status.Clear();
            dependent.Clear();
            paydate.Clear();
            employee.Clear();
            desig.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
