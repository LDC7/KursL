namespace KursL
{
    public class Employee
    {
        public string Name;
        public int Num;
        public decimal Salary;

        public Employee()
        {
        }

        public Employee(string name, int num, decimal salary)
        {
            Name = name;
            Num = num;
            Salary = salary;
        }

        public decimal SumSalary
        {
            get
            {
                return Num * Salary;
            }
        }        
    }
}
