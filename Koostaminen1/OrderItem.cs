using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koostaminen1
{
    class OrderItem
    {
        public string OrderName { get; set; }

        public int Count { get; set; }

        public OrderItem()
        { }
        public OrderItem(string orname)
        {
            OrderName = orname;
        }

    }
}
