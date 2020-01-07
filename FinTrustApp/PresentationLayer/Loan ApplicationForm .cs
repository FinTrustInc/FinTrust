using FinTrustBLL.BusinessLayer;
using FinTrustDTO.DTO;
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
   
        private void label5_Click(object sender, EventArgs e)
        {

        }

        //----------------- Action for Customer Id change -------------------------

        private void textBoxcustomerid_TextChanged(object sender, EventArgs e)
        {
            Customer customerObj = null;
            try
            {

                customerObj = 
                    LoanBL.GetCustomerById(textBoxCustomerId.Text);
                if (customerObj != null)
                {
                    textBoxName.Text = customerObj.CustomerName;
                    textBoxAccountNumber.Text= customerObj.AccountNumber;
                }

            }
            catch (Exception ex)
            {
               Console.WriteLine(ex.Message.ToString());
            }
        }

        //---------------- Action for status Combo Box selection change ---------------------------

        private void checkBoxLoanApplicationDeclaration_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLoanApplicationDeclaration.Checked)
            {
                if (textBoxLoanAmount.Text == string.Empty || comboBoxLoanType.SelectedIndex==-1 || textBoxGuarantor.Text == string.Empty || textBoxTerm.Text == string.Empty)
                {
                    checkBoxLoanApplicationDeclaration.Checked = false;
                    buttonsubmit.Enabled = false;
                }
                else
                {
                    buttonsubmit.Enabled = true;
                }
            }
            else
            {
                buttonsubmit.Enabled = false;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        //---------------- Action for submit button ---------------------------

        private void buttonsubmit_Click(object sender, EventArgs e)
        {
             Loan loanObj = null;
            int output = 0;
           
                try
                {

                    loanObj = new Loan();
                    loanObj.LoanId = LoanBL.GetNewLoanId();
                    loanObj.CustomerId = textBoxCustomerId.Text;
                    loanObj.LoanType = comboBoxLoanType.Text;
                    loanObj.LoanAmount = Convert.ToDouble(textBoxLoanAmount.Text);
                    loanObj.InterestRate = 0.1;
                    loanObj.Term = Convert.ToInt32(textBoxTerm.Text);
                    loanObj.NetAmount = loanObj.LoanAmount * (1 + loanObj.InterestRate);
                    loanObj.GuarantorName = textBoxGuarantor.Text;
                    loanObj.Status = "Submitted";
                    DateTime today = DateTime.Today;
                    loanObj.Date = today.ToString();
                    
                    output = LoanBL.InsertLoanDetails(loanObj);

                    if (output > 0)
                    {

                        lblLoanMessage.Text = "Loan Applied Successfully!";

                    }
                    else
                    {
                        lblLoanMessage.Text = "Failed! Please Try Again.";
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message.ToString());
                }
            

        }

      
        //--------------------- Action for Back Button ------------------------

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Utility.GetLastPage();
        }

        //--------------------- Validation ------------------------------

        private void textBoxLoanAmount_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxLoanAmount.Text == string.Empty)
            {
                errorProviderLoanApplication.SetError(textBoxLoanAmount, "Loan amount required !");
            }
            else if (!long.TryParse(textBoxLoanAmount.Text, out long result))
            {
                errorProviderLoanApplication.SetError(textBoxLoanAmount, "Loan amount should contain digits !");
            }
            else
            {
                errorProviderLoanApplication.SetError(textBoxLoanAmount, string.Empty);
            }
        }

        private void textBoxGuarantor_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxGuarantor.Text == string.Empty)
            {
                errorProviderLoanApplication.SetError(textBoxGuarantor, "Guarantor name required !");
            }
            else
            {
                errorProviderLoanApplication.SetError(textBoxGuarantor, string.Empty);
            }
        }

        private void textBoxTerm_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxTerm.Text == string.Empty)
            {
                errorProviderLoanApplication.SetError(textBoxTerm, "number of terms required !");
            }
            else if (!long.TryParse(textBoxTerm.Text, out long result))
            {
                errorProviderLoanApplication.SetError(textBoxTerm, "term should contain digits !");
            }
            else
            {
                errorProviderLoanApplication.SetError(textBoxTerm, string.Empty);
            }
        }

        private void comboBoxLoanType_Validating(object sender, CancelEventArgs e)
        {
            if (comboBoxLoanType.SelectedIndex == -1)
            {
                errorProviderLoanApplication.SetError(comboBoxLoanType, "Loan type required !");
            }
            else
            {
                errorProviderLoanApplication.SetError(comboBoxLoanType, string.Empty);
            }
        }
    }
}
