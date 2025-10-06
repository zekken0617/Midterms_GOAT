using System.Diagnostics;

namespace Lesson7_E4
{
    public partial class Form1 : Form
    {
        private int qty;
        private double price, discount_amt, discounted_amt;

        private void Quantity_Text()
        {
            quantitytb.Clear();
            quantitytb.Focus();
        }
        private void quantity_price_Convert()
        {
            qty = Convert.ToInt32(quantitytb.Text);
            price = Convert.ToDouble(pricetb.Text);
        }
        private void Formula_and_DisplayData()
        {
            discounted_amt = (qty * price) - discount_amt;
            discounttb.Text = discount_amt.ToString("n");
            discountedtb.Text = discounted_amt.ToString("n");
        }

        private void price_item_TextValue(string itemname, string price)
        {
            itemnametb.Text = itemname;
            pricetb.Text = price;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\User\\Desktop\\4th_year\\DSAL01E\\MIDTERMS\\UPDATE1\\Midterms_GOAT\\MIDTERMS_LESSON6\\MainForm\\MainForm\\Resources\\ice1.png");
            pictureBox2.Image = Image.FromFile("C:\\Users\\User\\Desktop\\4th_year\\DSAL01E\\MIDTERMS\\UPDATE1\\Midterms_GOAT\\MIDTERMS_LESSON6\\MainForm\\MainForm\\Resources\\ice2.png");
            pictureBox3.Image = Image.FromFile("C:\\Users\\User\\Desktop\\4th_year\\DSAL01E\\MIDTERMS\\UPDATE1\\Midterms_GOAT\\MIDTERMS_LESSON6\\MainForm\\MainForm\\Resources\\ice3.png");
            pictureBox4.Image = Image.FromFile("C:\\Users\\User\\Desktop\\4th_year\\DSAL01E\\MIDTERMS\\UPDATE1\\Midterms_GOAT\\MIDTERMS_LESSON6\\MainForm\\MainForm\\Resources\\ice4.png");
            pictureBox5.Image = Image.FromFile("C:\\Users\\User\\Desktop\\4th_year\\DSAL01E\\MIDTERMS\\UPDATE1\\Midterms_GOAT\\MIDTERMS_LESSON6\\MainForm\\MainForm\\Resources\\ice5.png");
            pictureBox10.Image = Image.FromFile("C:\\Users\\User\\Desktop\\4th_year\\DSAL01E\\MIDTERMS\\UPDATE1\\Midterms_GOAT\\MIDTERMS_LESSON6\\MainForm\\MainForm\\Resources\\ice6.png");
            pictureBox9.Image = Image.FromFile("C:\\Users\\User\\Desktop\\4th_year\\DSAL01E\\MIDTERMS\\UPDATE1\\Midterms_GOAT\\MIDTERMS_LESSON6\\MainForm\\MainForm\\Resources\\ice7.png");
            pictureBox8.Image = Image.FromFile("C:\\Users\\User\\Desktop\\4th_year\\DSAL01E\\MIDTERMS\\UPDATE1\\Midterms_GOAT\\MIDTERMS_LESSON6\\MainForm\\MainForm\\Resources\\ice8.png");
            pictureBox7.Image = Image.FromFile("C:\\Users\\User\\Desktop\\4th_year\\DSAL01E\\MIDTERMS\\UPDATE1\\Midterms_GOAT\\MIDTERMS_LESSON6\\MainForm\\MainForm\\Resources\\ice9.png");
            pictureBox6.Image = Image.FromFile("C:\\Users\\User\\Desktop\\4th_year\\DSAL01E\\MIDTERMS\\UPDATE1\\Midterms_GOAT\\MIDTERMS_LESSON6\\MainForm\\MainForm\\Resources\\ice10.png");
            pictureBox15.Image = Image.FromFile("C:\\Users\\User\\Desktop\\4th_year\\DSAL01E\\MIDTERMS\\UPDATE1\\Midterms_GOAT\\MIDTERMS_LESSON6\\MainForm\\MainForm\\Resources\\ice11.png");
            pictureBox14.Image = Image.FromFile("C:\\Users\\User\\Desktop\\4th_year\\DSAL01E\\MIDTERMS\\UPDATE1\\Midterms_GOAT\\MIDTERMS_LESSON6\\MainForm\\MainForm\\Resources\\ice12.png");
            pictureBox13.Image = Image.FromFile("C:\\Users\\User\\Desktop\\4th_year\\DSAL01E\\MIDTERMS\\UPDATE1\\Midterms_GOAT\\MIDTERMS_LESSON6\\MainForm\\MainForm\\Resources\\ice13.png");
            pictureBox12.Image = Image.FromFile("C:\\Users\\User\\Desktop\\4th_year\\DSAL01E\\MIDTERMS\\UPDATE1\\Midterms_GOAT\\MIDTERMS_LESSON6\\MainForm\\MainForm\\Resources\\ice14.png");
            pictureBox11.Image = Image.FromFile("C:\\Users\\User\\Desktop\\4th_year\\DSAL01E\\MIDTERMS\\UPDATE1\\Midterms_GOAT\\MIDTERMS_LESSON6\\MainForm\\MainForm\\Resources\\ice15.png");
            pictureBox20.Image = Image.FromFile("C:\\Users\\User\\Desktop\\4th_year\\DSAL01E\\MIDTERMS\\UPDATE1\\Midterms_GOAT\\MIDTERMS_LESSON6\\MainForm\\MainForm\\Resources\\ice16.png");
            pictureBox19.Image = Image.FromFile("C:\\Users\\User\\Desktop\\4th_year\\DSAL01E\\MIDTERMS\\UPDATE1\\Midterms_GOAT\\MIDTERMS_LESSON6\\MainForm\\MainForm\\Resources\\ice17.png");
            pictureBox18.Image = Image.FromFile("C:\\Users\\User\\Desktop\\4th_year\\DSAL01E\\MIDTERMS\\UPDATE1\\Midterms_GOAT\\MIDTERMS_LESSON6\\MainForm\\MainForm\\Resources\\ice18.png");
            pictureBox17.Image = Image.FromFile("C:\\Users\\User\\Desktop\\4th_year\\DSAL01E\\MIDTERMS\\UPDATE1\\Midterms_GOAT\\MIDTERMS_LESSON6\\MainForm\\MainForm\\Resources\\ice19.png");
            pictureBox16.Image = Image.FromFile("C:\\Users\\User\\Desktop\\4th_year\\DSAL01E\\MIDTERMS\\UPDATE1\\Midterms_GOAT\\MIDTERMS_LESSON6\\MainForm\\MainForm\\Resources\\ice20.png");


        }

