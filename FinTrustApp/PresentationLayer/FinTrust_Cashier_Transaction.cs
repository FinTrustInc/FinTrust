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

				output = TransactionBL.InsertTransactionDetails(objTransaction);

				if (output > 0)
				{
					labelMessage.Text = "DATA ADDED SUCCESSFULLY";
					
					//----------------------------- Update Balance amount after each transaction -------------------------------------
					TransactionBL.UpdateBalanceAmount(objTransaction.AccountNumber, objTransaction.TransactionType, objTransaction.TransactionAmount);
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
			//---------------------Get new Transaction Id for next transaction-------------------------
			//textBoxTransactionId.Text = FinTrustBL.GetNewTransactionId().ToString();
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
		//----
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

		private void textBoxAccNo_Validating(object sender, CancelEventArgs e)
		{
			if (textBoxAccNo.Text == string.Empty)
			{
				errorProviderTransaction.SetError(textBoxAccNo, "Account number Required !");				
			}
            else if((textBoxAccNo.Text.Length != 6))
            {
                errorProviderTransaction.SetError(textBoxAccNo, "Account number should contain 6 digits !");
            }
            else if (!int.TryParse(textBoxAccNo.Text, out int result))
            {
                errorProviderTransaction.SetError(textBoxAccNo, "Account number should contain digits !");
            }
            else
            {
                errorProviderTransaction.SetError(textBoxAccNo, string.Empty);
            }
        }

        private void textBoxAmount_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxAmount.Text == string.Empty)
            {
                errorProviderTransaction.SetError(textBoxAmount, "Transaction amount Required !");
            }
            else if (!long.TryParse(textBoxAmount.Text, out long result))
            {
                errorProviderTransaction.SetError(textBoxAmount, "Transaction amount should contain digits !");
            }
            else
            {
                errorProviderTransaction.SetError(textBoxAmount, string.Empty);
            }
        }
    }
}
