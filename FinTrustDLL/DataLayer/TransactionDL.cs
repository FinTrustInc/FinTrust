using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinTrustDLL.Helper;
using FinTrustDTO.DTO;

namespace FinTrustDLL.DataLayer
{
	public class TransactionDL
	{
		//----------------------------------------------------------------------------------------------------------
		//----------------------------- Insert a Transaction -------------------------------------------------------

		public static int InsertTransactionDetails(Transaction objTransaction)
		{
			int output = 0;
			string sql = "";
			SqlConnection con = null;
			SqlCommand cmd = null;
			try
			{
				sql = "insert into transaction_table(transactionId,transactionType,transactionDate,transactionAmount,accountNumber) values(";
				sql = sql + "'" + objTransaction.TransactionId + "',";
				sql = sql + "'" + objTransaction.TransactionType + "',";
				sql = sql + "'" + objTransaction.TransactionDate + "',";
				sql = sql + "" + objTransaction.TransactionAmount + ",";
				sql = sql + "'" + objTransaction.AccountNumber + "')";

				con = DBHelper.GetConnection();
				con.Open();
				cmd = new SqlCommand(sql, con);
				output = cmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				Console.Out.WriteLine("Error : TransactionDL : InsertTransactionDetails() " + ex.Message.ToString());
			}
			finally
			{
				con.Close();
				cmd.Dispose();
			}
			return output;
		}

		//----------------------------------------------------------------------------------------------------------------
		//----------------------------- Get Last Transaction Id to generate new transaction Id ---------------------------

		public static string GetLastTransactionId()
		{
			string sql = "";
			SqlConnection con = null;
			SqlDataAdapter adapter = null;
			DataSet dsTransactions = null;
			string lastTransactionId = null;
			Object[] Data = null;
			try
			{
				sql = "select transactionId from transaction_table order by transactionId desc";
				con = DBHelper.GetConnection();
				con.Open();
				dsTransactions = new DataSet();
				adapter = new SqlDataAdapter(sql, con);
				adapter.Fill(dsTransactions);

				if (dsTransactions.Tables[0].Rows.Count > 0)
				{
					Data = dsTransactions.Tables[0].Rows[0].ItemArray;
					lastTransactionId = Data[0].ToString();
				}

			}
			catch (Exception ex)
			{
				Console.Out.WriteLine("Error : TransactionDL : GetLastTransactionId() " + ex.Message.ToString());
			}
			finally
			{
				con.Close();
				adapter.Dispose();
			}

			return lastTransactionId;
		}
		
		//----------------------------------------------------------------------------------------------------------------
		//----------------------------- Update Balance amount after each transaction -------------------------------------

		public static double GetBalance(string accountNumber)
		{
			string sql = "";
			SqlConnection con = null;
			SqlDataAdapter adapter = null;
			DataSet dsBalance = null;
			double balance = 0;
			Object[] Data = null;
			try
			{
				sql = "select balanceAmount from customer_table where accountNumber=" + accountNumber;
				con = DBHelper.GetConnection();
				con.Open();
				dsBalance = new DataSet();
				adapter = new SqlDataAdapter(sql, con);
				adapter.Fill(dsBalance);

				if (dsBalance.Tables[0].Rows.Count > 0)
				{
					Data = dsBalance.Tables[0].Rows[0].ItemArray;
					balance = Convert.ToInt64(Data[0]);
				}

			}
			catch (Exception ex)
			{
				Console.Out.WriteLine("Error : TransactionDL : GetBalance() " + ex.Message.ToString());
			}
			finally
			{
				con.Close();
				adapter.Dispose();
			}

			return balance;
		}

		//----------------------------------------------------------------------------------------------------------------
		//----------------------------- Update Balance amount after each transaction -------------------------------------

		public static int UpdateBalanceAmount(string accountNumber, double balanceAmount)
		{
			int output = 0;
			string sql = "";
			SqlConnection con = null;
			SqlCommand cmd = null;
			try
			{
				sql = "update customer_table set ";
				sql = sql + "balanceAmount=" + balanceAmount;
				sql = sql + " where accountNumber='" + accountNumber + "'";


				con = DBHelper.GetConnection();
				con.Open();
				cmd = new SqlCommand(sql, con);
				output = cmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				Console.Out.WriteLine("Error : TransactionDL : UpdateBalanceAmount() " + ex.Message.ToString());
			}
			finally
			{
				con.Close();
				cmd.Dispose();
			}
			return output;
		}

		//----------------------------------------------------------------------------------------------------------
		//----------------------------- Search for a Transaction ---------------------------------------------------

		public static DataSet GetTransactionsLike(string category, string like)
		{
			string sql = "";
			SqlConnection con = null;
			SqlDataAdapter adapter = null;
			DataSet dsTransactions = null;
			try
			{
				if (category == "customerId" || category == "accountNumber" || category == "customerName")
				{
					sql = "SELECT transaction_table.transactionId, customer_table.accountNumber, customer_table.customerName,transaction_table.transactionDate,transaction_table.transactionAmount,transaction_table.transactionType,customer_table.balanceAmount FROM customer_table CROSS JOIN transaction_table where customer_table." + category + " like '" + like + "%'";
				}
				else
				{
					sql = "SELECT transaction_table.transactionId, customer_table.accountNumber, customer_table.customerName,transaction_table.transactionDate,transaction_table.transactionAmount,transaction_table.transactionType,customer_table.balanceAmount FROM customer_table CROSS JOIN transaction_table where transaction_table." + category + " like '" + like + "%'";
				}
				con = DBHelper.GetConnection();
				con.Open();
				dsTransactions = new DataSet();
				adapter = new SqlDataAdapter(sql, con);
				adapter.Fill(dsTransactions);
			}
			catch (Exception ex)
			{
				Console.Out.WriteLine(" Error : TransactionDL : GetTransactionsLike() " + ex.Message.ToString());
			}
			finally
			{
				con.Close();
				adapter.Dispose();
			}
			return dsTransactions;
		}

