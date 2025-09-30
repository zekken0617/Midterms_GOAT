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
    public partial class POSInc : Form
    {
        public POSInc()
        {
            InitializeComponent();
        }

        private void POSInc_Load(object sender, EventArgs e)
        {
            itemnametb.Enabled = false;
            pricetb.Enabled = false;
            discountedtb.Enabled = false;
            qty_totaltb.Enabled = false;
            discount_totaltb.Enabled = false;
            discounted_totaltb.Enabled = false;
            changetb.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            itemnametb.Text = "Oreo Oreo";
            pricetb.Text = "100";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            itemnametb.Text = "Cookie Monster";
            pricetb.Text = "115";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            itemnametb.Text = "Reese's and Bananas";
            pricetb.Text = "120";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            itemnametb.Text = "Strawberry Cheesecake";
            pricetb.Text = "110";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            itemnametb.Text = "Hella Chocolate";
            pricetb.Text = "100";
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            itemnametb.Text = "Matcha Berry";
            pricetb.Text = "110";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            itemnametb.Text = "Rasberry Berry";
            pricetb.Text = "120";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            itemnametb.Text = "Birthday Cake";
            pricetb.Text = "110";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            itemnametb.Text = "Taro Berry";
            pricetb.Text = "110";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            itemnametb.Text = "Caramel Caramel";
            pricetb.Text = "105";
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            itemnametb.Text = "S'mores and Bears";
            pricetb.Text = "110";
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            itemnametb.Text = "Mangonada";
            pricetb.Text = "120";
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            itemnametb.Text = "Blended Berry";
            pricetb.Text = "125";
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            itemnametb.Text = "Pina Colada";
            pricetb.Text = "110";
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            itemnametb.Text = "Strawberry Smashed";
            pricetb.Text = "120";
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            itemnametb.Text = "Cinnamon Toast Crunch";
            pricetb.Text = "115";
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            itemnametb.Text = "Lucky Charms";
            pricetb.Text = "110";
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            itemnametb.Text = "Fruity Pebbles";
            pricetb.Text = "105";
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            itemnametb.Text = "Brownie Smashed";
            pricetb.Text = "115";
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            itemnametb.Text = "Nutella and Bananas";
            pricetb.Text = "120";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
