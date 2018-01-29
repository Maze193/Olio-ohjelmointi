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
            //ItMath math = new ItMath();
            //bool t = true;
            

            Console.WriteLine("Give a string to see if it is a number");
            string syo = Console.ReadLine();

            if (ItMath.OnkoLuku(syote:syo) == true)
            {
                Console.WriteLine("It is a number!");
            }

            else
            {
                Console.WriteLine("It is not a number... ");
            }

            Console.ReadLine();
        }
    }
}
