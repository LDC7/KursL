using System;

namespace KursL
{
    public class Cost
    {
        public string Name;
        public DateTime? Start;
        public DateTime? End;
        public decimal MonthlyCost;

        public Cost()
        {
        }

        public Cost(string name, DateTime? start, DateTime? end, decimal cost)
        {
            Name = name;
            Start = start;
            End = end;
            MonthlyCost = cost;
        }
    }
}
