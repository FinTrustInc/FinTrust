using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinTrustDTO.DataTransferObject;



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
                labelLoginMessage.Text = "Enter Input !!";
            }
            else
            {
                objUser = new User();
                if (comboBoxUser.Text=="Branch Manager")
                {
                    if (textBoxUsername.Text == "abc@gmail.com" && textBoxPassword.Text == "12345")
                    {
                        this.Hide();

                        FinTrust_BranchManager_HomePage addUserForm = new FinTrust_BranchManager_HomePage();
                        addUserForm.Show();
                    }
                    else
                    {
                        labelLoginMessage.Text = "Enter Valid Input !!";
                    }
                    
                }
            }

           
        }
    }
}
