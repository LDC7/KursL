using System;
using System.Collections.Generic;

namespace KursL
{
    public class Project
    {
        public string Name;
        public decimal Investments;
        public List<Credit> Credits;
        public List<Employee> Employees;
        public List<Product> Products;
        public List<Cost> Costs;
        public DateTime PeriodStart;
        public DateTime PeriodEnd;

        public Project()
        {
        }

        public void RecreateCompany(string name)
        {
            Name = name;
            Investments = 0;
            Credits = new List<Credit>();
            Employees = new List<Employee>();
            Products = new List<Product>();
            Costs = new List<Cost>();
        }

        public decimal Salaries()
        {
            decimal salaries = 0;

            foreach (var i in Employees)
            {
                salaries += i.SumSalary;
            }

            return salaries;
        }

        public decimal Sales(int volume)
        {
            decimal sales = 0;

            foreach (var i in Products)
            {
                sales += (i.Price * Math.Round(((i.MaxSales - i.MinSales) * (volume / 100m)) + i.MinSales));
            }

            return sales;
        }

        public decimal Sales()
        {
            decimal sales = 0;
            var r = new Random();
            decimal volume;

            foreach (var i in Products)
            {
                volume = r.Next(0, 100);
                sales += (i.Price * (((i.MaxSales - i.MinSales) * (volume / 100m)) + i.MinSales));
            }

            return sales;
        }

        public decimal LoanPayments(DateTime date)
        {
            decimal pay = 0.00m;

            foreach (var c in Credits)
            {
                pay += c.MonthlyPayment(date);
            }

            return pay;
        }

        public decimal CostPayments(DateTime date)
        {
            decimal pay = 0.00m;

            foreach (var c in Costs)
            {
                if ((c.Start == null || date.CompareTo(c.Start) >= 0) && (c.Start == null || date.CompareTo(c.End) <= 0))
                {
                    pay += c.MonthlyCost;
                }
            }

            return pay;
        }

        public decimal Loan(DateTime date)
        {
            decimal loan = 0.00m;

            foreach (var c in Credits)
            {
                if (date.Month == c.TakeDate.Month && date.Year == c.TakeDate.Year)
                {
                    loan += c.Loan;
                }
            }

            return loan;
        }

        public decimal reloan(DateTime date)
        {
            decimal loan = 0.00m;

            foreach (var c in Credits)
            {
                if (date.Month == c.TakeDate.Month && date.Year == c.TakeDate.Year)
                {
                    loan += c.Loan * ((100m + c.Percent) / 100m);
                }
            }

            return loan;
        }
    }
}
