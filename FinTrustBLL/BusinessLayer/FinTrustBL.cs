using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using FinTrustDLL.DataLayer;
using FinTrustDTO.DTO;
using FinTrustDLL.Helper;

namespace FinTrustBLL.BusinessLayer
{
	public class FinTrustBL
    {
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

                    string email = Data[0].ToString();
                    string password = Data[1].ToString();

                    if(objUser.Email== email&& objUser.Password == password)
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                    }

                }
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("Error : FinTrustBL:CheckEmployeeUser : " + ex.Message.ToString());
            }
            return flag;
        }


        public static int InsertTransactionDetails(Transaction objTransaction)
		{
			int output = 0;
			try
			{
				output = FinTrustDL.InsertTransactionDetails(objTransaction);
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error : FinTrustBL : InsertTransactionDetails()" + ex.Message.ToString());
			}
			return output;
		}
		public static string GetNewTransactionId()
		{
			string lastTransactionId = null;
			string newTransactionId = null;
			try
			{
				lastTransactionId = FinTrustDL.GetLastTransactionId();
				if (lastTransactionId != null)
				{
					newTransactionId = UtilityHelper.GenerateTransactionId(lastTransactionId);
				}
				else
				{
					newTransactionId = "TRA1001";
				}
			}
			catch (Exception ex)
			{
				Console.Out.WriteLine("Error : FinTrustBL : GetNewTransactionId() " + ex.Message.ToString());
			}
			return newTransactionId;
		}
		public static Customer GetNameByAccountNumber(string accountNumber)
		{
			Customer objCustomer = null;
			try
			{
				objCustomer = FinTrustDL.GetNameByAccountNumber(accountNumber);
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error : FinTrustBL : GetNameByAccountNumber()" + ex.Message.ToString());
			}
			return objCustomer;
		}
       
    }
}
