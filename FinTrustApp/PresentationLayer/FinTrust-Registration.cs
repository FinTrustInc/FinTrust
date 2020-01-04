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
    public partial class FinTrust_Registration : Form
    {
        public FinTrust_Registration()
        {
            InitializeComponent();
        }
        
        private void buttonUserRegister_Click(object sender, EventArgs e)
        {
            User objUser = null;
            int output = 0;

            try
            {
                if (textBoxEmployeeID.Text == string.Empty || textBoxEmployeeName.Text == string.Empty || comboBoxDesignation.SelectedIndex == -1 || textBoxEmployeePhone.Text == string.Empty || textBoxEmployeeEmail.Text == string.Empty || textBoxEmployeeAddress.Text == string.Empty || textBoxEmployeeAadhar.Text == string.Empty || textBoxtEmployeePAN.Text == string.Empty || !(radioButtonEmployeeFemale.Checked || radioButtonEmployeeMale.Checked))
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
                
                //************************************************* INSERTING USER DETAILS *****************************************
           
                else
                {
                    objUser = new User();

                    objUser.EmployeeId = textBoxEmployeeID.Text;
                    objUser.EmployeeName = textBoxEmployeeName.Text;
                    objUser.DateOfBirth = dateTimePickerEmployeeDOB.Value.ToString("MM-dd-yyyy");
                    if (radioButtonEmployeeMale.Checked == true)
                    {
                        objUser.Gender = "Male";
                    }
                    else
                    {
                        objUser.Gender = "Female";
                    }
                    objUser.Designation = comboBoxDesignation.Text;
                    objUser.Phone = Convert.ToInt64(textBoxEmployeePhone.Text);
                    objUser.Email = textBoxEmployeeEmail.Text;
                    objUser.Address = textBoxEmployeeAddress.Text;
                    objUser.AadharNumber = Convert.ToInt64(textBoxEmployeeAadhar.Text);
                    objUser.PanNumber = textBoxtEmployeePAN.Text;

                    output = FinTrustBL.InsertUserDetails(objUser);

                    string Title = "FinTrust Employee Registration";
                    if (output < 0)
                    {
                        MessageBox.Show("User Registration Failed",Title);
                    }
                    else
                    {
                        MessageBox.Show("User Registration Success",Title);
                        
                    }


                }
            }
            catch (Exception ex)
            {
                labelUserRegistrtionMessage.Text = ex.Message.ToString();
            }
        }

        //*********************************************** CHECKBOX CHECKING ****************************************************

        private void checkBoxUserRegister_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxUserRegister.Checked)
            {
                if(textBoxEmployeeID.Text == string.Empty || textBoxEmployeeName.Text == string.Empty || comboBoxDesignation.SelectedIndex ==-1  || textBoxEmployeePhone.Text == string.Empty || textBoxEmployeeEmail.Text == string.Empty || textBoxEmployeeAddress.Text == string.Empty || textBoxEmployeeAadhar.Text == string.Empty || textBoxtEmployeePAN.Text == string.Empty || !(radioButtonEmployeeFemale.Checked || radioButtonEmployeeMale.Checked))
                {
                    checkBoxUserRegister.Checked = false;
                    buttonUserRegister.Enabled = false;
                }
                else
                {
                    buttonUserRegister.Enabled = true;
                }
                
            }
            else
            {
                buttonUserRegister.Enabled = false;
            }
        }

        //************************************************** VALIDATING TEXTBOXES ***********************************************

        private void textBoxEmployeeID_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxEmployeeID.Text == string.Empty)
            {
                errorProviderUserRegistration.SetError(textBoxEmployeeID, "Employee id required !");                
            }
            else
            {
                errorProviderUserRegistration.SetError(textBoxEmployeeID, string.Empty);                
            }
        }

        private void textBoxEmployeeName_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxEmployeeName.Text == string.Empty)
            {
                errorProviderUserRegistration.SetError(textBoxEmployeeName, "Employee name required !");                
            }
            else
            {
                errorProviderUserRegistration.SetError(textBoxEmployeeName, string.Empty);
            }
        }

        private void dateTimePickerEmployeeDOB_Validating(object sender, CancelEventArgs e)
        {
            if (dateTimePickerEmployeeDOB.Text == string.Empty)
            {
                errorProviderUserRegistration.SetError(dateTimePickerEmployeeDOB, "Employee DOB required !");
            }
            else
            {
                errorProviderUserRegistration.SetError(dateTimePickerEmployeeDOB, string.Empty);
            }
        }

        private void comboBoxDesignation_Validating(object sender, CancelEventArgs e)
        {
            if (comboBoxDesignation.SelectedIndex==-1)
            {
                errorProviderUserRegistration.SetError(comboBoxDesignation, "Employee designation required !");
            }
            else
            {
                errorProviderUserRegistration.SetError(comboBoxDesignation, string.Empty);
            }
        }

        private void textBoxEmployeePhone_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxEmployeePhone.Text == string.Empty)
            {
                errorProviderUserRegistration.SetError(textBoxEmployeePhone, "Employee phone number required !");
            }
            else if (textBoxEmployeePhone.Text.Length != 10)
            {
                errorProviderUserRegistration.SetError(textBoxEmployeePhone, "Phone number should contain 10 digits !");
            }
            else if (!long.TryParse(textBoxEmployeePhone.Text, out long result))
            {
                errorProviderUserRegistration.SetError(textBoxEmployeePhone, "Phone number should contain digits !");
            }
            else
            {
                errorProviderUserRegistration.SetError(textBoxEmployeePhone, string.Empty);
            }
        }

        private void textBoxEmployeeEmail_Validating(object sender, CancelEventArgs e)
        {

            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(textBoxEmployeeEmail.Text);
            if (textBoxEmployeeEmail.Text == string.Empty)
            {
                errorProviderUserRegistration.SetError(textBoxEmployeeEmail, "Employee email required !");
            }
            else if (!match.Success)
            {
                errorProviderUserRegistration.SetError(textBoxEmployeeEmail, "Invalid email !");

            }
            else
            {
                errorProviderUserRegistration.SetError(textBoxEmployeeEmail, string.Empty);
            }
        }

        private void textBoxEmployeeAddress_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxEmployeeAddress.Text == string.Empty)
            {
                errorProviderUserRegistration.SetError(textBoxEmployeeAddress, "Employee address required !");
            }
            else
            {
                errorProviderUserRegistration.SetError(textBoxEmployeeAddress, string.Empty);
            }
        }
        
        private void textBoxtEmployeePAN_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxtEmployeePAN.Text == string.Empty)
            {
                errorProviderUserRegistration.SetError(textBoxtEmployeePAN, "Employee pan number required !");
            }
            else
            {
                errorProviderUserRegistration.SetError(textBoxtEmployeePAN, string.Empty);
            }
        }

        private void textBoxEmployeeAadhar_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxEmployeeAadhar.Text == string.Empty)
            {
                errorProviderUserRegistration.SetError(textBoxEmployeeAadhar, "Employee aadhar number required !");
            }
            else if (textBoxEmployeeAadhar.Text.Length != 12)
            {
                errorProviderUserRegistration.SetError(textBoxEmployeePhone, "Aadhar number should contain 12 digits !");
            }
            else if (!long.TryParse(textBoxEmployeeAadhar.Text, out long result))
            {
                errorProviderUserRegistration.SetError(textBoxEmployeePhone, "Aadhar number should contain digits !");
            }
            else
            {
                errorProviderUserRegistration.SetError(textBoxEmployeeAadhar, string.Empty);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Utility.GetLastPage();
        }
    }
}
