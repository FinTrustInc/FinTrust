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

        private void accountClosingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FinTrust_AccountClose AccountCloseForm = new FinTrust_AccountClose();
            AccountCloseForm.Show();
        }

        private void accountOpenimgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FinTrust_AccountOpen AccountOpenForm = new FinTrust_AccountOpen();
            AccountOpenForm.Show();
        }
    }
}
