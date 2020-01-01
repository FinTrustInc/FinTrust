using FinTrustDLL.DataLayer;
using FinTrustDLL.Helper;
using FinTrustDTO.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinTrustBLL.BusinessLayer
{
    public class LoanBL
    {
 
        public static Customer GetCustomerById(string customerId)
        {

            Customer customerObj = null;
            try
            {
                customerObj = LoanDL.GetCustomerById(customerId);

            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("Error : LoanBL:GetCustomerById : " + ex.Message.ToString());
            }


            return customerObj;
        }

        public static string GetNewLoanId()
        {
            string lastLoanId = null;
            string newLoanId = null;
            try
            {
                lastLoanId = LoanDL.GetLastLoanId();
                if (lastLoanId != null)
                {
                    newLoanId = UtilityHelper.GenerateLoanId(lastLoanId);
                }
                else
                {
                    newLoanId = "LN1001";
                }
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("Error : LoanBL : GetNewLoanId() " + ex.Message.ToString());
            }
            return newLoanId;
        }

        public static int InsertLoanDetails(Loan InsertLoanDetails)
        {
            int output = 0;
            try
            {
                output = LoanDL.InsertLoanDetails(InsertLoanDetails);
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("Error : LoanBL:InsertLoanDetails : " + ex.Message.ToString());
            }

            return output;

        }

        public static DataSet GetLoanDetails()
        {


            DataSet dsLoans = null;
            try
            {
                dsLoans = LoanDL.GetLoanDetails();

            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("Error : LoanBL:GetLoanDetails : " + ex.Message.ToString());
            }


            return dsLoans;
        }



    }


}
