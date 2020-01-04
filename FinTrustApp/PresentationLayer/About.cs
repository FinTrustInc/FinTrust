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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void logo_MouseEnter(object sender, EventArgs e)
        {
            
            int x = logo.Location.X;
            int y = logo.Location.Y;
            logo.Location = new Point(x + 0, y + 12);
        }

        private void logo_MouseLeave(object sender, EventArgs e)
        {
           
            int x = logo.Location.X;
            int y = logo.Location.Y;
            logo.Location = new Point(x - 0, y - 12);
        }

        private void picturecbs_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void picturecbs_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void logo_MouseHover(object sender, EventArgs e)
        {
            
        }
    }
    
}
