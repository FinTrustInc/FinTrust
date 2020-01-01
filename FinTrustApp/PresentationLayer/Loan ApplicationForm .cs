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

                customerObj = LoanBL.GetCustomerById(textBoxCustomerId.Text);
                if (customerObj != null)
                {
                    textBoxName.Text = customerObj.CustomerName;
                
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
                buttonsubmit.Visible = true;
            }
            else
            {
                buttonsubmit.Visible = false;
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


    }
}
