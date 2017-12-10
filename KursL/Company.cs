using System.Collections.Generic;

namespace KursL
{
    public class Company
    {
        public string Name;
        public decimal StartCapital;
        public List<Credit> Credits;
        public List<Employee> Employees;
        public List<Product> Products;

        public Company()
        {
        }

        public void RecreateCompany(string name)
        {
            Name = name;
            StartCapital = 0;
            Credits = new List<Credit>();
            Employees = new List<Employee>();
            Products = new List<Product>();
        }
    }
}
