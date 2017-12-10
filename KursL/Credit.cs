using System;

namespace KursL
{
    public class Credit
    {
        public DateTime TakeDate;
        public DateTime RepayDate;
        public decimal Loan;
        public decimal Percent;

        public Credit()
        {
        }

        public Credit(DateTime take, DateTime repay, decimal loan, decimal percent)
        {
            TakeDate = take;
            RepayDate = repay;
            Loan = loan;
            Percent = percent;
        }

        public decimal MonthlyPayment
        {
            get
            {
                return Loan * (100 + Percent) / ((RepayDate.Year - TakeDate.Year) * 12 + RepayDate.Month - TakeDate.Month);
            }
        }
    }
}
