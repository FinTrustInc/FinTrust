using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinTrustDTO.DTO;
using FinTrustBLL.BusinessLayer;

namespace FinTrustApp.PresentationLayer
{
    public partial class FinTrust_AccountClose : Form
    {
        public FinTrust_AccountClose()
        {
            InitializeComponent();
        }
        //********************************* CHEKBOX CHECKING **********************************************

        private void checkBoxAccountClosure_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAccountClosure.Checked)
            {
                buttonAccountClosureSubmit.Visible = true;
            }
            else
            {
                buttonAccountClosureSubmit.Visible = false;
            }
        }

        private void buttonAccountNumberSearch_Click(object sender, EventArgs e)
        {
            Customer customerObj = null;
            try
            {

                customerObj = CustomerBL.GetCustomerByAccountNumber(textBoxAccountNumber.Text);
                if (customerObj != null)
                {
                    textBoxCustomerName.Text = customerObj.CustomerName;
                    textBoxAccountType.Text = customerObj.AccountType;
                    textBoxCustomerEmail.Text = customerObj.Email;
                    textBoxCustomerPhone.Text = customerObj.Phone.ToString();


                }

            }
            catch (Exception ex)
            {
                //lblMessage.Text = ex.Message.ToString();
            }
        }

        //******************************** DELETING ACCOUNT DETAILS ******************************************

        private void buttonAccountClosureSubmit_Click(object sender, EventArgs e)
        {

            int output = 0;
            try
            {
                if (MessageBox.Show("Do you want to delete", " S I S",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    output = CustomerBL.DeleteAccountDetails(textBoxAccountNumber.Text);

                    string Title = "Account Handling";
                    if (output > 0)
                    {
                        MessageBox.Show("Account deleted successfully !!!",Title);
                       
                    }
                    else
                    {
                        MessageBox.Show("Try again later !!!",Title);
                    }
                }

            }
            catch (Exception ex)
            {
                labelCustomerAccountCloseMessage.Text = ex.Message.ToString();
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Utility.GetLastPage();
        }
    }
}
