using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koostaminen1
{
    class Order 
    {
        public int ID { get; set; }
        List<OrderItem> ordersItems = new List<OrderItem>();

    }
}
