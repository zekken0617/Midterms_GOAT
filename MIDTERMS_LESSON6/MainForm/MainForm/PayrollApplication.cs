using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class PayrollApplication : Form
    {
        //declaration of global variables
        private string picpath;
        private Double basic_netincome = 0.00,
                basic_numhrs = 0.00,
                basic_rate = 0.00,
                hono_netincome = 0.00,
                hono_numhrs = 0.00,
                hono_rate = 0.00,
                other_netincome = 0.00,
                other_numhrs = 0.00,
                other_rate = 0.00;
        private Double netincome = 0.00,
                grossincome = 0.00,
                sss_contrib = 0.00,
                pagibig_contrib = 0.00,
                philhealth_contrib = 0.00,
                tax_contrib = 0.00;

        private Double sss_loan = 0.00,
                pagibig_loan = 0.00,
                salary_loan = 0.00,
                salary_savings = 0.00,
                faculty_sav_loan = 0.00,
                other_deduction = 0.00,
                total_deduction = 0.00,
                total_contrib = 0.00,
                total_loan = 0.00;
        public PayrollApplication()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //codes for disabling
            basic_netincomeTxtbox.Enabled = false;
            hono_netincomeTxtbox.Enabled = false;
            other_netincomeTxtbox.Enabled = false;
            net_incomeTxtbox.Enabled = false;
            gross_incomeTxtbox.Enabled = false;
            total_deducTxtbox.Enabled = false;
            sss_contribTxtbox.Text = "0.00";
            pagibig_contribTxtbox.Text = "0.00";
            philhealth_contribTxtbox.Text = "0.00";
            tax_contribTxtbox.Text = "0.00";
            sss_loanTxtbox.Text = "0.00";
            pagibig_loanTxtbox.Text = "0.00";
            FSD_depositTxtbox.Text = "0.00";
            FS_loanTxtbox.Text = "0.00";
            sal_loanTxtbox.Text = "0.00";
            otherLoanTxtbox.Text = "0.00";
            others_loanCombo.Text = "Select other deduction";
            others_loanCombo.Items.Add("Other 1");
            others_loanCombo.Items.Add("Other 2");
            others_loanCombo.Items.Add("Other 3");
            others_loanCombo.Items.Add("Other 4");
            picpathTxtbox.Hide();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            // CALCULATE button:
            //codes for converting input data from textboxes as string to numeric
            //codes for putting data from textboxes to variables
            double sss_contrib,
                pagibig_contrib,
                philhealth_contrib,
                tax_contrib,
                sss_loan,
                pagibig_loan,
                sal_loan,
                FS_loan,
                FSD_deposit,
                otherLoan,
                grossincome = 0,
                net_income,
                total_deduction,
                total_contrib,
                total_loan;
            sss_contrib = Convert.ToDouble(sss_contribTxtbox.Text);
            pagibig_contrib = Convert.ToDouble(pagibig_contribTxtbox.Text);
            philhealth_contrib = Convert.ToDouble(philhealth_contribTxtbox.Text);
            tax_contrib = Convert.ToDouble(tax_contribTxtbox.Text);
            sss_loan = Convert.ToDouble(sss_loanTxtbox.Text);
            pagibig_loan = Convert.ToDouble(pagibig_loanTxtbox.Text);
            sal_loan = Convert.ToDouble(sal_loanTxtbox.Text);
            FS_loan = Convert.ToDouble(FS_loanTxtbox.Text);
            FSD_deposit = Convert.ToDouble(FSD_depositTxtbox.Text);
            otherLoan = Convert.ToDouble(otherLoanTxtbox.Text);
            //formula to compute the desired data to be computed
            total_contrib = sss_contrib + pagibig_contrib + philhealth_contrib +
                    tax_contrib;
            total_loan = sss_loan + pagibig_loan + sal_loan + FS_loan +
                    FSD_deposit + otherLoan;
            total_deduction = total_contrib + total_loan;
            //codes for converting numeric data to string and displayed it inside the 
            //        textboxes
            total_deducTxtbox.Text = total_deduction.ToString("n");
            net_income = grossincome - total_deduction;
            net_incomeTxtbox.Text = net_income.ToString("n");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // PREVIEW PAYSLIP button:
            //payslip_viewListBox.Items.Add("");
            payslip_viewListBox.Items.Add("Employee Number: " + " " + emp_nuTxtbox.Text);


            payslip_viewListBox.Items.Add("Firstname: " + " " + firstnameTxtbox.Text);


            payslip_viewListBox.Items.Add("Middlename: " + " " + MNameTxtbox.Text);


            payslip_viewListBox.Items.Add("Surname: " + " " + surTxtbox.Text);


            payslip_viewListBox.Items.Add("Designation: " + " " + desigTxtbox.Text);


            payslip_viewListBox.Items.Add("Employee Status: " + " " + empstatusTxtbox.Text);


            payslip_viewListBox.Items.Add("Department: " + " " + DeptNameTxtbox.Text);


            payslip_viewListBox.Items.Add("Pay Date: " + " " + paydateDatetimePicker.Text);


            payslip_viewListBox.Items.Add("----------------------------------");
            payslip_viewListBox.Items.Add("BP Num. of Hrs.: " + " " + basic_numhrsTxtbox.Text);


            payslip_viewListBox.Items.Add("BP Rate / Hr.: " + " " + basic_rateTxtbox.Text);


            payslip_viewListBox.Items.Add("Basic Pay Income " + " " + basic_netincomeTxtbox.Text);


            payslip_viewListBox.Items.Add("");
            payslip_viewListBox.Items.Add("HI Num. of Hrs.: " + " " + hono_netincomeTxtbox.Text);


            payslip_viewListBox.Items.Add("HI Rate / Hr.: " + " " + hono_netincomeTxtbox.Text);


            payslip_viewListBox.Items.Add("Honorarium Income " + " " + hono_netincomeTxtbox.Text);


            payslip_viewListBox.Items.Add("");
            payslip_viewListBox.Items.Add("OTI Num. of Hrs.: " + " " + other_numhrsTxtbox.Text);


            payslip_viewListBox.Items.Add("OTI Rate / Hr.: " + " " + other_rateTxtbox.Text);


            payslip_viewListBox.Items.Add("Other Income " + " " + other_netincomeTxtbox.Text);


            payslip_viewListBox.Items.Add("----------------------------------");
            payslip_viewListBox.Items.Add("SSS Contribution: " + " " + sss_contribTxtbox.Text);


            payslip_viewListBox.Items.Add("PhilHealth Contribution " + " " + philhealth_contribTxtbox.Text);


            payslip_viewListBox.Items.Add("Pagibig Contribution: " + " " + pagibig_contribTxtbox.Text);


            payslip_viewListBox.Items.Add("Tax Contribution: " + " " + tax_contribTxtbox.Text);


            payslip_viewListBox.Items.Add("SSS Loan: " + " " + sss_loanTxtbox.Text);


            payslip_viewListBox.Items.Add("Pagibig Loan: " + " " + pagibig_loanTxtbox.Text);


            payslip_viewListBox.Items.Add("Faculty Savings Deposit: " + " " + FSD_depositTxtbox.Text);


            payslip_viewListBox.Items.Add("Faculty Savings Loan: " + " " + FS_loanTxtbox.Text);


            payslip_viewListBox.Items.Add("Salary Loan: " + " " + sal_loanTxtbox.Text);


            payslip_viewListBox.Items.Add("Other Loan: " + " " + otherLoanTxtbox.Text);


            payslip_viewListBox.Items.Add("----------------------------------");
            payslip_viewListBox.Items.Add("Total Deduction: " + " " + total_deducTxtbox.Text);


            payslip_viewListBox.Items.Add("Gross Income: " + " " + gross_incomeTxtbox.Text);


            payslip_viewListBox.Items.Add("Net Income: " + " " + net_incomeTxtbox.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // PRINT PAYSLIP button:
            //codes for calling the other form connected to the current form
            Payroll_PrintForm payroll_Form = new Payroll_PrintForm();
            //codes for displaying the contents of the listbox from other form to the
            //       current form.
            payroll_Form.priDisplayListbox.Items.AddRange(payslip_viewListBox.Items);
            //code for displaying the other form
            payroll_Form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // EXIT button:
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // NEW and CANCEL button:
            //codes for clearing the textboxes
            emp_nuTxtbox.Clear();
            firstnameTxtbox.Clear();
            MNameTxtbox.Clear();
            surTxtbox.Clear();
            civil_statusTxtbox.Clear();
            desigTxtbox.Clear();
            numDependentTxtbox.Clear();
            empstatusTxtbox.Clear();
            DeptNameTxtbox.Clear();
            basic_netincomeTxtbox.Clear();
            basic_numhrsTxtbox.Clear();
            basic_rateTxtbox.Clear();
            hono_netincomeTxtbox.Clear();
            hono_numhrsTxtbox.Clear();
            hono_rateTxtbox.Clear();
            other_netincomeTxtbox.Clear();
            other_numhrsTxtbox.Clear();
            other_rateTxtbox.Clear();
            net_incomeTxtbox.Clear();
            gross_incomeTxtbox.Clear();
            sss_contribTxtbox.Clear();
            pagibig_contribTxtbox.Clear();
            philhealth_contribTxtbox.Clear();
            tax_contribTxtbox.Clear();
            sss_loanTxtbox.Clear();
            pagibig_loanTxtbox.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // NEW and CANCEL button:
            //codes for clearing the textboxes
            emp_nuTxtbox.Clear();
            firstnameTxtbox.Clear();
            MNameTxtbox.Clear();
            surTxtbox.Clear();
            civil_statusTxtbox.Clear();
            desigTxtbox.Clear();
            numDependentTxtbox.Clear();
            empstatusTxtbox.Clear();
            DeptNameTxtbox.Clear();
            basic_netincomeTxtbox.Clear();
            basic_numhrsTxtbox.Clear();
            basic_rateTxtbox.Clear();
            hono_netincomeTxtbox.Clear();
            hono_numhrsTxtbox.Clear();
            hono_rateTxtbox.Clear();
            other_netincomeTxtbox.Clear();
            other_numhrsTxtbox.Clear();
            other_rateTxtbox.Clear();
            net_incomeTxtbox.Clear();
            gross_incomeTxtbox.Clear();
            sss_contribTxtbox.Clear();
            pagibig_contribTxtbox.Clear();
            philhealth_contribTxtbox.Clear();
            tax_contribTxtbox.Clear();
            sss_loanTxtbox.Clear();
            pagibig_loanTxtbox.Clear();
        }

        private void basic_numhrsTxtbox_TextChanged(object sender, EventArgs e)
        {
            basic_numhrs = Double.Parse(basic_numhrsTxtbox.Text);
        }

        private void basic_rateTxtbox_TextChanged(object sender, EventArgs e)
        {
            basic_rate = Convert.ToDouble(basic_rateTxtbox.Text);
        }

        private void basic_netincomeTxtbox_TextChanged(object sender, EventArgs e)
        {

            basic_netincome = basic_numhrs * basic_rate;
            basic_netincomeTxtbox.Text = basic_netincome.ToString("n");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // BROWSE button:
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image File | *.gif; *.jpg; *.png; *.bmp";
            openFileDialog.Title = " Select Employee Picture";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picpath = openFileDialog.FileName;
                picpathTxtbox.Text = picpath;
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void PayrollApplication_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.RosyBrown;
        }
    }
}
