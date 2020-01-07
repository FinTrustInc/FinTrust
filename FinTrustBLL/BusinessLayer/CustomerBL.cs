using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinTrustDLL.DataLayer;
using FinTrustDLL.Helper;
using FinTrustDTO.DTO;

namespace FinTrustBLL.BusinessLayer
{
    public class CustomerBL
    {
        //-----------------------------------------------------------------------------------
        //----------------------- get Account Details using Account Number ------------------

        public static Customer GetCustomerByAccountNumber(string accountNumber)
        {          
            Customer customerObj = null;
            try
            {
                customerObj = CustomerDL.GetCustomerByAccountNumber(accountNumber);
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("Error : CustomerBL:GetCustomerByAccountNumber : " + ex.Message.ToString());
            }          
            return customerObj;
        }

        //------------------------------------------------------------------------------------------
        //------------- Get Last Customer Id for generating new Customer Id for customers ----------

        public static string GetNewCustomerId()
        {
            string lastCustomerId = null;
            string newCustomerId = null;
            try
            {
                lastCustomerId = CustomerDL.GetLastCustomerId();
                if (lastCustomerId != null)
                {
                    newCustomerId = UtilityHelper.GenerateCustomerId(lastCustomerId);
                }
                else
                {
                    newCustomerId = "1001";
                }
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("Error : CustomerBL : GetNewCustomerId() " + ex.Message.ToString());
            }
            return newCustomerId;
        }

        //------------------------------------------------------------------------------------------
        //------------- Get Last Account No for generating new account No for customers ------------

        public static string GetNewAccountNumber()
        {
            string lastAccountNumber = null;
            string newAccountNumber = null;
            try
            {
                lastAccountNumber = CustomerDL.GetLastAccountNumber();
                if (lastAccountNumber != null)
                {
                    newAccountNumber = UtilityHelper.GenerateAccountNumber(lastAccountNumber);
                }
                else
                {
                    newAccountNumber = "100001";
                }
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("Error : CustomerBL : GetNewAccountNumber() " + ex.Message.ToString());
            }
            return newAccountNumber;
        }

        //-----------------------------------------------------------------------------------------
        //----------------- Insert New Customer Details -------------------------------------------

        public static int InsertCustomerDetails(Customer objCustomer)
        {
            int output = 0;
            
            try
            {
               
                output = CustomerDL.InsertCustomerDetails(objCustomer);
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("******Error:CustomerBL.cs:InsertCustomerDetails" + ex.Message.ToString());
            }
            
            return output;
        }

        //------------------------------------------------------------------------------------
        //----------------------- Delete Customer Account ------------------------------------

        public static int DeleteAccountDetails(string accountNumber)
        {
            int output = 0;
            
            try
            {
                
                output = CustomerDL.DeleteAccountDetails(accountNumber);
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("******Error:CustomerBL.cs:DeleteAccountDetails" + ex.Message.ToString());
            }
            return output;
        }


    }
}
