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
        //--------------------------------------------------------------------------------
        //------------------- Get Customer Details By Customer Id ------------------------

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

        //----------------------------------------------------------------------------------
        //---------- Generate New Loan Id for next -----------------------------------------

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

        //------------------------------------------------------------------------------------------
        //----------------------- Insert Loan Details ----------------------------------------------

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

        //-----------------------------------------------------------------------------------------
        //------------------------------- Get Loan Details ----------------------------------------
        
        public static DataSet GetLoanDetails(string loanId)
        {
            DataSet dsLoans = null;
            try
            {
                dsLoans = LoanDL.GetLoanDetails(loanId);

            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("Error : LoanBL:GetLoanDetails : " + ex.Message.ToString());
            }
            return dsLoans;
        }

        //----------------------------------------------------------------------------------------
        //--------------- Get basic Loan Details -------------------------------------------------

        public static DataSet GetBasicLoanDetails()
        {
            DataSet dsLoans = null;
            try
            {
                dsLoans = LoanDL.GetBasicLoanDetails();

            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("Error : LoanBL:GetBasicLoanDetails : " + ex.Message.ToString());
            }
            return dsLoans;
        }

        //-------------------------------------------------------------------------------
        //------------------------ Update Loan Status -----------------------------------

        public static int UpdateLoanStatus(string loanId,string status)
        {
            int output = 0;

            output = LoanDL.UpdateLoanStatus(loanId, status);          
            return output;
        }

        //--------------------------------------------------------------------------------------
        //-------------- Search for Loan Details -----------------------------------------------

        public static DataSet GetLoansLike(string likeName, string searchOption)
        {

            DataSet dsLoans = null;
            try
            {
                dsLoans = LoanDL.GetLoansLike(likeName, searchOption);
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("Error : FinTrustBL:GetLoansLike : " + ex.Message.ToString());
            }

            return dsLoans;
        }
    }
}
