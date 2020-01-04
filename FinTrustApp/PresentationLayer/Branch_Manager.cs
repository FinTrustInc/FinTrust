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
    public partial class Branch_Manager : Form
    {
        public Branch_Manager()
        {
            InitializeComponent();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            
        }

        private void helpToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            About aboutObj = new About();
            aboutObj.Show();

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginInfo.designation = "";
            LoginInfo.employeeId = "";
            this.Hide();

            FinTrust_Login loginForm = new FinTrust_Login();
            loginForm.Show();
        }

        private void ToolStripApproveLoan_Click(object sender, EventArgs e)
        {
            

        }

        private void accountDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer_View ViewForm = new Customer_View();
            ViewForm.Show();
        }

        private void loanDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            Pending_Loan_Applications loanApprovalForm = new Pending_Loan_Applications();
            loanApprovalForm.Show();
        }

        private void registerEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            FinTrust_Registration registrationForm = new FinTrust_Registration();
            registrationForm.Show();
        }

        private void myProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MyProfile profileObj = new MyProfile();
            profileObj.Show();
        }
    }
}
