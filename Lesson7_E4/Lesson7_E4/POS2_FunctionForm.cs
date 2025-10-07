using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson7_E4
{
    public partial class POS2_FunctionForm : Form
    {
        private int qty;
        private double price, discount, discounted;

        private void Quantity_Text()
        {
            qtytb.Clear();
            qtytb.Focus();
        }

        private void quantity_price_Convert()
        {
            qty = Convert.ToInt32(qtytb.Text);
            price = Convert.ToDouble(pricetb.Text);
        }

        private void item_priceValue()
        {
            discount = Convert.ToDouble(discount_amt.Text);
            price = Convert.ToDouble(pricetb.Text);
        }
        private void Formula_and_DisplayData()
        {
            discounted = (qty * price) - discount;
            discount_amt.Text = discount.ToString("n");
            discounted_amt.Text = discounted.ToString("n");
        }

        public void item_priceValue(string p, string d)
        {
            pricetb.Text = p;
            discount_amt.Text = d;
        }
        public POS2_FunctionForm()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void POS2_FunctionForm_Load(object sender, EventArgs e)
        {
            pricetb.Enabled = false;
            discount_amt.Enabled = false;
            discounted_amt.Enabled = false;
            total_bills.Enabled = false;
            total_qty.Enabled = false;
            change.Enabled = false;
            cash.Enabled = true;

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = false;
            checkBox17.Checked = false;
            checkBox18.Checked = false;
            checkBox19.Checked = false;
            checkBox20.Checked = false;
            pictureBox1.Image = Image.FromFile("C:\\Users\\C203-10\\source\\repos\\zekken0617\\Midterms_GOAT\\MIDTERMS_LESSON6\\MainForm\\MainForm\\Resources\\ice1.png");
            pictureBox2.Image = Image.FromFile("C:\\Users\\C203-10\\source\\repos\\zekken0617\\Midterms_GOAT\\MIDTERMS_LESSON6\\MainForm\\MainForm\\Resources\\ice2.png");
            pictureBox3.Image = Image.FromFile("C:\\Users\\C203-10\\source\\repos\\zekken0617\\Midterms_GOAT\\MIDTERMS_LESSON6\\MainForm\\MainForm\\Resources\\ice3.png");
            pictureBox4.Image = Image.FromFile("C:\\Users\\C203-10\\source\\repos\\zekken0617\\Midterms_GOAT\\MIDTERMS_LESSON6\\MainForm\\MainForm\\Resources\\ice4.png");
            pictureBox5.Image = Image.FromFile("C:\\Users\\C203-10\\source\\repos\\zekken0617\\Midterms_GOAT\\MIDTERMS_LESSON6\\MainForm\\MainForm\\Resources\\ice5.png");
            pictureBox10.Image = Image.FromFile("C:\\Users\\C203-10\\source\\repos\\zekken0617\\Midterms_GOAT\\MIDTERMS_LESSON6\\MainForm\\MainForm\\Resources\\ice6.png");
            pictureBox9.Image = Image.FromFile("C:\\Users\\C203-10\\source\\repos\\zekken0617\\Midterms_GOAT\\MIDTERMS_LESSON6\\MainForm\\MainForm\\Resources\\ice7.png");
            pictureBox8.Image = Image.FromFile("C:\\Users\\C203-10\\source\\repos\\zekken0617\\Midterms_GOAT\\MIDTERMS_LESSON6\\MainForm\\MainForm\\Resources\\ice8.png");
            pictureBox7.Image = Image.FromFile("C:\\Users\\C203-10\\source\\repos\\zekken0617\\Midterms_GOAT\\MIDTERMS_LESSON6\\MainForm\\MainForm\\Resources\\ice9.png");
            pictureBox6.Image = Image.FromFile("C:\\Users\\C203-10\\source\\repos\\zekken0617\\Midterms_GOAT\\MIDTERMS_LESSON6\\MainForm\\MainForm\\Resources\\ice10.png");
            pictureBox15.Image = Image.FromFile("C:\\Users\\C203-10\\source\\repos\\zekken0617\\Midterms_GOAT\\MIDTERMS_LESSON6\\MainForm\\MainForm\\Resources\\ice11.png");
            pictureBox14.Image = Image.FromFile("C:\\Users\\C203-10\\source\\repos\\zekken0617\\Midterms_GOAT\\MIDTERMS_LESSON6\\MainForm\\MainForm\\Resources\\ice12.png");
            pictureBox13.Image = Image.FromFile("C:\\Users\\C203-10\\source\\repos\\zekken0617\\Midterms_GOAT\\MIDTERMS_LESSON6\\MainForm\\MainForm\\Resources\\ice13.png");
            pictureBox12.Image = Image.FromFile("C:\\Users\\C203-10\\source\\repos\\zekken0617\\Midterms_GOAT\\MIDTERMS_LESSON6\\MainForm\\MainForm\\Resources\\ice14.png");
            pictureBox11.Image = Image.FromFile("C:\\Users\\C203-10\\source\\repos\\zekken0617\\Midterms_GOAT\\MIDTERMS_LESSON6\\MainForm\\MainForm\\Resources\\ice15.png");
            pictureBox20.Image = Image.FromFile("C:\\Users\\C203-10\\source\\repos\\zekken0617\\Midterms_GOAT\\MIDTERMS_LESSON6\\MainForm\\MainForm\\Resources\\ice16.png");
            pictureBox19.Image = Image.FromFile("C:\\Users\\C203-10\\source\\repos\\zekken0617\\Midterms_GOAT\\MIDTERMS_LESSON6\\MainForm\\MainForm\\Resources\\ice17.png");
            pictureBox18.Image = Image.FromFile("C:\\Users\\C203-10\\source\\repos\\zekken0617\\Midterms_GOAT\\MIDTERMS_LESSON6\\MainForm\\MainForm\\Resources\\ice18.png");
            pictureBox17.Image = Image.FromFile("C:\\Users\\C203-10\\source\\repos\\zekken0617\\Midterms_GOAT\\MIDTERMS_LESSON6\\MainForm\\MainForm\\Resources\\ice19.png");
            pictureBox16.Image = Image.FromFile("C:\\Users\\C203-10\\source\\repos\\zekken0617\\Midterms_GOAT\\MIDTERMS_LESSON6\\MainForm\\MainForm\\Resources\\ìce20.png");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox21.Image = Image.FromFile("C:\\Users\\C203-10\\source\\repos\\KaiceCream\\Activity3\\bundleimages\\minion.png");
            radioButton2.Checked = false;
            radioButton3.Checked = false;


            m1.Checked = true;
            m2.Checked = true;
            m3.Checked = true;

            b1.Checked = false;
            b2.Checked = false;
            b3.Checked = false;
            b4.Checked = false;

            g1.Checked = false;
            g2.Checked = false;
            g3.Checked = false;

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = true;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = true;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = true;
            checkBox17.Checked = false;
            checkBox18.Checked = false;
            checkBox19.Checked = false;
            checkBox20.Checked = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox21.Image = Image.FromFile("C:\\Users\\C203-10\\source\\repos\\KaiceCream\\Activity3\\bundleimages\\berry.png");
            radioButton1.Checked = false;
            radioButton3.Checked = false;

            m1.Checked = false;
            m2.Checked = false;
            m3.Checked = false;

            b1.Checked = true;
            b2.Checked = true;
            b3.Checked = true;
            b4.Checked = true;

            g1.Checked = false;
            g2.Checked = false;
            g3.Checked = false;

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = true;
            checkBox8.Checked = false;
            checkBox9.Checked = true;
            checkBox10.Checked = true;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = true;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = false;
            checkBox17.Checked = false;
            checkBox18.Checked = false;
            checkBox19.Checked = false;
            checkBox20.Checked = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox21.Image = Image.FromFile("C:\\Users\\C203-10\\source\\repos\\KaiceCream\\Activity3\\bundleimages\\girl.png");
            radioButton1.Checked = false;
            radioButton2.Checked = false;

            m1.Checked = false;
            m2.Checked = false;
            m3.Checked = false;

            b1.Checked = false;
            b2.Checked = false;
            b3.Checked = false;
            b4.Checked = false;

            g1.Checked = true;
            g2.Checked = true;
            g3.Checked = true;

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = true;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = true;
            checkBox10.Checked = true;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = false;
            checkBox17.Checked = false;
            checkBox18.Checked = false;
            checkBox19.Checked = false;
            checkBox20.Checked = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = false;
            checkBox17.Checked = false;
            checkBox18.Checked = false;
            checkBox19.Checked = false;
            checkBox20.Checked = false;

            pictureBox21.Image = Image.FromFile("C:\\Users\\C203-10\\source\\repos\\KaiceCream\\Activity3\\bundleimages\\white.png");
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;

            m1.Checked = false;
            m2.Checked = false;
            m3.Checked = false;

            b1.Checked = false;
            b2.Checked = false;
            b3.Checked = false;
            b4.Checked = false;

            g1.Checked = false;
            g2.Checked = false;
            g3.Checked = false;
        }

        private void discount_totaltb_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "100.00");
            Quantity_Text();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "115.00");
            Quantity_Text();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "120.00");
            Quantity_Text();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "110.00");
            Quantity_Text();
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "110.00");
            Quantity_Text();
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "120.00");
            Quantity_Text();
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "110.00");
            Quantity_Text();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "100.00");
            Quantity_Text();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "110.00");
            Quantity_Text();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "105.00");
            Quantity_Text();
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "110.00");
            Quantity_Text();
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "110.00");
            Quantity_Text();
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "125.00");
            Quantity_Text();
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "110.00");
            Quantity_Text();
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "120.00");
            Quantity_Text();
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "115.00");
            Quantity_Text();
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "110.00");
            Quantity_Text();
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "105.00");
            Quantity_Text();
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "115.00");
            Quantity_Text();
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "120.00");
            Quantity_Text();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = false;
            checkBox17.Checked = false;
            checkBox18.Checked = false;
            checkBox19.Checked = false;
            checkBox20.Checked = false;

            pictureBox21.Image = Image.FromFile("C:\\Users\\C203-10\\source\\repos\\KaiceCream\\Activity3\\bundleimages\\white.png");
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;

            m1.Checked = false;
            m2.Checked = false;
            m3.Checked = false;

            b1.Checked = false;
            b2.Checked = false;
            b3.Checked = false;
            b4.Checked = false;

            g1.Checked = false;
            g2.Checked = false;
            g3.Checked = false;

            pricetb.Clear();
            qtytb.Clear();
            discount_amt.Clear();
            discounted_amt.Clear();
            total_bills.Clear();
            total_qty.Clear();
            cash.Clear();
            change.Clear();

            listBox1.Items.Clear();
        }
    }
}
