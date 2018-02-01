using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perinta2
{
    class Program
    {
        static void Main(string[] args)
        {
            Boat boat = new Boat();
            Bike bike1 = new Bike();
            Bike bike2 = new Bike();

            string an;

           /* Console.WriteLine("Give boat and two bikes");

            Console.WriteLine("Give boats name");
            boat.Name = Console.ReadLine();

            Console.WriteLine("Give boats model");
            boat.Model = Console.ReadLine();

            Console.WriteLine("Give boats color");
            boat.Color = Console.ReadLine();

            Console.WriteLine("Give boats type");
            boat.BoatType = Console.ReadLine();

            Console.WriteLine("Give boats model year");
            boat.ModelYear = int.Parse(Console.ReadLine());

            Console.WriteLine("Give boats seat count");
            boat.SeatCount = int.Parse(Console.ReadLine());

            Console.WriteLine("Give first bikes name");
            bike1.Name = Console.ReadLine();

            Console.WriteLine("Give first bikes model");
            bike1.Model = Console.ReadLine();

            Console.WriteLine("Give first bikes color");
            bike1.Color = Console.ReadLine();

            Console.WriteLine("Does first bike have gearwheels? y/n");
            an = Console.ReadLine();
            if (an == "y")
            {
                Console.WriteLine("Give first bikes gear name");
                bike1.GearName = Console.ReadLine();

                bike1.GearWheels = true;
            }
            else
            {
                bike1.GearWheels = false;
            }

            Console.WriteLine("Give first bikes model year");
            bike1.ModelYear = int.Parse(Console.ReadLine());*/


            Console.WriteLine("Give second bikes name");
            bike2.Name = Console.ReadLine();

            Console.WriteLine("Give second bikes model");
            bike2.Model = Console.ReadLine();

            Console.WriteLine("Give second bikes color");
            bike2.Color = Console.ReadLine();

            Console.WriteLine("Does second bike have gearwheels? y/n");
            an = Console.ReadLine();
            if (an == "y")
            {
                Console.WriteLine("Give second bikes gear name");
                bike2.GearName = Console.ReadLine();

                bike2.GearWheels = true;
            }
            else
            {
                bike2.GearWheels = false;
            }

            Console.WriteLine("Give second bikes model year");
            bike2.ModelYear = int.Parse(Console.ReadLine());

            Console.WriteLine(boat.ToString() + "\n");
            Console.WriteLine(bike1.ToString() + "\n");
            Console.WriteLine(bike2.ToString());
            Console.ReadLine();
        }
    }
}
