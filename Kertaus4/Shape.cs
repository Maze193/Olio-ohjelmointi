using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kertaus4
{
    abstract class Shape
    {
        public abstract string Name { get; }
        public abstract double Area();
        public abstract double Circumference();
    }
}
