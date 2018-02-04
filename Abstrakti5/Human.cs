using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrakti5
{
    class Human : Mammal
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long Height { get; set; }
        public int Weight { get; set; }

        public override string Move()
        {
            return "Moving";
        }

        public int Grow()
        {
            return Age++;
        }

        public override string ToString()
        {
            return FirstName + " " + LastName + " " + Height + "cm" + " " + Weight + "kg";
        }
    }
}
