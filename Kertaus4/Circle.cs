using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kertaus4
{
    class Circle : Shape
    {
        string name = "Circle";
        double x, y;

        public override string Name { get { return name; } }

        public override double Area()
        {
            Console.WriteLine("Give radius");
            x = double.Parse(Console.ReadLine());
            y = 3.14 * x;
            return y;
        }

        public override double Circumference()
        {
            y = x * 2 * 3.14;
            return y;
        }

    }
}
