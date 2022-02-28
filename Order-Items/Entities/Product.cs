using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Entities
{
    internal class Product
    {
        public string Name;
        public double Price;

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }

}
