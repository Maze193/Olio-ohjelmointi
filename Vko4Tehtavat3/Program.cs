using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vko4Tehtavat3
{
    class Program
    {
        static void Main(string[] args)
        {
            Amp Amplifier = new Amp();

            while (Amplifier.Vol <= 100 && Amplifier.Vol >= 0)
            {
                Console.Write("Give a new volume value (0-100) > ");
                Amplifier.Vol = int.Parse(Console.ReadLine());
            }
        }
    }
}
