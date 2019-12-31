using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinTrustDTO.DataTransferObject;
using FinTrustDSL.Helper;
using System.Data.SqlClient;
using System.Data;

namespace FinTrustDSL.DataServiceLayer
{
	public class FinTrustDL
	{
		public static int InsertTransactionDetails(Transaction objTransaction)
		{
			int output = 0;
			string sql = "";
			SqlConnection con = null;
			SqlCommand cmd = null;
			try
			{
				sql = "insert into transaction_table(transactionId,transactionType,transactionDate,transactionAmount,accountNumber,balanceAmount) values(";
				sql = sql + "'" + objTransaction.TransactionId + "',";
				sql = sql + "'" + objTransaction.TransactionType + "',";
				sql = sql + "'" + objTransaction.TransactionDate + "',";
				sql = sql + "" + objTransaction.TransactionAmount + ",";
				sql = sql + "'" + objTransaction.AccountNumber + "',";
				sql = sql + "" + objTransaction.BalanceAmount + ")";

				con = DBHelper.GetConnection();
				con.Open();
				cmd = new SqlCommand(sql, con);
				output = cmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				Console.Out.WriteLine("Error : FinTrustDL : InsertTransactionDetails() " + ex.Message.ToString());
			}
			finally
			{
				con.Close();
				cmd.Dispose();
			}
			return output;
		}
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
				Console.Out.WriteLine("Error : FinTrustDL : GetLastTransactionId() " + ex.Message.ToString());
			}
			finally
			{
				con.Close();
				adapter.Dispose();
			}

			return lastTransactionId;
		}
		public static Customer GetNameByAccountNumber(string accountNumber)
		{
			string sql = "";
			SqlConnection con = null;
			SqlDataAdapter adapter = null;
			DataSet dsTransactionDetails = null;
			Customer objCustomer = null;
			try
			{
				sql = "select customerName from customer_table where accountNumber=" + accountNumber;

				con = DBHelper.GetConnection();
				con.Open();
				dsTransactionDetails = new DataSet();
				adapter = new SqlDataAdapter(sql, con);
				adapter.Fill(dsTransactionDetails);

				Object[] Data = null;

				if (dsTransactionDetails.Tables[0].Rows.Count > 0)
				{
					Data = dsTransactionDetails.Tables[0].Rows[0].ItemArray;
					objCustomer = new Customer();
					objCustomer.AccountNumber = Data[1].ToString();
					objCustomer.CustomerName = Data[2].ToString();
				}
			}
			catch (Exception ex)
			{
				Console.Out.WriteLine(" Error : FinTrustDL : GetTransactionByNos() " + ex.Message.ToString());
			}
			finally
			{
				con.Close();
				adapter.Dispose();
			}
			return objCustomer;
		}
	}
}