        private void quantitytb_TextChanged(object sender, EventArgs e)
        {

        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Oreo Oreo", "100");
            Quantity_Text();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Cookie Monster", "115");
            Quantity_Text();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Reese's and Bananas", "120");
            Quantity_Text();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Strawberry Cheesecake", "110");
            Quantity_Text();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Hella Chocolate", "100");
            Quantity_Text();

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Matcha Berry", "110");
            Quantity_Text();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Rasberry Berry", "120");
            Quantity_Text();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Birthday Cake", "110");
            Quantity_Text();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Taro Berry", "110");
            Quantity_Text();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Caramel Caramel", "105");
            Quantity_Text();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            price_item_TextValue("S'mores and Bears", "110");
            Quantity_Text();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Mangonada", "120");
            Quantity_Text();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Blended Berry", "125");
            Quantity_Text();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Pina Colada", "110");
            Quantity_Text();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Strawberry Smashed", "120");
            Quantity_Text();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Cinnamon Toast Crunch", "115");
            Quantity_Text();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Lucky Charms", "110");
            Quantity_Text();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Fruity Pebbles", "105");
            Quantity_Text();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Brownie Smashed", "115");
            Quantity_Text();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

            price_item_TextValue("Nutella and Bananas", "120");
            Quantity_Text();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            itemnametb.Clear();
            pricetb.Clear();
            quantitytb.Clear();
            discountedtb.Clear();
            discounttb.Clear();
            discount_totaltb.Clear();
            discounted_totaltb.Clear();
            qty_totaltb.Clear();


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                quantity_price_Convert();
                discount_amt = (qty * price) * 0.30;
                Formula_and_DisplayData();
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;
            }

            catch (Exception)
            {
                {
                    MessageBox.Show("Please enter a valid quantity.");
                    Quantity_Text();
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                quantity_price_Convert();
                discount_amt = (qty * price) * 0.30;
                Formula_and_DisplayData();
                radioButton1.Enabled = false;
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;
            }

            catch (Exception)
            {
                {
                    MessageBox.Show("Please enter a valid quantity.");
                    Quantity_Text();
                }
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                quantity_price_Convert();
                discount_amt = (qty * price) * 0.15;
                Formula_and_DisplayData();
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton4.Enabled = false;
            }

            catch (Exception)
            {
                {
                    MessageBox.Show("Please enter a valid quantity.");
                    Quantity_Text();
                }
            }
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                quantity_price_Convert();
                discount_amt = (qty * price) * 0;
                Formula_and_DisplayData();
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
            }

            catch (Exception)
            {
                {
                    MessageBox.Show("Please enter a valid quantity.");
                    Quantity_Text();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int qty_total;
            qty_total = Convert.ToInt32(quantitytb.Text);
            qty_totaltb.Text = qty_total.ToString();

            double discount_total, discounted_total;
            discount_total = Convert.ToDouble(discountedtb.Text);
            discounted_totaltb.Text = discount_total.ToString("n");
            discounted_total = Convert.ToDouble(discounttb.Text);
            discount_totaltb.Text = discounted_total.ToString("n");

        }
    }
}
