using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vko4Tehtavat2
{
    class Program
    {
        static void Main(string[] args)
        {
            Hissi Hissi = new Hissi();

            while (Hissi.Floor < 6 && Hissi.Floor > 0)
            {
                Console.Write("Please give a new floor number (1-5) > ");

                Hissi.Floor = int.Parse(Console.ReadLine());

                Console.WriteLine("Elevator is now in floor: " + Hissi.Floor);
            }
        }
    }
}
