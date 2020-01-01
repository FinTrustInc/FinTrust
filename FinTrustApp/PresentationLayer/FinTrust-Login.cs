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
    public partial class FinTrust_Login : Form
    {
        public FinTrust_Login()
        {
            InitializeComponent();
        }

        private void lbli_Click(object sender, EventArgs e)
        {

        }

        private void cmbUser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FinTrust_Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            User objUser = null;
            
            if(comboBoxUser.Text==string.Empty || textBoxUsername.Text==string.Empty || textBoxPassword.Text==string.Empty)
            {
                labelLoginMessage.Text = "Enter Valid Input !!";
            }
            else
            {
                objUser = new User();
                objUser.Email = textBoxUsername.Text;
                objUser.Password = textBoxPassword.Text;
                objUser.Designation = comboBoxUser.Text;
                bool validUser = FinTrustBL.CheckEmployeeUser(objUser);
                if (validUser)
                {
                    if (objUser.Designation == "Branch Manager")
                    {
                        this.Hide();
                        Branch_Manager BMHomeForm = new Branch_Manager();
                        BMHomeForm.Show();
                    }
                    else if (objUser.Designation == "Probationary Officer")
                    {
                        this.Hide();
                        Probationary_Officer POHomeForm = new Probationary_Officer();
                        POHomeForm.Show();
                    }
                    else if (objUser.Designation == "Cashier")
                    {
                        this.Hide();
                        FinTrust_Cashier CashierHomeForm = new FinTrust_Cashier();
                        CashierHomeForm.Show();
                    }
                }  
                else
                {
                        labelLoginMessage.Text = "Invalid Login Credentials!";
                }
         
            }
                
        }
     }         
 }


