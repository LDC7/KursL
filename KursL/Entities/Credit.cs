using System;

namespace KursL
{
    public class Credit
    {
        public DateTime TakeDate;
        public DateTime RepayDate;
        public decimal Loan;
        public decimal Percent;
        private decimal monthly;
        private int months;

        public Credit()
        {
        }

        public Credit(DateTime take, DateTime repay, decimal percent, decimal loan)
        {
            TakeDate = take;
            RepayDate = repay;
            Loan = loan;
            Percent = percent;
            months = ((RepayDate.Year - TakeDate.Year) * 12 + RepayDate.Month - TakeDate.Month);
            monthly = Math.Round(Loan * (100 + Percent) / months, 2);
        }

        public decimal MonthlyPayment(DateTime date)
        {
            if (date.CompareTo(TakeDate) >= 0 && date.CompareTo(RepayDate) <= 0)
            {
                if (date.Month != RepayDate.Month && date.Day != RepayDate.Day)
                {
                    return monthly;
                }
                else
                {
                    return Loan * (100 + Percent) - ((months - 1) * monthly);
                }
            }

            return 0;
        }
    }
}
