using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vko4Tehtavat
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Tank TestTank = new Tank();

            Console.WriteLine("Please give tanks name");
            TestTank.Name = Console.ReadLine();

            Console.WriteLine("Please give tank type");
            TestTank.Type = Console.ReadLine();

            Console.WriteLine("Please give crew count");
            TestTank.CrewCount = int.Parse(Console.ReadLine());

            Console.WriteLine("How much would you like to accelerate?");
            int spee = int.Parse(Console.ReadLine());
            TestTank.AccelerateTo(spee);

            Console.WriteLine("How much would you like to decelerate?");
            int slow = int.Parse(Console.ReadLine());
            TestTank.SlowTo(slow);

            int vel = spee - slow;

            if(spee > 100)
            {
                vel = 100 - slow;
            }

            if (vel < 0)
            {
                vel = 0;
            }

            Console.WriteLine("The tanks name is: " + TestTank.Name);
            Console.WriteLine("The type is: " + TestTank.Type);
            Console.WriteLine("The crew count is: " + TestTank.CrewCount);
            Console.WriteLine("The speed is: " + vel);

            Console.ReadLine();

        }
    }
}
