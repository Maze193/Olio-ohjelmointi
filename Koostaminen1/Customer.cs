using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koostaminen1
{
    class Customer : Order
    {
        public string Name { get; set; }

        public List<Order> orders = new List<Order>();

        public Customer()
        {

        }

        public Customer(string name)
        {
            Name = name;
        }

        public void ShowOrders()
        {
            foreach(Order ord in orders)
            {
                Console.WriteLine(Name + " has order number " + ord.ID + " which contains " + ord.Count + " items that are:");
                foreach(OrderItem it in ord.ordersItems)
                {
                    Console.WriteLine(it.OrderName);
                }
            }
        }


    }
}
