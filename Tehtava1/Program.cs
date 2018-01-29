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
            //bool t = true;
            

            Console.WriteLine("Give a string to see if it is a number");
            string syo = Console.ReadLine();

            math.OnkoLuku(syote:syo);

        }
    }
}
