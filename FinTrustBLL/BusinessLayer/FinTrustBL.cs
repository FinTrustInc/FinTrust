using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinTrustDLL.DataLayer;
using FinTrustDTO.DTO;
using System.Data;
using FinTrustDLL.Helper;

namespace FinTrustBLL.BusinessLayer
{
	public class FinTrustBL
    {
        //-----------------------------------------------------------------------------------------
        //----------------------

        public static bool CheckEmployeeUser(User objUser)
        {
            bool flag = false;
            DataSet dsEmployeeUser = null;
            try
            {
                dsEmployeeUser = FinTrustDL.GetEmployeeCredentials(objUser);
                Object[] Data = null;

                if (dsEmployeeUser.Tables[0].Rows.Count > 0)
                {
                    Data = dsEmployeeUser.Tables[0].Rows[0].ItemArray;

                    string employeeId = Data[0].ToString();
                    string email = Data[1].ToString();
                    string password = Data[2].ToString();
                   

                    if (objUser.Email== email&& objUser.Password == password)
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                    }

                  SetLoginInfo(employeeId);

                }
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("Error : FinTrustBL:CheckEmployeeUser : " + ex.Message.ToString());
            }
            return flag;
        }

        //------------------------------------------------------------------------------------------
        //------------------------ 

        private static void SetLoginInfo(string employeeId)
        {
            DataSet dsEmployeeUser = null;
            dsEmployeeUser = FinTrustDL.GetEmployeeDetails(employeeId);
            Object[] Data = null;

            if (dsEmployeeUser.Tables[0].Rows.Count > 0)
            {
                Data = dsEmployeeUser.Tables[0].Rows[0].ItemArray;

                string designation = Data[4].ToString();

                LoginInfo.designation = designation;
                LoginInfo.employeeId = employeeId;

            }
        }

        //************************** INSERT USER DETAILS ******************************

        public static int InsertUserDetails(User objUser)
        {
            int output = 0;
            
            try
            {             
                output = FinTrustDL.InsertUserDetails(objUser);
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("******Error:FinTrustBL.cs:InsertUserDetails" + ex.Message.ToString());
            }
           
            return output;
        }

        public static DataSet GetEmployeeDetails(string employeeId)
        {           
            DataSet dsEmployeeUser = null;       
            try
            {
                dsEmployeeUser = FinTrustDL.GetEmployeeDetails(employeeId);                
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("Error : FinTrustBL:GetEmployeeDetails : " + ex.Message.ToString());
            }
            return dsEmployeeUser;
        }

        //----------------------------------------------------------------------------------------
        //---------------------------- Update Password -------------------------------------------

        public static int UpdatePassword(string password, string employeeId)
        {
            int output = 0;
            try
            {
                output = FinTrustDL.UpdatePassword(password, employeeId);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : FinTrustBL : GetUpdatePassword()" + ex.Message.ToString());
            }
            return output;
        }

       
    }
}
