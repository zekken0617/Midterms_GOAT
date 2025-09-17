using System.Diagnostics;

namespace ChoicePayroll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private void label37_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            double sssloan, pagibigloan, fsdeposit, fsloan, salaryloan, otherloan,
                totaldeduction, netincome, grossincome,
                phcon, pagibigcon, ssscon, incometaxcon,
                regularss, mpf;

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

            //sss contribution value - regularss
            if (grossincome >= 19750 && grossincome < 24749.99)
            {
                regularss = 1000;
                mpf = 250;
                ssscon = regularss + mpf;
            }
            else if (grossincome >= 19250 && grossincome < 20249.99)
            {
                regularss = 975; ssscon = regularss;
            }
            else if (grossincome >= 18750 && grossincome < 19249.99)
            {
                regularss = 950; ssscon = regularss;
            }
            else if (grossincome >= 18250 && grossincome < 18749.99)
            {
                regularss = 925; ssscon = regularss;
            }
            else if (grossincome >= 17750 && grossincome < 18249.99)
            {
                regularss = 900; ssscon = regularss;
            }
            else if (grossincome >= 17250 && grossincome < 17549.99)
            {
                regularss = 875; ssscon = regularss;
            }
            else if (grossincome >= 16750 && grossincome < 17249.99)
            {
                regularss = 850; ssscon = regularss;
            }
            else if (grossincome >= 16250 && grossincome < 16749.99)
            {
                regularss = 825; ssscon = regularss;
            }
            else if (grossincome >= 15750 && grossincome < 16249.99)
            {
                regularss = 800; ssscon = regularss;
            }
            else if (grossincome >= 15250 && grossincome < 15549.99)
            {
                regularss = 775; ssscon = regularss;
            }
            else if (grossincome >= 14750 && grossincome < 15249.99)
            {
                regularss = 750; ssscon = regularss;
            }
            else if (grossincome >= 5250 && grossincome < 14749.99)
            {
                regularss = 250; ssscon = regularss;
            }
            else if (grossincome >= 0 && grossincome < 5249.99)
            {
                regularss = 0; ssscon = regularss;
            }
            else
            {
                regularss = 1000;
                mpf = 750;
                ssscon = regularss + mpf;
            }

            //sss contribution value - mpf

            pagibigcon = Convert.ToDouble(pagibig_con.Text);

            totaldeduction = sssloan + pagibigloan + fsdeposit + fsloan + salaryloan + otherloan + pagibigcon + ssscon + incometaxcon + phcon;
            inc_con.Text = incometaxcon.ToString("0.00");
            ph_con.Text = phcon.ToString("0.00");
            total.Text = totaldeduction.ToString("0.00");
            netincome = grossincome - totaldeduction;
            net_income.Text = netincome.ToString("0.00");
            sss_con.Text = ssscon.ToString("0.00");
        }

        private void button4_Click(object sender, EventArgs e)
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
            designation.Clear();
        }


        private void button6_Click_1(object sender, EventArgs e)
        {
            Form1_SAVE payrollSlip = new Form1_SAVE();

            // Transfer basic employee information
            payrollSlip.txt_company.Text = "Lyceum of the Philippines University Cavite";
            payrollSlip.txt_empcode.Text = employee_num.Text;
            payrollSlip.txt_department.Text = "College of Engineering, Computer Studies and Architecture";
            payrollSlip.txt_cutoff.Text = paydate.Text;
            payrollSlip.txt_cutoff.Text = paydate.Text;

            // Combine employee name (First, Middle, Last)
            string fullName = first_name.Text.Trim() + ", " + middle_name.Text.Trim() + " " + surname.Text.Trim();
            payrollSlip.txt_empname.Text = fullName;

            // Transfer earnings data
            payrollSlip.txt_basicpay.Text = bi_income.Text;
            payrollSlip.txt_overtime.Text = oth_income.Text;
            payrollSlip.txt_honorarium.Text = hono_income.Text;
            payrollSlip.txt_honoadjust.Text = "0.00"; // Static value
            payrollSlip.txt_substitution.Text = "0.00"; // Static value
            payrollSlip.txt_tardy.Text = "0.00"; // Static value
            payrollSlip.txt_earnings_total.Text = gross_income.Text;

            // Transfer deductions data
            payrollSlip.txt_withtax.Text = inc_con.Text;
            payrollSlip.txt_sss.Text = sss_con.Text;
            payrollSlip.txt_hdmf.Text = pagibig_con.Text;
            payrollSlip.txt_philhealth.Text = ph_con.Text;
            payrollSlip.txt_ssswisp.Text = "750.00"; // Static value
            payrollSlip.txt_deductions_total.Text = total.Text;

            // Transfer summary data
            payrollSlip.txt_grossearnings.Text = gross_income.Text;
            payrollSlip.txt_totaldeductions.Text = total.Text;
            payrollSlip.txt_netpay.Text = net_income.Text;

            // Show the payroll slip window
            payrollSlip.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
          
        }
    }
}

