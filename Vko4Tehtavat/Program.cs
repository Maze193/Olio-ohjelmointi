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

            TestTank.Name = Console.ReadLine();
            TestTank.Type = Console.ReadLine();
            TestTank.CrewCount = int.Parse(Console.ReadLine());
            //crewc = TestTank.CrewCount;
            TestTank.AccelerateTo();

        }
    }
}
