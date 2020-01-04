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
                //lblMessage.Text = ex.Message.ToString();
            }
        }

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

        private void buttonsubmit_Click(object sender, EventArgs e)
        {
             Loan loanObj = null;
            int output = 0;
            if (LoanFormValidation())
            {
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
                        //lblMessage2.Text = "Failed! Please Try Again.";
                    }

                }
                catch (Exception ex)
                {
                    //lblMessage2.Text = ex.Message.ToString();
                }
            }

        }

        private bool LoanFormValidation()
        {
            bool flag = true;
           
            //if (textBoxName.Text == "")
            //{
            //    lblMessage2.Text = "Please Enter the Name";
            //    flag = false;
            //}
            //else if (!(radioMale.Checked || radioFemale.Checked))
            //{
            //    lblMessage2.Text = "Please select your gender.";
            //    flag = false;
            //}
            //else if (txtMobile.Text.Length != 10 || !int.TryParse(txtMobile.Text, out int result))
            //{
            //    lblMessage2.Text = "Invalid Mobile Number.";
            //    flag = false;
            //}
            //else if (!match.Success)
            //{
            //    lblMessage2.Text = "Invalid Email Address.";
            //    flag = false;
            //}
            return flag;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Utility.GetLastPage();
        }

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
