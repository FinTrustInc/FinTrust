using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinTrustDLL.Helper
{
	public  class UtilityHelper
	{
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

        public static string GenerateCustomerId(string oldID)
        {
            string prefix, suffix;
            int next;
            string newCustomerID = null;
            try
            {
                prefix = oldID.Substring(0, 3);
                suffix = oldID.Substring(3);
                next = Convert.ToInt32(suffix) + 1;
                newCustomerID = prefix + next;
            }
            catch (Exception e3)
            {
                Console.Out.WriteLine("Error : UtilityHelper : GenerateCustomerId" + e3.Message.ToString());

            }
            return newCustomerID;
        }

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
