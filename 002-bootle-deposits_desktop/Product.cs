using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_bootle_deposits_desktop
{
    public class Product
    {
        String name = "<name_product>";
        double price = 0.00;



        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get => name; set => name = value;}
        public double Price { get => price; set => price = value;}

    }
}
