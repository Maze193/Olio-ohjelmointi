using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kertaus4
{
    abstract class Shape
    {
        protected abstract string Name { get; set; }
        protected abstract double Area();
        protected abstract double Circumference();
    }
}
