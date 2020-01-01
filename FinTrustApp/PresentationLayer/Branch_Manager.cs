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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {

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

           // FinTrust_BranchManager_HomePage BMViewForm = new FinTrust_BranchManager_HomePage();
           // BMViewForm.Show();
            
        }

        private void loanApprovalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            Pending_Loan_Applications loanApprovalForm = new Pending_Loan_Applications();
            loanApprovalForm.Show();
            
        }

        private void helpToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Help helpForm = new Help();
            helpForm.Show();
        }
    }
}
