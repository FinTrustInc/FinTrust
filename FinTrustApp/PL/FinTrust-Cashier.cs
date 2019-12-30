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
	public partial class FinTrust_Cashier : Form
	{
		public FinTrust_Cashier()
		{
			InitializeComponent();
		}

		private void transactionToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
		}

		private void searchToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
		}
		private void transactionToolStripMenuItem_MouseHover(object sender, EventArgs e)
		{

		}
		private void FinTrust_Cashier_Load(object sender, EventArgs e)
		{
			
		}
		private void viewTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
		}
		private void transactionToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			FinTrust_Cashier_Transaction objTransaction = new FinTrust_Cashier_Transaction();
			objTransaction.Show();
			//objTransaction.MdiParent = this;
		}

		private void searchToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			FinTrust_Cashier_Search objSearch = new FinTrust_Cashier_Search();
			objSearch.Show();
			//objSearch.MdiParent = this;
		}

		private void viewTransactionsToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			FinTrust_Cashier_View objView = new FinTrust_Cashier_View();
			objView.Show();
			//objView.MdiParent = this;
		}
	}
}
