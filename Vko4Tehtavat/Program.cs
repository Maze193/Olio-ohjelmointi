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

            TestTank.Name = "Testi";
            TestTank.Type = "ASD123";
            TestTank.CrewCount = 5;

            Console.WriteLine("How much would you like to accelerate?");
            int spee = int.Parse(Console.ReadLine());
            TestTank.AccelerateTo(spee);

            Console.WriteLine("How much would you like to decelerate?");
            int slow = int.Parse(Console.ReadLine());
            TestTank.SlowTo(slow);

            Console.WriteLine("The tanks name is: " + TestTank.Name);
            Console.WriteLine("The type is: " + TestTank.Type);
            Console.WriteLine("The crew count is; " + TestTank.CrewCount);
            Console.WriteLine("The speed is: " );

        }
    }
}
