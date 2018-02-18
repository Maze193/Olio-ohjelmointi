using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kertaus2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            Product product = new Product("Milk", 1.4);
            products.Add(product);

            product = new Product("Beer", 2.2);
            products.Add(product);

            product = new Product("Butter", 3.2);
            products.Add(product);

            product = new Product("Cheese", 4.2);
            products.Add(product);

            Console.WriteLine("All products in collection:");

            foreach(Product prod in products)
            {
                Console.WriteLine("- product : " + prod.ToString() + " e");
            }

        }
    }
}
