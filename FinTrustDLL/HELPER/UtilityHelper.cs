using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinTrustDLL.Helper
{
	public  class UtilityHelper
	{
        //----------------------------------------------------------------------------------
        //--------------- Generate New Transaction Id for next Transaction -----------------

		public static string GenerateTransactionId(string oldID)
		{
			string prefix, suffix;
			int next;
			string newTransactionID = null;
			try
			{
				prefix = oldID.Substring(0, 3);
				suffix = oldID.Substring(3);
				next = Convert.ToInt32(suffix) + 1;
				newTransactionID = prefix + next;
			}
			catch (Exception e3)
			{
				Console.Out.WriteLine("Error : UtilityHelper : GenerateTransactionId" + e3.Message.ToString());

			}
			return newTransactionID;
		}

        //----------------------------------------------------------------------------------
        //--------------- Generate New Loan Id for next Loan Application -------------------

        public static string GenerateLoanId(string oldID)
        {
            string prefix, suffix;
            int next;
            string newLoanID = null;
            try
            {
                prefix = oldID.Substring(0, 2);
                suffix = oldID.Substring(2);
                next = Convert.ToInt32(suffix) + 1;
                newLoanID = prefix + next;
            }
            catch (Exception e3)
            {
                Console.Out.WriteLine("Error : UtilityHelper : GenerateLoanId" + e3.Message.ToString());

            }
            return newLoanID;
        }

        //*************************************** AUTO GENERATING CUSTOMER ID ************************************

        public static string GenerateCustomerId(string oldID)
        {            
            int next;
            string newCustomerID = null;
            try
            {
                next = Convert.ToInt32(oldID) + 1;
                newCustomerID = next.ToString();
            }
            catch (Exception e3)
            {
                Console.Out.WriteLine("Error : UtilityHelper : GenerateCustomerId" + e3.Message.ToString());

            }
            return newCustomerID;
        }

        //*************************************** AUTO GENERATING ACCOUNT NUMBER ************************************

        public static string GenerateAccountNumber(string oldAccountNumber)
        {
           
            int next;
            string newAccountNumber = null;
            try
            {              
                next = Convert.ToInt32(oldAccountNumber) + 1;
                newAccountNumber = next.ToString();
            }
            catch (Exception e3)
            {
                Console.Out.WriteLine("Error : UtilityHelper : GenerateAccountNumber" + e3.Message.ToString());

            }
            return newAccountNumber;
        }
    }
}
