using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinTrustDLL.DataLayer;
using FinTrustDLL.Helper;
using FinTrustDTO.DTO;

namespace FinTrustBLL.BusinessLayer
{
	public class TransactionBL
	{
		//---------------------------------------------------------------------------------------------------------------
		//----------------------------- Insert a Transaction ------------------------------------------------------------

		public static int InsertTransactionDetails(Transaction objTransaction)
		{
			int output = 0;
			try
			{
				output = TransactionDL.InsertTransactionDetails(objTransaction);
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error : TransactionBL : InsertTransactionDetails()" + ex.Message.ToString());
			}
			return output;
		}

		//----------------------------------------------------------------------------------------------------------------
		//----------------------------- Get Last Transaction Id to generate new transaction Id ---------------------------

		public static string GetNewTransactionId()
		{
			string lastTransactionId = null;
			string newTransactionId = null;
			try
			{
				lastTransactionId = TransactionDL.GetLastTransactionId();
				if (lastTransactionId != null)
				{
					newTransactionId = UtilityHelper.GenerateTransactionId(lastTransactionId);
				}
				else
				{
					newTransactionId = "TRA12101";
				}
			}
			catch (Exception ex)
			{
				Console.Out.WriteLine("Error : TransactionBL : GetNewTransactionId() " + ex.Message.ToString());
			}
			return newTransactionId;
		}

		//----------------------------------------------------------------------------------------------------------------
		//----------------------------- Update Balance amount after each transaction -------------------------------------

		public static void UpdateBalanceAmount(string accountNumber, string transactionType, double amount)
		{
			double balanceAmount = TransactionDL.GetBalance(accountNumber);
			if (transactionType == "Credit")
			{
				balanceAmount = balanceAmount + amount;
			}
			else
			{
				balanceAmount = balanceAmount - amount;
			}
			TransactionDL.UpdateBalanceAmount(accountNumber, balanceAmount);
		}

		//--------------------------------------------------------------------------------------------------------------
		//----------------------------- Search for a Transaction -------------------------------------------------------

		public static DataSet GetTransactionsLike(string category, string like)
		{
			DataSet dsTransactions = null;
			try
			{
				dsTransactions = TransactionDL.GetTransactionsLike(category, like);
			}
			catch (Exception ex)
			{
				Console.Out.WriteLine(" Error : TransactionBL : GetAddressBookLike() " + ex.Message.ToString());
			}
			return dsTransactions;
		}

		//--------------------------------------------------------------------------------------------------------------
		//----------------------------- Search for a Transaction with transaction date -------------------------------------------------------
		public static DataSet GetTransactionsLikeDate(string category, string like, string searchDate)
		{
			DataSet dsTransactions = null;
			try
			{
				dsTransactions = TransactionDL.GetTransactionsLikeDate(category, like, searchDate);
			}
			catch (Exception ex)
			{
				Console.Out.WriteLine(" Error : TransactionBL : GetAddressBookLike() " + ex.Message.ToString());
			}
			return dsTransactions;
		}

		//----------------------------------------------------------------------------------------------------------------
		//----------------------------- Generate Account Name after entering Account No ----------------------------------

		public static String GetNameLike(string like)
		{
			string name = null;
			try
			{
				name = TransactionDL.GetNameLike(like);
			}
			catch (Exception ex)
			{
				Console.Out.WriteLine(" Error : TransactionBL : GetNameLike() " + ex.Message.ToString());
			}
			return name;
		}

		//--------------------------------------------------------------------------------------------------------------
		//----------------------------- Search for a Customer ----------------------------------------------------------
		public static DataSet GetCustomersLike(string category, string like)
		{
			DataSet dsTransactions = null;
			try
			{
				dsTransactions = TransactionDL.GetCustomersLike(category, like);
			}
			catch (Exception ex)
			{
				Console.Out.WriteLine(" Error : TransactionBL : GetCustomersLike() " + ex.Message.ToString());
			}
			return dsTransactions;
		}

		//---------------------------------------------------------------------------------------------------------------
		//----------------------------- Insert a Transaction ------------------------------------------------------------

		public static int UpdateCustomerDetails(Customer objCustomer)
		{
			int output = 0;
			try
			{
				output = TransactionDL.UpdateCustomerDetails(objCustomer);
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error : TransactionBL : UpdateCustomerDetails()" + ex.Message.ToString());
			}
			return output;
		}
	}
}
