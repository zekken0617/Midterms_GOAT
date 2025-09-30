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
    public partial class OrderingApp : Form
    {
        public OrderingApp()
        {
            InitializeComponent();
        }

        private void OrderingApp_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.RosyBrown;
        }

        private void minionrbt_CheckedChanged(object sender, EventArgs e)
        {
            berryrbt.Checked = false;
            girlrbt.Checked = false;
            DisplayPictureBox.Image = Image.FromFile("C:\\Users\\C203-10\\source\\repos\\zekken0617\\KaiceCream\\Activity3\\bundleimages\\minion.png");

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

            textBox1.Text = "P315.00";
            textBox3.Text = "(10% of the Price) P35";
        }

        private void berryrbt_CheckedChanged(object sender, EventArgs e)
        {
            minionrbt.Checked = false;
            girlrbt.Checked = false;
            DisplayPictureBox.Image = Image.FromFile("C:\\Users\\C203-10\\source\\repos\\zekken0617\\KaiceCream\\Activity3\\bundleimages\\berry.png");

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

            textBox1.Text = "P395.00";
            textBox3.Text = "(15% of the Price) P70";
        }

        private void girlrbt_CheckedChanged(object sender, EventArgs e)
        {
            berryrbt.Checked = false;
            minionrbt.Checked = false;
            DisplayPictureBox.Image = Image.FromFile("C:\\Users\\C203-10\\source\\repos\\zekken0617\\KaiceCream\\Activity3\\bundleimages\\girl.png");


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

            textBox1.Text = "P297.00";
            textBox3.Text = "(10% of the Price) P33";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            berryrbt.Checked = false;
            minionrbt.Checked = false;
            girlrbt.Checked = false;
            DisplayPictureBox.Image = Image.FromFile("C:\\Users\\C203-10\\source\\repos\\zekken0617\\KaiceCream\\Activity3\\bundleimages\\white.png");

            b1.Checked = false;
            b2.Checked = false;
            b3.Checked = false;
            b4.Checked = false;

            g1.Checked = false;
            g2.Checked = false;
            g3.Checked = false;

            m1.Checked = false;
            m2.Checked = false;
            m3.Checked = false;

            textBox1.Clear();
            textBox3.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
