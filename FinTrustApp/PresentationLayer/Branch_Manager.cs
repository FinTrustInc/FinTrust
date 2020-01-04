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
            this.Hide();

            FinTrust_Registration registrationForm = new FinTrust_Registration();
            registrationForm.Show();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

           Fintrust_View ViewForm = new Fintrust_View();
            ViewForm.Show();
            
        }

        private void helpToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();

            About helpForm = new About();
            helpForm.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            FinTrust_Login loginForm = new FinTrust_Login();
            loginForm.Show();
        }

        private void ToolStripApproveLoan_Click(object sender, EventArgs e)
        {
            this.Hide();

            Pending_Loan_Applications loanApprovalForm = new Pending_Loan_Applications();
            loanApprovalForm.Show();

        }
    }
}
