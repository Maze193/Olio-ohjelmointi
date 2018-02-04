using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrakti5
{
    class Adult : Human
    {
        public string Car { get; set; }

        public override string Move()
        {
            return "Walking";
        }

        public override string ToString()
        {
            return FirstName + " " + LastName + " " + Car + " " + Height + "cm" + " " + Weight + "kg";
        }
    }
}
