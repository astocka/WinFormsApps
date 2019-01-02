using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafeteria
{
    public partial class FrmCafeteria : Form
    {
        public FrmCafeteria()
        {
            InitializeComponent();
        }

        double soup, salad, chicken, lasagne, steak, pop, water, juice;
        double appetizer, main, refreshment, subtotal, tax, total;

        private void FrmCafeteria_Load(object sender, EventArgs e)
        {
            soup = 2;
            salad = 2.5;
            chicken = 10.50;
            lasagne = 11.75;
            steak = 15;
            pop = 1.25;
            water = 1;
            juice = 1.30;

            appetizer = 0;
            main = 0;
            refreshment = 0;
            subtotal = 0;
            tax = 0;
            total = 0;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNewOrder_Click(object sender, EventArgs e)
        {
            RdoSoup.Checked = false;
            RdoSalad.Checked = false;
            RdoChicken.Checked = false;
            RdoLasagne.Checked = false;
            RdoSteak.Checked = false;
            RdoPop.Checked = false;
            RdoWater.Checked = false;
            RdoJuice.Checked = false;

            TxtApetizer.Clear();
            TxtMain.Clear();
            TxtRefreshment.Clear();
            TxtSubtotal.Clear();
            TxtTax.Clear();
            TxtTotal.Clear();

            appetizer = 0;
            main = 0;
            refreshment = 0;
            subtotal = 0;
            tax = 0;
            total = 0;
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            subtotal = appetizer + main + refreshment;
            tax = subtotal * 0.13;
            total = subtotal + tax;

            TxtSubtotal.Text = subtotal.ToString("c");
            TxtTax.Text = tax.ToString("c");
            TxtTotal.Text = total.ToString("c");
        }

        private void RdoSteak_CheckedChanged(object sender, EventArgs e)
        {
            TxtMain.Text = steak.ToString("c");
            main = steak;
        }

        private void RdoPop_CheckedChanged(object sender, EventArgs e)
        {
            TxtRefreshment.Text = pop.ToString("c");
            refreshment = pop;
        }

        private void RdoWater_CheckedChanged(object sender, EventArgs e)
        {
            TxtRefreshment.Text = water.ToString("c");
            refreshment = water;
        }

        private void RdoJuice_CheckedChanged(object sender, EventArgs e)
        {
            TxtRefreshment.Text = juice.ToString("c");
            refreshment = juice;
        }

        private void RdoLasagne_CheckedChanged(object sender, EventArgs e)
        {
            TxtMain.Text = lasagne.ToString("c");
            main = lasagne;
        }

        private void RdoChicken_CheckedChanged(object sender, EventArgs e)
        {
            TxtMain.Text = chicken.ToString("c");
            main = chicken;
        }

        private void RdoSalad_CheckedChanged(object sender, EventArgs e)
        {
            TxtApetizer.Text = salad.ToString("c");
            appetizer = salad;
        }

        private void RdoSoup_CheckedChanged(object sender, EventArgs e)
        {
            TxtApetizer.Text = soup.ToString("c");
            appetizer = soup;
        }
    }
}
