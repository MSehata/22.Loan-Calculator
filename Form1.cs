using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22.Loan_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CenterToParent();
            Opacity = 0.95;
        }

        private void btnMortgage_Click(object sender, EventArgs e)
        {
            double loanAmount = 0.0;
            double downPayment = 0.0;
            double interestRate = 0.0;
            double monthlyPayment = 0.0;
            int term = 0;

            if (!String.IsNullOrEmpty(txtLoanAmount.Text))
                loanAmount = Convert.ToDouble(txtLoanAmount.Text);

            if (!String.IsNullOrEmpty(txtDownPayment.Text))
                downPayment = Convert.ToDouble(txtDownPayment.Text);

            if (!String.IsNullOrEmpty(txtInterestRate.Text))
                interestRate = Convert.ToDouble(txtInterestRate.Text);

            if (!String.IsNullOrEmpty(txtTerm.Text))
                term = Convert.ToInt32(txtTerm.Text);

            int termsinMonths = term * 12;

            monthlyPayment = (loanAmount - downPayment) * (Math.Pow((1 + interestRate / 12),termsinMonths)
                * interestRate) / (12 * (Math.Pow((1 + interestRate / 12), termsinMonths) - 1));

            monthlyPayment = Math.Round(monthlyPayment, 2);

            lblMonthlyPaymentAmount.Text = String.Format(monthlyPayment.ToString());


        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            double loanAmount = 0.0;
            double downPayment = 0.0;
            double interestRate = 0.0;
            double monthlyPayment = 0.0;
            int term = 0;

            if (!String.IsNullOrEmpty(txtLoanAmount.Text))
                loanAmount = Convert.ToDouble(txtLoanAmount.Text);

            if (!String.IsNullOrEmpty(txtDownPayment.Text))
                downPayment = Convert.ToDouble(txtDownPayment.Text);

            if (!String.IsNullOrEmpty(txtInterestRate.Text))
                interestRate = Convert.ToDouble(txtInterestRate.Text);
            
            if (!String.IsNullOrEmpty(txtTerm.Text))
                term = Convert.ToInt32(txtTerm.Text);

            int termsinMonths = term * 12; interestRate /= 12;
            monthlyPayment = (interestRate * loanAmount) / (1 - Math.Pow(1 + interestRate, termsinMonths *
           -1));

            monthlyPayment = Math.Round(monthlyPayment, 2);

            lblMonthlyPaymentAmount.Text = String.Format(monthlyPayment.ToString());
        }
    }
}
