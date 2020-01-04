using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinTrustBLL.BusinessLayer;

namespace FinTrustApp.PresentationLayer
{
	public partial class FinTrust_Cashier_Search : Form
	{
		public FinTrust_Cashier_Search()
		{
			InitializeComponent();
		}

		private void labelMessage_Click(object sender, EventArgs e)
		{

		}

		//------------------------------------------------------------------------------------
		//----------------------- Load Data to combobox --------------------------------------

		private void FinTrust_Cashier_Search_Load(object sender, EventArgs e)
		{
			comboBoxSearch.Items.Add("Customer ID");
			comboBoxSearch.Items.Add("Account No");
			comboBoxSearch.Items.Add("Customer Name");
			comboBoxSearch.Items.Add("Transaction Type");
		}

		//-------------------------------------------------------------------------------------
		//----------------------------- Search for a Transaction ------------------------------

		private void textBoxSearch_TextChanged(object sender, EventArgs e)
		{
			DataSet dsTransactions = null;
			string category = null;
			try
			{
				if (comboBoxSearch.Text == "Customer ID")
				{
					category = "customerId";
				}
				else if (comboBoxSearch.Text == "Account No")
				{
					category = "accountNumber";
				}
				else if (comboBoxSearch.Text == "Customer Name")
				{
					category = "customerName";
				}
				else if (comboBoxSearch.Text == "Transaction Date")
				{
					category = "transactionDate";
				}
				else if (comboBoxSearch.Text == "Transaction Type")
				{
					category = "transactionType";
				}

				string like = textBoxSearch.Text;
				
				//---------------------------------------------------------------------------------------------------------
				//--------------------------------- Search for transactions -----------------------------------------------

				dsTransactions = TransactionBL.GetTransactionsLike(category, like);
				if (dsTransactions != null)
				{
					dataGridViewTransactions.DataSource = dsTransactions.Tables[0];
				}
				if(dsTransactions.Tables[0].Rows.Count < 1)
				{
					labelMessage.Text = "No Details Available in Transactions";
				}
			}
			catch (Exception ex)
			{
				Console.Out.WriteLine(ex.Message.ToString());
			}

		}

		//---------------------------------------------------------------------------------------------------------------------
		//-------------- Display an Individual Transaction while Clicking on one of the rows of DatagridView-------------------

		private void dataGridViewTransactions_SelectionChanged(object sender, EventArgs e)
		{
			if (dataGridViewTransactions.SelectedCells.Count > 0)
			{
				int selectedrowindex = dataGridViewTransactions.SelectedCells[0].RowIndex;

				DataGridViewRow selectedRow = dataGridViewTransactions.Rows[selectedrowindex];

				textBoxAccNo.Text = Convert.ToString(selectedRow.Cells["accountNumber"].Value);
				textBoxAccName.Text = Convert.ToString(selectedRow.Cells["customerName"].Value);
				textBoxTransactionType.Text = Convert.ToString(selectedRow.Cells["transactionType"].Value);
				textBoxTransactionDate.Text = Convert.ToString(selectedRow.Cells["transactionDate"].Value);
				textBoxAmount.Text = Convert.ToDouble(selectedRow.Cells["transactionAmount"].Value).ToString();
				textBoxBalanceAmount.Text = Convert.ToDouble(selectedRow.Cells["balanceAmount"].Value).ToString();

			}
		}

		private void comboBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		//----------------------------------------------------------------------------------------------------------
		//---------------------------- Search With date of Transaction ---------------------------------------------

		private void dateTimePickerSearch_ValueChanged(object sender, EventArgs e)
		{
			DataSet dsTransactions = null;
			string category = null;
			try
			{
				if (comboBoxSearch.Text == "Customer ID")
				{
					category = "customerId";
				}
				else if (comboBoxSearch.Text == "Account No")
				{
					category = "accountNumber";
				}
				else if (comboBoxSearch.Text == "Customer Name")
				{
					category = "customerName";
				}
				else if (comboBoxSearch.Text == "Transaction Date")
				{
					category = "transactionDate";
				}
				else if (comboBoxSearch.Text == "Transaction Type")
				{
					category = "transactionType";
				}

				string like = textBoxSearch.Text;

				//-------------------------------------------------------------------------------------------------------------------
				//----------------------------Search for transaction with date ------------------------------------------------------

				string searchDate = dateTimePickerSearch.Value.Date.Month + "/" + dateTimePickerSearch.Value.Date.Day + "/" + dateTimePickerSearch.Value.Date.Year;
				dsTransactions = TransactionBL.GetTransactionsLikeDate(category, like, searchDate);
				if (dsTransactions != null)
				{
					dataGridViewTransactions.DataSource = dsTransactions.Tables[0];
				}
				else
				{
					labelMessage.Text = "No Details Available in Transactions";
				}
			}
			catch (Exception ex)
			{
				Console.Out.WriteLine(ex.Message.ToString());
			}
		}
	}
}
