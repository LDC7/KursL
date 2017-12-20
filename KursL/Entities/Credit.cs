using System;

namespace KursL
{
    public class Credit
    {
        public DateTime TakeDate;
        public DateTime RepayDate;
        public decimal Loan;
        public decimal Percent;
        public decimal monthly;
        public int months;

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
            monthly = Math.Round(((Loan * ((100m + Percent) / 100)) / months), 2);
        }

        public decimal MonthlyPayment(DateTime date)
        {
            if (date.CompareTo(TakeDate) > 0 && date.CompareTo(RepayDate) <= 0)
            {
                if (date.Month != RepayDate.Month || date.Year != RepayDate.Year)
                {
                    return monthly;
                }
                else
                {
                    return (Loan * ((100 + Percent) / 100)) - ((months - 1) * monthly);
                }
            }

            return 0;
        }
    }
}
