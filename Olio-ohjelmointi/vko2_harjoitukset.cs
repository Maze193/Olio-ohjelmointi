using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio_ohjelmointi
{
    class vko2_harjoitukset
    {
        static void Main(string[] args)
        {
            //Tehtävä 1
            int number;
            Console.Write("Give a number between 1 and 3");
            do
            {
                number = int.Parse(Console.ReadLine());
            } while (number < 3 || number > 1);
            Console.WriteLine("Number is " + number);
            
        }
    }
}
