﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinTrustDTO.DTO
{
  
    public class User
    {
        private string employeeId;

        public string EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }
        private string employeeName;

        public string EmployeeName
        {
            get { return employeeName; }
            set { employeeName = value; }
        }
        private string dateOfBirth;

        public string DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }
        private string gender;

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        private string designation;

        public string Designation
        {
            get { return designation; }
            set { designation = value; }
        }
        private long phone;

        public long Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        private long aadharNumber;

        public long AadharNumber
        {
            get { return aadharNumber; }
            set { aadharNumber = value; }
        }
        private string panNumber;

        public string PanNumber
        {
            get { return panNumber; }
            set { panNumber = value; }
        }
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

    }

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