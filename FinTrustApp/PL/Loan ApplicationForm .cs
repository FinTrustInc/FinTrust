using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinTrustApp.PresentationLayer
{
    public partial class Loan_ApplicationForm : Form
    {
        public Loan_ApplicationForm()
        {
            InitializeComponent();
        }
        int  customerID,loanID, term,rateOInterest;
        double loanAmount;

        private void label5_Click(object sender, EventArgs e)
        {

        }

        string name, loanType,guarontor;

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void buttonsubmit_Click(object sender, EventArgs e)
        {
            try
            {
                rateOInterest = 10;
                name = textBoxname.Text;
                customerID = Convert.ToInt32(textBoxcustomerid.Text);
                loanType = comboBoxLoanType.Text;
                guarontor =textBoxGuarantor.Text;
                loanAmount = Convert.ToInt64(textBoxloanamount.Text);
                term = Convert.ToInt32(textBoxTerm.Text);
                loanID = 001;

                
               // emi = Math.Pow(loanAmount * interestRate * (1 * interestRate), loanTenure) / Math.Pow((1 + interestRate), loanTenure);
                
                ++loanID;
            }
            catch (Exception e2)
            {
                String titlename = " Loan Status ";
                MessageBox.Show("ERROR :"+ e2.Message.ToString(),titlename);
              
            }
        }
    }
}
