using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrakti5
{
    class Baby : Human
    {
        public string Diaper { get; set; }

        public override string Move()
        {
            return "Crawling";
        }

        public override string ToString()
        {
            return FirstName + " " + LastName + " " + "diaper:" + Diaper + " " + Height + "cm" + " " + Weight + "kg";
        }
    }
}
