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
                labelLoginMessage.Text = "Enter Input !!";
            }
            else
            {
                objUser = new User();
                if (comboBoxUser.Text=="Branch Manager")
                {
                    objUser.Email = textBoxUsername.Text;
                    objUser.Password = textBoxPassword.Text;
                    //string userName = FinTrustBL.CheckEmployeeUser(objUser);
                    if (textBoxUsername.Text == "abc@gmail.com" && textBoxPassword.Text == "12345")
                    {
                        this.Hide();

                        Branch_Manager BMHomeForm = new Branch_Manager();
                        BMHomeForm.Show();
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
