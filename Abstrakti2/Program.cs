using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrakti2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Thing> things = new List<Thing>();
            string it;

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Give item in fridge");
                it = Console.ReadLine();
                things.Add(new Thing(it));

            }

            Console.WriteLine("Fridge has: ");

            foreach (Thing thing in things)
            {
                Console.WriteLine(thing.Name);
            }
        }
    }
}
