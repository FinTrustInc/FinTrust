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
    public partial class FinTrust_Registration : Form
    {
        public FinTrust_Registration()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            this.Hide();

            FinTrust_Clerk_HomePage clerkform = new FinTrust_Clerk_HomePage();
            clerkform.Show();
        }
    }
}
