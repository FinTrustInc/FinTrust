using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinTrustDTO.DTO
{
	public class Transaction
	{
		private string transactionId;

		public string TransactionId
		{
			get { return transactionId; }
			set { transactionId = value; }
		}
		private string transactionType;

		public string TransactionType
		{
			get { return transactionType; }
			set { transactionType = value; }
		}
		private string transactionDate;

		public string TransactionDate
		{
			get { return transactionDate; }
			set { transactionDate = value; }
		}
		private double transactionAmount;

		public double TransactionAmount
		{
			get { return transactionAmount; }
			set { transactionAmount = value; }
		}
		private double balanceAmount;

		public double BalanceAmount
		{
			get { return balanceAmount; }
			set { balanceAmount = value; }
		}

		private string accountNumber;

		public string AccountNumber
		{
			get { return accountNumber; }
			set { accountNumber = value; }
		}

	}
}
