using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinTrustDTO.DTO
{

    public class Customer
    {
        private string customerId;

        public string CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }
        private string accountNumber;

        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }
        private string customerName;

        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }
        private string dateOfAccount;

        public string DateOfAccount
        {
            get { return dateOfAccount; }
            set { dateOfAccount = value; }
        }
        private string accountType;

        public string AccountType
        {
            get { return accountType; }
            set { accountType = value; }
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
        private double phone;

        public double Phone
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
        private double aadharNumber;

        public double AadharNumber
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

    }
}
