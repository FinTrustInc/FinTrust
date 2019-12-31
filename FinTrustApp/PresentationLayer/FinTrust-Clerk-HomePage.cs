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
    public partial class FinTrust_Clerk_HomePage : Form
    {
        public FinTrust_Clerk_HomePage()
        {
            InitializeComponent();
        }

        private void yujhkToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void accountOpenCloseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void accountOpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            FinTrust_AccountOpen accountopenform = new FinTrust_AccountOpen();
            accountopenform.Show();
        }

        private void accountCloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FinTrust_AccountClose accountcloseform = new FinTrust_AccountClose();
            accountcloseform.Show();
        }
    }
}
