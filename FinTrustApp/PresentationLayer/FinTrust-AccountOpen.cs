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
    public partial class FinTrust_AccountOpen : Form
    {
        public FinTrust_AccountOpen()
        {
            InitializeComponent();
        }

        private void buttonAccountOpenSubmit_Click(object sender, EventArgs e)
        {
            int output = 0;
            Customer objCustomer = null;
            try
            {
                if (textBoxCustomerName.Text == string.Empty)
                {

                }
                else
                {
                    objCustomer = new Customer();
                    objCustomer.CustomerId = CustomerBL.GetNewCustomerId();
                    objCustomer.AccountNumber = CustomerBL.GetNewAccountNumber();
                    objCustomer.CustomerName = textBoxCustomerName.Text;
                    objCustomer.AccountType = comboBoxAccountType.Text;
                    objCustomer.DateOfBirth = dateTimePickerCustomerDOB.Value.ToString("MM-dd-yyyy");
                    if (radioButtonCustomerMale.Checked == true)
                    {
                        objCustomer.Gender = "Male";
                    }
                    else
                    {
                        objCustomer.Gender = "Female";
                    }                   
                    objCustomer.Phone = Convert.ToInt64(textBoxCustomerPhone.Text);
                    objCustomer.Email = textBoxCustomerEmail.Text;
                    objCustomer.Address = textBoxCustomerAddress.Text;
                    objCustomer.AadharNumber = Convert.ToInt64(textBoxCustomerAadhar.Text);
                    objCustomer.PanNumber = textBoxCustomerPanNumber.Text;
                    DateTime today = DateTime.Today;
                    objCustomer.DateOfAccount = today.ToString();
                    output = CustomerBL.InsertCustomerDetails(objCustomer);
                    if (output < 0)
                    {
                        labelCustomerMessage.Text = "FAIL";
                    }
                    else
                    {
                        labelCustomerMessage.Text = "SUCCESS";
                    }
                }
            }
            catch(Exception ex)
            {

            }
            
        }

        private void checkBoxLoanApplication_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLoanApplication.Checked)
            {
                buttonAccountOpenSubmit.Visible = true;
            }
            else
            {
                buttonAccountOpenSubmit.Visible = false;
            }
        }
    }
}
