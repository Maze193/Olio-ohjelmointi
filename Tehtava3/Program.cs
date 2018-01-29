using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava3
{
    class Program
    {
        static void Main(string[] args)
        {
            ItParser parser = new ItParser();
            string syo;

            Console.WriteLine("Please give numbers separated with commas");
            syo = Console.ReadLine();

            parser.Count(syote: syo);
            parser.Sum(syote: syo);
            parser.Average(syote: syo);

            Console.Write("In the string " + syo);

            parser.Announcement();

            Console.ReadLine();
        }
    }
}
