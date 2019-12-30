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
    public partial class FinTrust_BranchManager_HomePage : Form
    {
        public FinTrust_BranchManager_HomePage()
        {
            InitializeComponent();
        }

        private void accountHandlingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            FinTrust_Registration regForm = new FinTrust_Registration();
            regForm.Show();
        }
    }
}