		//----------------------------------------------------------------------------------------------------------
		//----------------------------- Search for a Transaction with transaction date -----------------------------

		public static DataSet GetTransactionsLikeDate(string category, string like, string searchDate)
		{
			string sql = "";
			SqlConnection con = null;
			SqlDataAdapter adapter = null;
			DataSet dsTransactions = null;
			try
			{
				if (category == "customerId" || category == "accountNumber" || category == "customerName")
				{
					sql = "SELECT transaction_table.transactionId, customer_table.accountNumber, customer_table.customerName,transaction_table.transactionDate,transaction_table.transactionAmount,transaction_table.transactionType,customer_table.balanceAmount FROM customer_table CROSS JOIN transaction_table where customer_table." + category + " like '" + like + "%' and transactionDate = '" + searchDate + "'";
				}
				else
				{
					sql = "SELECT transaction_table.transactionId, customer_table.accountNumber, customer_table.customerName,transaction_table.transactionDate,transaction_table.transactionAmount,transaction_table.transactionType,customer_table.balanceAmount FROM customer_table CROSS JOIN transaction_table where transaction_table." + category + " like '" + like + "%' and transactionDate = '" + searchDate + "'";
				}
				con = DBHelper.GetConnection();
				con.Open();
				dsTransactions = new DataSet();
				adapter = new SqlDataAdapter(sql, con);
				adapter.Fill(dsTransactions);
			}
			catch (Exception ex)
			{
				Console.Out.WriteLine(" Error : TransactionDL : GetTransactionsLike() " + ex.Message.ToString());
			}
			finally
			{
				con.Close();
				adapter.Dispose();
			}
			return dsTransactions;
		}

		//----------------------------------------------------------------------------------------------------------------
		//----------------------------- Generate Account Name after entering Account No ----------------------------------

		public static string GetNameLike(string like)
		{
			string name = null;
			DataSet dsNames = null;
			string sql = "";
			SqlConnection con = null;
			SqlDataAdapter adapter = null;
			Object[] Data = null;

			try
			{
				sql = "select customerName from customer_table where accountNumber like '" + like + "%'";
				con = DBHelper.GetConnection();
				con.Open();
				dsNames = new DataSet();
				adapter = new SqlDataAdapter(sql, con);
				adapter.Fill(dsNames);
				if (dsNames.Tables[0].Rows.Count > 0)
				{
					Data = dsNames.Tables[0].Rows[0].ItemArray;
					name = Data[0].ToString();
				}
			}
			catch (Exception ex)
			{
				Console.Out.WriteLine(" Error : TransactionDL : GetNameLike() " + ex.Message.ToString());
			}
			return name;
		}

		//--------------------------------------------------------------------------------------------------------------
		//----------------------------- Search for a Customer ----------------------------------------------------------

		public static DataSet GetCustomersLike(string category, string like)
		{
			string sql = "";
			SqlConnection con = null;
			SqlDataAdapter adapter = null;
			DataSet dsTransactions = null;
			try
			{
				sql = "select * from Customer_table where " + category + " like '" + like + "%'";
				con = DBHelper.GetConnection();
				con.Open();
				dsTransactions = new DataSet();
				adapter = new SqlDataAdapter(sql, con);
				adapter.Fill(dsTransactions);
			}
			catch (Exception ex)
			{
				Console.Out.WriteLine(" Error : TransactionDL : GetCustomersLike() " + ex.Message.ToString());
			}
			finally
			{
				con.Close();
				adapter.Dispose();
			}
			return dsTransactions;
		}

		//----------------------------------------------------------------------------------------------------------------
		//----------------------------- Update Cutomer Details -------------------------------------

		public static int UpdateCustomerDetails(Customer objCustomer)
		{
			int output = 0;
			string sql = "";
			SqlConnection con = null;
			SqlCommand cmd = null;
			try
			{
				sql = "update customer_table set ";
				sql = sql + "customerName='" + objCustomer.CustomerName + "',";
				sql = sql + "accountType='" + objCustomer.AccountType + "',";
				sql = sql + "phone=" + objCustomer.Phone;
				sql = sql + ",email='" + objCustomer.Email + "',";
				sql = sql + "address='" + objCustomer.Address + "' ";
				sql = sql + " where accountNumber=" + objCustomer.AccountNumber;


				con = DBHelper.GetConnection();
				con.Open();
				cmd = new SqlCommand(sql, con);
				output = cmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				Console.Out.WriteLine("Error : TransactionDL : UpdateCustomerDetails() " + ex.Message.ToString());
			}
			finally
			{
				con.Close();
				cmd.Dispose();
			}
			return output;
		}
	}
}
