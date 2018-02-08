using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koostaminen1
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer("Pera");
            
            OrderItem rderName = new OrderItem("Banaani");
            OrderItem rderName2 = new OrderItem("Omena");
            Order order = new Order(404, rderName);
            Order order2 = new Order(405, rderName2);

            //Peran tilaukset
            for (int i = 0; i < 10; i++)
            {
                order.ordersItems.Add(rderName);
                order.Count++;
            }

            customer.orders.Add(order);

            for (int i = 0; i < 4; i++)
            {
                order2.ordersItems.Add(rderName2);
                order2.Count++;
            }

            customer.orders.Add(order2);

            customer.ShowOrders();

            rderName = new OrderItem("Maksalaatikko");
            rderName2 = new OrderItem("Porkkanalaatikko");
            order = new Order(123, rderName);
            order2 = new Order(223, rderName2);
            customer = new Customer("Noora");

            //Nooran tilaukset
            for (int i = 0; i < 10; i++)
            {
                order.ordersItems.Add(rderName);
                order.Count++;
            }

            customer.orders.Add(order);

            for (int i = 0; i < 4; i++)
            {
                order2.ordersItems.Add(rderName2);
                order2.Count++;
            }

            customer.orders.Add(order2);

            customer.ShowOrders();

        }
    }
}
