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
    public partial class MyProfile : Form
    {
        public MyProfile()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Utility.GetLastPage();
        }

       

        private void MyProfile_Load(object sender, EventArgs e)
        {

            DataSet dsEmployeeUser = null;
            string employeeId = LoginInfo.employeeId;
            

            try
            {
                dsEmployeeUser = FinTrustBL.GetEmployeeDetails(employeeId);
                Object[] Data = null;


                if (dsEmployeeUser.Tables[0].Rows.Count > 0)
                {
                    Data = dsEmployeeUser.Tables[0].Rows[0].ItemArray;

                    textBoxEmployeeId.Text = Data[0].ToString();
                    textBoxEmployeeName.Text = Data[1].ToString();
                    textBoxDesignation.Text= Data[4].ToString();
                    textBoxDOB.Text = Data[2].ToString();
                    textBoxGender.Text = Data[3].ToString();
                     textBoxPhone.Text = Data[5].ToString();
                    textBoxEmail.Text = Data[6].ToString();


                }
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("Error : FinTrustBL:GetEmployeeDetails : " + ex.Message.ToString());
            }

        

        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string pswd1 = textBoxPassword1.Text;
            string pswd2 = textBoxPassword2.Text;
            string employeeId = LoginInfo.employeeId;
            int output = 0;
            if(pswd1==pswd2 && pswd1.Trim() != "")
            {
                output = FinTrustBL.UpdatePassword(pswd1,employeeId);
                if (output > 0)
                {
                    MessageBox.Show("Password Updated Successfully!");
                }
                else
                {
                    MessageBox.Show("Password Updation Failed!");
                }
            }
        }
    }
}
