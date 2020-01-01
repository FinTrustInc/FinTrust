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

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            //this.Hide();

            //FinTrust_Clerk_HomePage clerkform = new FinTrust_Clerk_HomePage();
            //clerkform.Show();
            User objUser = null;
            int output = 0;

            try
            {
                if (textBoxEmployeeID.Text == string.Empty || textBoxEmployeeName.Text == string.Empty || comboBoxDesignation.Text == string.Empty || textBoxEmployeePhone.Text == string.Empty || textBoxEmployeeEmail.Text == string.Empty || textBoxEmployeeAddress.Text == string.Empty || textBoxEmployeeAadhar.Text == string.Empty || textBoxtEmployeePAN.Text == string.Empty)
                {
                    foreach (Control control in this.Controls)
                    {
                        // Set focus on control
                        control.Focus();
                        // Validate causes the control's Validating event to be fired,
                        // if CausesValidation is True
                        if (!Validate())
                        {
                            DialogResult = DialogResult.None;
                            return;
                        }
                    }
                }

                else
                {
                    objUser = new User();

                    objUser.EmployeeId = textBoxEmployeeID.Text;
                    objUser.EmployeeName = textBoxEmployeeName.Text;
                    objUser.DateOfBirth = dateTimePickerEmployeeDOB.Value.ToString("MM-dd-yyyy");
                    if(radioButtonEmployeeMale.Checked==true)
                    {
                        objUser.Gender = "Male";
                    }
                    else
                    {
                        objUser.Gender = "Female";
                    }
                    objUser.Designation=comboBoxDesignation.Text;
                    objUser.Phone = Convert.ToInt64(textBoxEmployeePhone.Text);
                    objUser.Email = textBoxEmployeeEmail.Text;
                    objUser.Address = textBoxEmployeeAddress.Text;
                    objUser.AadharNumber = Convert.ToInt64(textBoxEmployeeAadhar.Text);
                    objUser.PanNumber = textBoxtEmployeePAN.Text;

                    output = FinTrustBL.UserInsert(objUser);
                    if(output<0)
                    {
                        labelUserRegistrtionMessage.Text = "FAIL";                      
                    }
                    else
                    {
                        labelUserRegistrtionMessage.Text = "SUCCESS";
                    }


                }
            }
            catch(Exception ex)
            {

            }
            
        }

        private void textBoxEmployeeID_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxEmployeeID.Text == string.Empty)
            {
                errorProviderUserRegistration.SetError(textBoxEmployeeID, "Employee id required !");
                textBoxEmployeeID.BackColor = Color.LightCoral;
            }
            else
            {
                errorProviderUserRegistration.SetError(textBoxEmployeeID, string.Empty);
                textBoxEmployeeID.BackColor = Color.White;
            }
        }

        private void textBoxEmployeeName_Validating(object sender, CancelEventArgs e)
        {
            if(textBoxEmployeeName.Text==string.Empty)
            {
                errorProviderUserRegistration.SetError(textBoxEmployeeName, "Employee name required !");
                textBoxEmployeeName.BackColor = Color.LightCoral;
            }
            else
            {
                errorProviderUserRegistration.SetError(textBoxEmployeeName, string.Empty);
                textBoxEmployeeName.BackColor = Color.White;
            }
        }

        private void dateTimePickerEmployeeDOB_Validating(object sender, CancelEventArgs e)
        {
            if(dateTimePickerEmployeeDOB.Text==string.Empty)
            {
                errorProviderUserRegistration.SetError(dateTimePickerEmployeeDOB, "Employee date of birth required !");
                dateTimePickerEmployeeDOB.BackColor = Color.LightCoral;
            }
            else
            {
                errorProviderUserRegistration.SetError(dateTimePickerEmployeeDOB, string.Empty);
                dateTimePickerEmployeeDOB.BackColor = Color.White;
            }
        }

        private void comboBoxDesignation_Validating(object sender, CancelEventArgs e)
        {
            if(comboBoxDesignation.Text==string.Empty)
            {
                errorProviderUserRegistration.SetError(comboBoxDesignation, "Employee designation required !");
                comboBoxDesignation.BackColor = Color.LightCoral;
            }
            else
            {
                errorProviderUserRegistration.SetError(comboBoxDesignation, string.Empty);
                comboBoxDesignation.BackColor = Color.White;
            }
        }

        private void textBoxEmployeePhone_Validating(object sender, CancelEventArgs e)
        {
            if(textBoxEmployeePhone.Text==string.Empty)
            {
                errorProviderUserRegistration.SetError(textBoxEmployeePhone, "Employee phone number required !");
                textBoxEmployeePhone.BackColor = Color.LightCoral;
            }
            else if(textBoxEmployeePhone.Text.Length !=10 || !int.TryParse(textBoxEmployeePhone.Text, out int result))
            {
                errorProviderUserRegistration.SetError(textBoxEmployeePhone, "Enter valid phone number !");
                textBoxEmployeePhone.BackColor = Color.LightCoral;
            }
            else
            {
                errorProviderUserRegistration.SetError(textBoxEmployeePhone, string.Empty);
                textBoxEmployeePhone.BackColor = Color.White;
            }
        }

        private void textBoxEmployeeEmail_Validating(object sender, CancelEventArgs e)
        {
            
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(textBoxEmployeeEmail.Text);
            if (textBoxEmployeeEmail.Text==string.Empty)
            {
                errorProviderUserRegistration.SetError(textBoxEmployeeEmail, "Employee email required !");
                textBoxEmployeeEmail.BackColor = Color.LightCoral;
            }
            else if(!match.Success)
            {
                errorProviderUserRegistration.SetError(textBoxEmployeeEmail, "Invalid email !");
                textBoxEmployeeEmail.BackColor = Color.LightCoral;

            }
            else
            {
                errorProviderUserRegistration.SetError(textBoxEmployeeEmail,string.Empty);
                textBoxEmployeeEmail.BackColor = Color.White;
            }
        }

        private void textBoxEmployeeAddress_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxEmployeeAddress.Text == string.Empty)
            {
                errorProviderUserRegistration.SetError(textBoxEmployeeAddress, "Employee address required !");
                textBoxEmployeeAddress.BackColor = Color.LightCoral;
            }
            else
            {
                errorProviderUserRegistration.SetError(textBoxEmployeeAddress, string.Empty);
                textBoxEmployeeAddress.BackColor = Color.White;
            }
        }

        private void textBoxEmployeeAadhar_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBoxtEmployeePAN_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxtEmployeePAN.Text == string.Empty)
            {
                errorProviderUserRegistration.SetError(textBoxtEmployeePAN, "Employee pan number required !");
                textBoxtEmployeePAN.BackColor = Color.LightCoral;
            }
            else
            {
                errorProviderUserRegistration.SetError(textBoxtEmployeePAN, string.Empty);
                textBoxtEmployeePAN.BackColor = Color.White;
            }
        }

        private void textBoxEmployeeAadhar_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxEmployeeAadhar.Text == string.Empty)
            {
                errorProviderUserRegistration.SetError(textBoxEmployeeAadhar, "Employee aadhar number required !");
                textBoxEmployeeAadhar.BackColor = Color.LightCoral;
            }
            else
            {
                errorProviderUserRegistration.SetError(textBoxEmployeeAadhar, string.Empty);
                textBoxEmployeeAadhar.BackColor = Color.White;
            }
        }
    }
}
