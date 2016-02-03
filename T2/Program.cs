using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            Milk milk = new Milk();
            Beer beer = new Beer();
            Butter butter = new Butter();
            Cheese cheese = new Cheese();

            products.Add(milk);
            products.Add(beer);
            products.Add(butter);
            products.Add(milk);
            products.Add(butter);
            products.Add(cheese);
            products.Add(cheese);

            Console.WriteLine("Contents of bag:");
            foreach(Product p in products)
            {
                Console.WriteLine(p.ToString());
            }
        }
    }
}
