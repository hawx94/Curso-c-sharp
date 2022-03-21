using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca.Entities
{
    internal class Product
    {
        public Product()
        {
        }

        public string Name { get; set; }
        public double price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            this.price = price;
        }








    }
}
