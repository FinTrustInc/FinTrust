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
    public partial class Clerk : Form
    {
        public Clerk()
        {
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginInfo.designation = "";
            LoginInfo.employeeId = "";
            this.Hide();

            FinTrust_Login loginForm = new FinTrust_Login();
            loginForm.Show();
        }

        private void grievanceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Grievance_Redressal_Application grievanceForm = new Grievance_Redressal_Application();
            grievanceForm.Show();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer_View ViewForm = new Customer_View();
            ViewForm.Show();
        }

        private void accountOpenimgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

             FinTrust_AccountOpen accountOpenForm = new FinTrust_AccountOpen();
            accountOpenForm.Show();
           
        }

        private void accountClosingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            FinTrust_AccountClose accountCloseForm = new FinTrust_AccountClose();
            accountCloseForm.Show();
        }

        private void myProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MyProfile profileObj = new MyProfile();
            profileObj.Show();
        }

        private void helpToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            About aboutObj = new About();
            aboutObj.Show();
        }
    }
}
