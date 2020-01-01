using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinTrustDTO.DTO
{
    public class Loan
    {
        private string loanId;

        public string LoanId
        {
            get { return loanId; }
            set { loanId = value; }
        }
        private string customerId;

        public string CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }
        private string loanType;

        public string LoanType
        {
            get { return loanType; }
            set { loanType = value; }
        }
        private double loanAmount;

        public double LoanAmount
        {
            get { return loanAmount; }
            set { loanAmount = value; }
        }
        private double interestRate;

        public double InterestRate
        {
            get { return interestRate; }
            set { interestRate = value; }
        }

        private int term;

        public int Term
        {
            get { return term; }
            set { term = value; }
        }

        private double netAmount;

        public double NetAmount
        {
            get { return netAmount; }
            set { netAmount = value; }
        }

        private string guarantorName;

        public string GuarantorName
        {
            get { return guarantorName; }
            set { guarantorName = value; }
        }

        private string status;

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        private string date;

        public string Date
        {
            get { return date; }
            set { date = value; }
        }

    }
}
