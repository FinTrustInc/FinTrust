using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinTrustDTO.DataTransferObject;
using FinTrustBLL.BusinessLayer;

namespace FinTrustApp.PresentationLayer
{
	public partial class FinTrust_Cashier_Transaction : Form
	{
		public FinTrust_Cashier_Transaction()
		{
			InitializeComponent();
		}

		private void buttonPay_Click(object sender, EventArgs e)
		{
			Transaction objTransaction = null;
			int output = 0;
			try
			{
				objTransaction = new Transaction();
				objTransaction.TransactionId = "TRA1001";
				objTransaction.AccountNumber = textBoxAccNo.Text;				
				DateTime today = DateTime.Today;
				objTransaction.TransactionDate = today.ToString();
				if (radioButtonCredit.Checked)
				{
					objTransaction.TransactionType = radioButtonCredit.Text;
				}
				else
				{
					objTransaction.TransactionType = radioButtonDebit.Text;
				}
				objTransaction.TransactionAmount = Convert.ToInt64(textBoxAmount.Text);
				objTransaction.BalanceAmount = 1000;

					output = FinTrustBL.InsertTransactionDetails(objTransaction);

					if (output > 0)
					{
						labelMessage.Text = "DATA ADDED SUCCESSFULLY";
					}
					else
					{
						labelMessage.Text = "INSERTION FAILED";
					}
				
			}
			catch (Exception ex)
			{
				labelMessage.Text = ex.Message.ToString();
			}
		}

		private void FinTrust_Cashier_Transaction_Load(object sender, EventArgs e)
		{
			textBoxTransactionId.Text = FinTrustBL.GetNewTransactionId().ToString();
		}

		private void textBoxTransactionId_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void textBoxAccNo_TextChanged(object sender, EventArgs e)
		{
			Customer objCustomer = null;
			try
			{
				objCustomer = FinTrustBL.GetNameByAccountNumber(textBoxAccNo.Text);

				if (objCustomer != null)
				{
					textBoxAccName.Text = objCustomer.CustomerName;
				}
			}
			catch (Exception ex)
			{
				labelMessage.Text = ex.Message.ToString();
			}
		}
	}
}
