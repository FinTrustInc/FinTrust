using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinTrustDSL.Helper
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
	}
}
