﻿using FinTrustDTO.DTO;
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

        //----------------------------------------------------------------------------------------------
        //----------------------- Action for Cashier Search Button -------------------------------------

        private void searchToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			FinTrust_Cashier_Search objSearch = new FinTrust_Cashier_Search();
			objSearch.Show();
			//objSearch.MdiParent = this;
		}

        //----------------------------------------------------------------------------------------------
        //----------------------- Customer View --------------------------------------------------------

        private void viewTransactionsToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
            Customer_View objView = new Customer_View();
			objView.Show();
			//objView.MdiParent = this;
		}

        //----------------------------------------------------------------------------------------------
        //----------------------- Action for Logout Button ---------------------------------------------

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginInfo.designation = "";
            LoginInfo.employeeId = "";
            this.Hide();

            FinTrust_Login loginForm = new FinTrust_Login();
            loginForm.Show();
        }

        //----------------------------------------------------------------------------------------------
        //----------------------- Customer View --------------------------------------------------------

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Customer_View ViewForm = new Customer_View();
            ViewForm.Show();
        }

        //----------------------------------------------------------------------------------------------
        //----------------------- Action for Cashier Search Button -------------------------------------

        private void transactionDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            FinTrust_Cashier_Search cashierSearchForm = new FinTrust_Cashier_Search();
            cashierSearchForm.Show();
        }

        //----------------------------------------------------------------------------------------------
        //----------------------- Customer View --------------------------------------------------------

        private void accountDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer_View ViewForm = new Customer_View();
            ViewForm.Show();
        }

    

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        //----------------------------------------------------------------------------------------------
        //----------------------- Transaction Button for Cashier ---------------------------------------

        private void transactionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FinTrust_Cashier_Transaction objTransaction = new FinTrust_Cashier_Transaction();
            objTransaction.Show();
           
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //----------------------------------------------------------------------------------------------
        //----------------------- Employee Profile -----------------------------------------------------

        private void myProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MyProfile profileObj = new MyProfile();
            profileObj.Show();
        }

        //----------------------------------------------------------------------------------------------
        //----------------------- Action for About Button ----------------------------------------------

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            About aboutObj = new About();
            aboutObj.Show();
        }
    }
}
