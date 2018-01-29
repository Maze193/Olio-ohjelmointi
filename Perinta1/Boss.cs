using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perinta1
{
    class Boss : Employee
    {
        public string Car { get; set; }
        public int Bonus { get; set; }

        public Boss()
        {

        }

        public Boss(string firstName, string lastName, string profession, string car, int salary, int bonus)
        {
            Bonus = bonus;
            Car = car;
        }

        public override string ToString()
        {
            return base.ToString() + " " + Car + " " + Bonus;
        }
    }
}
