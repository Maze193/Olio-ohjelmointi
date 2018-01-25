using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava1
{
    class Program
    {
        static void Main(string[] args)
        {
            ItMath math = new ItMath();
            string str;

            Console.WriteLine("Give a string to see if it is a number");
            str = Console.ReadLine();

            math.OnkoLuku() = str;

            if (math.OnkoLuku() = true)
            {

            }
        }
    }
}
