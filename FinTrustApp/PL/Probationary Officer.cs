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
    public partial class Probationary_Officer : Form
    {
        public Probationary_Officer()
        {
            InitializeComponent();
        }

        private void validateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void loanApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Pending_Loan_Applications objectname = new Pending_Loan_Applications();
            objectname.Show();
            
        }

        private void textBoxname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxGuarantor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
