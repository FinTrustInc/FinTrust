﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinTrustDSL.DataServiceLayer;
using FinTrustDTO.DataTransferObject;
using FinTrustDSL.Helper;

namespace FinTrustBLL.BusinessLayer
{
	public class FinTrustBL
	{
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
					newTransactionId = "TRA12101";
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