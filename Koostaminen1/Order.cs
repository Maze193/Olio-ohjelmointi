using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koostaminen1
{
    class Order : OrderItem
    {
        public int ID { get; set; }
        public List<OrderItem> ordersItems = new List<OrderItem>();

        public OrderItem item;

        public Order()
        {

        }

        public Order(int id, OrderItem ite)
        {
            item = ite;
            ID = id;
        }

    }
}
