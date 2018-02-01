using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perinta3
{
    class Program
    {
        static void Main(string[] args)
        {
            string vast;
            Radio radio = new Radio();
            Console.WriteLine("Is radio on? y/n");
            vast = Console.ReadLine();
            if (vast == "y")
            {
                radio.Onoff = true;
                Console.WriteLine("How loud is it? 0-9");
                radio.Aani = int.Parse(Console.ReadLine());
                Console.WriteLine("What is the frequency? 2000.0-26000.0");
                radio.Taajuus = double.Parse(Console.ReadLine());

                Console.WriteLine("Radio is on and it's volume is " + radio.Aani + " and frequency is " + radio.Taajuus +".");
            }

        }
    }
}
