﻿namespace KursL
{
    public class Product
    {
        public string Name;
        public int MinSales;
        public int MaxSales;
        public decimal Price;

        public Product()
        {
        }

        public Product(string name, int minSales, int maxSales, decimal price)
        {
            Name = name;
            MinSales = minSales;
            MaxSales = maxSales;
            Price = price;
        }
    }
}
