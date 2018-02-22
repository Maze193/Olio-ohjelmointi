using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kertaus5
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };

            Console.WriteLine("Sum = " + ArrayCalcs.Sum(array));
            Console.WriteLine("Ave = " + ArrayCalcs.Average(array));
            Console.WriteLine("Min = " + ArrayCalcs.Min(array));
            Console.WriteLine("Max = " + ArrayCalcs.Max(array));

        }
    }
}
