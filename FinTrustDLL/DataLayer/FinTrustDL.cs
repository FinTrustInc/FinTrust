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
        //---------------------------------------------------------------------------------------------
        //----------------------- 
        public static DataSet GetEmployeeDetails(string employeeId)
        {
            string sql = "";
            SqlConnection con = null;
            SqlDataAdapter adapter = null;
            DataSet dsEmployeeUser = null;

            try
            {
                sql = "select * from user_table where employeeId='" + employeeId + "'";
                con = DBHelper.GetConnection();
                con.Open();
                dsEmployeeUser = new DataSet();
                adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dsEmployeeUser);

            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("Error : FinTrustDL:GetEmployeeDetails : " + ex.Message.ToString());
            }
            finally
            {
                con.Close();
                adapter.Dispose();
            }

            return dsEmployeeUser;
        }


        public static DataSet GetEmployeeCredentials(User objUser)
        {
            string sql = "";
            SqlConnection con = null;
            SqlDataAdapter adapter = null;
            DataSet dsEmployeeUser = null;

            try
            {
                sql = "select employeeId,email,password from user_table where designation='"+objUser.Designation+"'";
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


   
        //************************** INSERT USER DETAILS ******************************

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

        public static int UpdatePassword(string password, string employeeId)
        {
            int output = 0;
            string sql = "";
            SqlConnection con = null;
            SqlCommand cmd = null;
            try
            {
                sql = "update user_table set password='" + password + "' where employeeId='" + employeeId + "'";

                con = DBHelper.GetConnection();
                con.Open();
                cmd = new SqlCommand(sql, con);
                output = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("Error : FinTrustDL : GetUpdatePassword() " + ex.Message.ToString());
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
