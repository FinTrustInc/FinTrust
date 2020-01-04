using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinTrustDTO.DTO
{
    public class Grievance
    {
        private string customerId;

        public string CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }
        private string grievanceID;

        public string GrievanceID
        {
            get { return grievanceID; }
            set { grievanceID = value; }
        }
        private string grievanceDetail;

        public string GrievanceDetail
        {
            get { return grievanceDetail; }
            set { grievanceDetail = value; }
        }

        private string customerName;

        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }
        private string accountNumber;

        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }
        private string accountType;

        public string AccountType
        {
            get { return accountType; }
            set { accountType = value; }
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
        private string status;

        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
    }
}
