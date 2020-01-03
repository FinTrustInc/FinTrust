using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinTrustDTO.DTO;
using FinTrustDLL.Helper;
using System.Data.SqlClient;
using System.Data;

namespace FinTrustDLL.DataLayer
{
	public class FinTrustDL
	{
        public static DataSet GetEmployeeCredentials(User objUser)
        {
            string sql = "";
            SqlConnection con = null;
            SqlDataAdapter adapter = null;
            DataSet dsEmployeeUser = null;

            try
            {
                sql = "select email,password from user_table where designation='"+objUser.Designation+"'";
                con = DBHelper.GetConnection();
                con.Open();
                dsEmployeeUser = new DataSet();
                adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dsEmployeeUser);

            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("Error : FinTrustDL:GetEmployeeCredentials : " + ex.Message.ToString());
            }
            finally
            {
                con.Close();
                adapter.Dispose();
            }

            return dsEmployeeUser;
        }


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

        public static int InsertUserDetails(User objUser)
        {
            int output = 0;
            string sql = "";
            SqlConnection con = null;
            SqlCommand cmd = null;

            try
            {
                sql = "insert into user_table (employeeId,employeeName,dateOfBirth,gender,designation,phone,email,address,aadharNumber,panNumber,password) values (";
                sql = sql + "'" + objUser.EmployeeId + "',";
                sql = sql + "'" + objUser.EmployeeName + "',";
                sql = sql + "'" + objUser.DateOfBirth + "',";
                sql = sql + "'" + objUser.Gender + "',";
                sql = sql + "'" + objUser.Designation + "',";
                sql = sql + "" + objUser.Phone + ",";
                sql = sql + "'" + objUser.Email + "',";
                sql = sql + "'" + objUser.Address + "',";
                sql = sql + "" + objUser.AadharNumber + ",";
                sql = sql + "'" + objUser.PanNumber + "',";
                sql = sql + "" + objUser.Phone + ")";

                con = DBHelper.GetConnection();
                con.Open();
                cmd = new SqlCommand(sql, con);

                output = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("******Error:FinTrustDL.cs:InsertUserDetails" + ex.Message.ToString());
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
