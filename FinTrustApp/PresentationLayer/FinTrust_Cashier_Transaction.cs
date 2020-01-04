using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinTrustDTO.DTO;
using FinTrustBLL.BusinessLayer;

namespace FinTrustApp.PresentationLayer
{
	public partial class FinTrust_Cashier_Transaction : Form
	{
		public FinTrust_Cashier_Transaction()
		{
			InitializeComponent();
		}

		//---------------------------------------------------------------------------------------------------------------
		//----------------------------- Insert a Transaction ------------------------------------------------------------

		private void buttonPay_Click(object sender, EventArgs e)
		{
			Transaction objTransaction = null;
			int output = 0;
			try
			{
				objTransaction = new Transaction();
				objTransaction.TransactionId = textBoxTransactionId.Text;
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

				//--------------------------------------------------------------------------------------------------------------
				//------------------------------ Get Balance Amount ------------------------------------------------------------

				double balance = TransactionBL.GetBalance(objTransaction.AccountNumber, objTransaction.TransactionType, objTransaction.TransactionAmount);
				if (balance > 0)
				{
					output = TransactionBL.InsertTransactionDetails(objTransaction);

					if (output > 0)
					{
						string title = "Financial Transaction";
						string message = "Transactiontion Successful";
						MessageBoxButtons buttons = MessageBoxButtons.OK;
						DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Asterisk);
						if (result == DialogResult.OK)
						{
							textBoxTransactionId.Text = TransactionBL.GetNewTransactionId().ToString();
							textBoxAccNo.Clear();
							textBoxAccName.Clear();
							radioButtonCredit.Checked = radioButtonDebit.Checked = false;
							textBoxAmount.Clear();
						}

						//----------------------------- Update Balance amount after each transaction -------------------------------------
						TransactionBL.UpdateBalanceAmount(objTransaction.AccountNumber, balance);
					}
					else
					{
						string title = "Financial Transaction";
						string message = "Transactiontion Failed";
						MessageBoxButtons buttons = MessageBoxButtons.RetryCancel;
						DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
						if (result == DialogResult.Retry)
						{
							textBoxAccNo.Clear();
							textBoxAccName.Clear();
							radioButtonCredit.Checked = radioButtonDebit.Checked = false;
							textBoxAmount.Clear();
						}
					}
				}
				else
				{
					string title = "Financial Transaction";
					string message = "Insufficient Balance";
					MessageBoxButtons buttons = MessageBoxButtons.RetryCancel;
					DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
					if (result == DialogResult.Retry)
					{
						textBoxAmount.Clear();
					}
				}
			}
			catch (Exception ex)
			{
				labelMessage.Text = ex.Message.ToString();
			}

		}

		private void FinTrust_Cashier_Transaction_Load(object sender, EventArgs e)
		{
			//---------------------Get new Transaction Id for next transaction-------------------------
			textBoxTransactionId.Text = TransactionBL.GetNewTransactionId().ToString();
		}

		private void textBoxTransactionId_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void textBoxAccNo_TextChanged(object sender, EventArgs e)
		{
			
		}

        private void buttonBack_Click(object sender, EventArgs e)
        {

        }

		//----------------------------------------------------------------------------------------------------------------
		//----------------------------- Generate Account Name after entering Account No ----------------------------------

		private void textBoxAccNo_KeyUp(object sender, KeyEventArgs e)
		{
			try
			{
				string like = textBoxAccNo.Text;
				if (e.KeyValue == 13)
				{
					string name = TransactionBL.GetNameLike(like);
					if (name != null)
					{
						textBoxAccName.Text = name;
					}
				}
			}
			catch (Exception ex)
			{
				labelMessage.Text = ex.Message.ToString();
			}
		}

		private void textBoxTransactionId_Validating(object sender, CancelEventArgs e)
		{
			
		}

		//---------------------------------------------------------------------------------------
		//----------------------- Validation ----------------------------------------------------

		private void textBoxAccNo_Validating(object sender, CancelEventArgs e)
		{
			if (textBoxAccNo.Text == string.Empty)
			{
				errorProviderTransaction.SetError(textBoxAccNo, "Account no is Required.!");
				textBoxAccNo.BackColor = Color.LightCoral;
			}
		}
	}
}
