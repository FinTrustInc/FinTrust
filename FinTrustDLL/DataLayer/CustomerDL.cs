using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using FinTrustDLL.Helper;
using FinTrustDTO.DTO;

namespace FinTrustDLL.DataLayer
{
    public class CustomerDL
    {


        public static Customer GetCustomerByAccountNumber(string accountNumber)
        {
            string sql = "";
            SqlConnection con = null;
            SqlDataAdapter adapter = null;
            DataSet dsCustomer = null;
            Customer customerObj = null;
            try
            {
                sql = "select * from customer_table where accountNumber='" + accountNumber + "'";
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
                Console.Out.WriteLine("Error : CustomerDL:GetCustomerByAccountNumber : " + ex.Message.ToString());
            }
            finally
            {
                con.Close();
                adapter.Dispose();
            }

            return customerObj;
        }


        public static string GetLastCustomerId()
        {
            string sql = "";
            SqlConnection con = null;
            SqlDataAdapter adapter = null;
            DataSet dsCustomer = null;
            string lastCustomerId = null;
            Object[] Data = null;
            try
            {
                sql = "select customerId from customer_table order by customerId desc";
                con = DBHelper.GetConnection();
                con.Open();
                dsCustomer = new DataSet();
                adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dsCustomer);

                if (dsCustomer.Tables[0].Rows.Count > 0)
                {
                    Data = dsCustomer.Tables[0].Rows[0].ItemArray;
                    lastCustomerId = Data[0].ToString();
                }
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("Error : CustomerDL : GetLastCustomerId() " + ex.Message.ToString());
            }
            finally
            {
                con.Close();
                adapter.Dispose();
            }

            return lastCustomerId;
        }


        public static string GetLastAccountNumber()
        {
            string sql = "";
            SqlConnection con = null;
            SqlDataAdapter adapter = null;
            DataSet dsAccount = null;
            string lastAccountNumber = null;
            Object[] Data = null;
            try
            {
                sql = "select accountNumber from customer_table order by accountNumber desc";
                con = DBHelper.GetConnection();
                con.Open();
                dsAccount = new DataSet();
                adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dsAccount);

                if (dsAccount.Tables[0].Rows.Count > 0)
                {
                    Data = dsAccount.Tables[0].Rows[0].ItemArray;
                    lastAccountNumber = Data[0].ToString();
                }
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("Error : CustomerDL : GetLastAccountNumber() " + ex.Message.ToString());
            }
            finally
            {
                con.Close();
                adapter.Dispose();
            }

            return lastAccountNumber;
        }

        public static int InsertCustomerDetails(Customer objCustomer)
        {
            int output = 0;
            string sql = "";
            SqlConnection con = null;
            SqlCommand cmd = null;

            try
            {
                sql = "insert into customer_table (customerId,accountNumber,customerName,dateOfAccount,accountType,dateOfBirth,gender,phone,email,address,aadharNumber,panNumber) values (";
                sql = sql + "'" + objCustomer.CustomerId + "',";
                sql = sql + "'" + objCustomer.AccountNumber + "',";
                sql = sql + "'" + objCustomer.CustomerName + "',";
                sql = sql + "'" + objCustomer.DateOfAccount + "',";
                sql = sql + "'" + objCustomer.AccountType + "',";
                sql = sql + "'" + objCustomer.DateOfBirth + "',";
                sql = sql + "'" + objCustomer.Gender + "',";
                sql = sql + "" + objCustomer.Phone + ",";
                sql = sql + "'" + objCustomer.Email + "',";
                sql = sql + "'" + objCustomer.Address + "',";
                sql = sql + "" + objCustomer.AadharNumber + ",";
                sql = sql + "'" + objCustomer.PanNumber + "')";
                

                con = DBHelper.GetConnection();
                con.Open();
                cmd = new SqlCommand(sql, con);

                output = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("******Error:CustomerDL.cs:InsertCustomerDetails" + ex.Message.ToString());
            }
            finally
            {
                con.Close();
                cmd.Dispose();
            }
            return output;
        }

        public static int DeleteAccountDetails(string accountNumber)
        {
            int output = 0;
            string sql = "";
            SqlConnection con = null;
            SqlCommand cmd = null;

            try
            {
                sql = "delete from customer_table where accountNumber='" + accountNumber + "'";


                con = DBHelper.GetConnection();
                con.Open();
                cmd = new SqlCommand(sql, con);

                output = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("******Error:CustomerDL.cs:DeleteAccountDetails" + ex.Message.ToString());
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
