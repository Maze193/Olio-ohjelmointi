using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrakti6
{
    class Program
    {
        static void Main(string[] args)
        {
            string nimi, kaupunki;
            int x, y;

            Console.WriteLine("Please give rooms size");

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            Room room1 = new Room(x, y);

            Console.WriteLine("Please give houses owners name");
            nimi = Console.ReadLine();

            Console.WriteLine("Please give city where house is");
            kaupunki = Console.ReadLine();

            House house = new House(nimi, kaupunki, room1);

            Console.WriteLine(house.ToString());

        }
    }
}
