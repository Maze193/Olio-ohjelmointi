using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kertaus4
{
    class Square : Shape
    {
        string name = "Rectangle";
        double x, y;

        public override string Name { get { return name; }}

        public override double Area()
        {
            Console.WriteLine("Give rectangles sides");

            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());

            double z = x * y;
            return z;
        }

        public override double Circumference()
        {
            double z = x + x + y + y;
            return z;
        }
    }
}
