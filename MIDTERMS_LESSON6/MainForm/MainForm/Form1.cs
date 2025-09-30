namespace MainForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pOSCashierToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void simplePOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SimplePOS simplePOS_form = new SimplePOS();
            simplePOS_form.MdiParent = this;
            simplePOS_form.Show();
        }

        private void zekkePOSIncToolStripMenuItem_Click(object sender, EventArgs e)
        {
            POSInc posInc_form = new POSInc();
            posInc_form.MdiParent = this;
            posInc_form.Show();
        }

        private void zekkePOSOrderingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderingApp orderingApp_form = new OrderingApp();
            orderingApp_form.MdiParent = this;
            orderingApp_form.Show();
        }

        private void payrolToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void payrolApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PayrollApplication payrollApplication_form = new PayrollApplication();
            payrollApplication_form.MdiParent = this;
            payrollApplication_form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
