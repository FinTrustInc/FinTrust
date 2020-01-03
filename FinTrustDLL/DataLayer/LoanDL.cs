using FinTrustDLL.Helper;
using FinTrustDTO.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinTrustDLL.DataLayer
{
    public class LoanDL
    {
        public static Customer GetCustomerById(string customerId)
        {
            string sql = "";
            SqlConnection con = null;
            SqlDataAdapter adapter = null;
            DataSet dsCustomer = null;
            Customer customerObj = null;
            try
            {
                sql = "select * from customer_table where customerId='" + customerId + "'";
                con = DBHelper.GetConnection();
                con.Open();
                dsCustomer = new DataSet();
                adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dsCustomer);

                Object[] Data = null;

                if (dsCustomer.Tables[0].Rows.Count > 0)
                {
                    Data = dsCustomer.Tables[0].Rows[0].ItemArray;
                    customerObj = new Customer();
                    customerObj.CustomerId = Data[0].ToString();
                    customerObj.AccountNumber = Data[1].ToString();
                    customerObj.CustomerName = Data[2].ToString();
                    customerObj.DateOfAccount = Data[3].ToString();
                    customerObj.AccountType = Data[4].ToString();
                    customerObj.DateOfBirth = Data[5].ToString();
                    customerObj.Gender = Data[6].ToString();
                    customerObj.Phone = Convert.ToInt64(Data[7].ToString());
                    customerObj.Email = Data[8].ToString();
                    customerObj.Address = Data[9].ToString();
                    customerObj.AadharNumber = Convert.ToInt64(Data[10].ToString());
                    customerObj.PanNumber = Data[11].ToString();
                }

            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("Error : LoanDL:GetCustomerById : " + ex.Message.ToString());
            }
            finally
            {
                con.Close();
                adapter.Dispose();
            }

            return customerObj;
        }

        public static string GetLastLoanId()
        {
            string sql = "";
            SqlConnection con = null;
            SqlDataAdapter adapter = null;
            DataSet dsLoan = null;
            string lastLoanId = null;
            Object[] Data = null;
            try
            {
                sql = "select loanId from loan_table order by loanId desc";
                con = DBHelper.GetConnection();
                con.Open();
                dsLoan= new DataSet();
                adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dsLoan);

                if (dsLoan.Tables[0].Rows.Count > 0)
                {
                    Data = dsLoan.Tables[0].Rows[0].ItemArray;
                    lastLoanId = Data[0].ToString();
                }
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("Error : LoanDL : GetLastLoanId() " + ex.Message.ToString());
            }
            finally
            {
                con.Close();
                adapter.Dispose();
            }

            return lastLoanId;
        }

        public static int InsertLoanDetails(Loan loanObj)
        {
            int output = 0;
            string sql = "";
            SqlConnection con = null;
            SqlCommand cmd = null;
            try
            {

                sql = "insert into loan_table(loanId,customerId,loanType,loanAmount,interestRate,term,netAmount,guarantorName,status,date) values(";
                sql = sql + "'" + loanObj.LoanId + "',";
                sql = sql + "'" + loanObj.CustomerId + "',";
                sql = sql + "'" + loanObj.LoanType + "',";
                sql = sql + loanObj.LoanAmount + ",";
                sql = sql + loanObj.InterestRate + ",";
                sql = sql + loanObj.Term + ",";
                sql = sql + loanObj.NetAmount + ",";
                sql = sql + "'" + loanObj.GuarantorName + "',";
                sql = sql + "'" + loanObj.Status + "',";
                sql = sql + "'" + loanObj.Date + "')";

                con = DBHelper.GetConnection();
                con.Open();
                cmd = new SqlCommand(sql, con);

                output = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("Error:LoanDL:InsertLoanDetails:" + ex.Message.ToString());
            }
            finally
            {
                con.Close();
                cmd.Dispose();
            }

            return output;


        }

        public static DataSet GetLoanDetails(string loanId)
        {
            string sql = "";
            SqlConnection con = null;
            SqlDataAdapter adapter = null;
            DataSet dsLoans = null;
            DataSet dsStudents = null;
            try
            {
                
                sql = "SELECT customer_table.*,loan_table.* FROM customer_table INNER JOIN loan_table ON customer_table.customerId = loan_table.customerId where loan_table.loanId='" + loanId + "'";
                con = DBHelper.GetConnection();
                con.Open();
                dsLoans = new DataSet();
                adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dsLoans);

            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("Error : LoanDL:GetLoanDetails : " + ex.Message.ToString());
            }
            finally
            {
                con.Close();
                adapter.Dispose();
            }

            return dsLoans;
        }

        public static DataSet GetBasicLoanDetails()
        {
            string sql = "";
            SqlConnection con = null;
            SqlDataAdapter adapter = null;
            DataSet dsLoans = null;
            try
            {
                sql = "SELECT customer_table.*,loan_table.* FROM customer_table INNER JOIN loan_table ON customer_table.customerId = loan_table.customerId where loan_table.status = 'Submitted'";
               // sql = "select * from loan_table where status='Submitted'";
                con = DBHelper.GetConnection();
                con.Open();
                dsLoans = new DataSet();
                adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dsLoans);

            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("Error : LoanDL:GetLoanDetails : " + ex.Message.ToString());
            }
            finally
            {
                con.Close();
                adapter.Dispose();
            }

            return dsLoans;
        }

        public static int UpdateLoanStatus(string loanId, string status)
        {
            int output = 0;
            string sql = "";
            SqlConnection con = null;
            SqlCommand cmd = null;
            try
            {

                sql = "update loan_table set ";
                sql = sql + "status='" + status + "' ";             
                sql = sql + "where loanId='" + loanId + "'";

                con = DBHelper.GetConnection();
                con.Open();
                cmd = new SqlCommand(sql, con);

                output = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("Error : FinTrustBL:UpdateLoanStatus : " + ex.Message.ToString());
            }
            finally
            {
                con.Close();
                cmd.Dispose();
            }

            return output;

        }


        public static DataSet GetLoansLike(string likeName, string searchOption)
        {
            string sql = "";

            SqlConnection con = null;
            SqlDataAdapter adapter = null;
            DataSet dsLoans = null;

            try
            {
                string option = "";
                if (searchOption == "Loan ID")
                {
                    option = "loanId";

                }
                else if (searchOption == "Loan Type")
                {
                    option = "loanType";
                }
                else if (searchOption == "Customer ID")
                {
                    option = "customerId";
                }
                else if (searchOption == "Status")
                {
                    option = "status";
                }


                if (option == "")
                {
                    sql = "select * from loan_table";
                }
                else
                {
                    sql = "select * from loan_table where " + option + " like '" + likeName + "%'";
                }

                con = DBHelper.GetConnection();
                con.Open();
                dsLoans = new DataSet();
                adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dsLoans);

            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("Error : FinTrustDL:GetLoansLike : " + ex.Message.ToString());
            }
            finally
            {
                con.Close();
                adapter.Dispose();
            }

            return dsLoans;
        }

    }
}
