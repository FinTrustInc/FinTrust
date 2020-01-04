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
using System.Text.RegularExpressions;

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
                if (textBoxCustomerName.Text == string.Empty || comboBoxAccountType.SelectedIndex == -1 || dateTimePickerCustomerDOB.Text == string.Empty || textBoxCustomerEmail.Text == string.Empty || textBoxCustomerPhone.Text == string.Empty || textBoxCustomerAddress.Text == string.Empty || textBoxCustomerAadhar.Text == string.Empty || textBoxCustomerPanNumber.Text == string.Empty )
                {
                    foreach (Control control in this.Controls)
                    {
                        control.Focus();                                             // Set focus on control

                        if (!Validate())                                            // Validate causes the control's Validating event to be fired,if CausesValidation is True

                        {
                            DialogResult = DialogResult.None;
                            return;
                        }
                    }
                }

                //************************************************* INSERTING ACCOUNT DETAILS *****************************************

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
                    this.Hide();
                    Clerk ClerkHomeForm = new Clerk();
                    ClerkHomeForm.Show();

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

        //*********************************************** CHECKBOX CHECKING ****************************************************

        private void checkBoxLoanApplication_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAccountOpen.Checked)
            {
                if (textBoxCustomerName.Text == string.Empty || comboBoxAccountType.SelectedIndex == -1 || dateTimePickerCustomerDOB.Text == string.Empty || textBoxCustomerEmail.Text == string.Empty || textBoxCustomerPhone.Text == string.Empty || textBoxCustomerAddress.Text == string.Empty || textBoxCustomerAadhar.Text == string.Empty || textBoxCustomerPanNumber.Text == string.Empty)
                {
                    checkBoxAccountOpen.Checked = false;
                    buttonAccountOpenSubmit.Visible = false;
                }
                else
                {
                    buttonAccountOpenSubmit.Visible = true;
                }
            }                
            else
            {
                buttonAccountOpenSubmit.Visible = false;
            }
        }

        //************************************************** VALIDATING TEXTBOXES ***********************************************

        private void textBoxCustomerName_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxCustomerName.Text == string.Empty)
            {
                errorProviderAccountOpen.SetError(textBoxCustomerName, "Customer name required !");
            }
            else
            {
                errorProviderAccountOpen.SetError(textBoxCustomerName, string.Empty);
            }
        }

        private void comboBoxAccountType_Validating(object sender, CancelEventArgs e)
        {
            if (comboBoxAccountType.Text == string.Empty)
            {
                errorProviderAccountOpen.SetError(comboBoxAccountType, "Account type required !");
            }
            else
            {
                errorProviderAccountOpen.SetError(comboBoxAccountType, string.Empty);
            }
        }

        private void dateTimePickerCustomerDOB_Validating(object sender, CancelEventArgs e)
        {
            if (dateTimePickerCustomerDOB.Text == string.Empty)
            {
                errorProviderAccountOpen.SetError(dateTimePickerCustomerDOB, "Customer DOB required !");
            }
            else
            {
                errorProviderAccountOpen.SetError(dateTimePickerCustomerDOB, string.Empty);
            }
        }

        private void textBoxCustomerEmail_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(textBoxCustomerEmail.Text);
            if (textBoxCustomerEmail.Text == string.Empty)
            {
                errorProviderAccountOpen.SetError(textBoxCustomerEmail, "Customer email required !");
            }
            else if (!match.Success)
            {
                errorProviderAccountOpen.SetError(textBoxCustomerEmail, "Invalid email !");

            }
            else
            {
                errorProviderAccountOpen.SetError(textBoxCustomerEmail, string.Empty);
            }
        }

        private void textBoxCustomerAddress_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxCustomerAddress.Text == string.Empty)
            {
                errorProviderAccountOpen.SetError(textBoxCustomerAddress, "Customer address required !");
            }
            else
            {
                errorProviderAccountOpen.SetError(textBoxCustomerAddress, string.Empty);
            }
        }

        private void textBoxCustomerPhone_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxCustomerPhone.Text == string.Empty)
            {
                errorProviderAccountOpen.SetError(textBoxCustomerPhone, "Customer phone number required !");
            }
            else if ((textBoxCustomerPhone.Text.Length != 10) || (!long.TryParse(textBoxCustomerPhone.Text, out long result)))
            {
                errorProviderAccountOpen.SetError(textBoxCustomerPhone, "Enter valid phone number !");
            }
            else
            {
                errorProviderAccountOpen.SetError(textBoxCustomerPhone, string.Empty);
            }
        }

        private void textBoxCustomerAadhar_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxCustomerAadhar.Text == string.Empty)
            {
                errorProviderAccountOpen.SetError(textBoxCustomerAadhar, "Customer aadhar number required !");
            }
            else
            {
                errorProviderAccountOpen.SetError(textBoxCustomerAadhar, string.Empty);
            }
        }

        private void textBoxCustomerPanNumber_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxCustomerPanNumber.Text == string.Empty)
            {
                errorProviderAccountOpen.SetError(textBoxCustomerPanNumber, "Customer pan number required !");
            }
            else
            {
                errorProviderAccountOpen.SetError(textBoxCustomerPanNumber, string.Empty);
            }
        }
    }
}
