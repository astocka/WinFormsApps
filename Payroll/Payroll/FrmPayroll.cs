using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll
{
    public partial class FrmPayroll : Form
    {
        public FrmPayroll()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            string employeeName;
            double rateOfPay;
            double hoursWorked;
            double grossPay;
            double taxes;
            const double tax = 0.20;
            double netPay;

            try
            {
                employeeName = TxtName.Text;
                rateOfPay = double.Parse(TxtRateOfPay.Text);
                hoursWorked = double.Parse(TxtHoursWorked.Text);

                grossPay = rateOfPay * hoursWorked;
                taxes = grossPay * tax;
                netPay = grossPay - taxes;

                LblEmployeeToPayDisplay.Text = employeeName;
                TxtGrossPay.Text = grossPay.ToString();
                TxtTaxes.Text = taxes.ToString();
                TxtNetPay.Text = netPay.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong data. Please try again.");
                BtnClear.PerformClick();
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtName.Clear();
            TxtRateOfPay.Clear();
            TxtHoursWorked.Clear();
            LblEmployeeToPayDisplay.Text = "";
            TxtGrossPay.Clear();
            TxtTaxes.Clear();
            TxtNetPay.Clear();
        }
    }
}
