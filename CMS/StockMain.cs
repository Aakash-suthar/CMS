using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace CMS
{
    public partial class StockMain : MetroForm
    {
        Stock s;
        Products pro;

        public StockMain()
        {
            InitializeComponent();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (s == null)
            {
                s = new Stock();
                s.MdiParent = this;
                s.Show();
            }
             else  { s.Activate(); }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f = new Form1();
            f.Show();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            if (pro == null)
            {
                pro = new Products();
                pro.MdiParent = this;
                pro.Show();
            }
            else  { pro.Activate(); }
        }
    }
}
