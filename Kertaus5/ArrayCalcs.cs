using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kertaus5
{
    class ArrayCalcs
    {
        

        static public double Sum(double[] arr)
        {
            double z = arr.Sum();
            return z;
        }
        static public double Average(double[] arr)
        {
            double z = arr.Average();
            return z;
        }
        static public double Min(double[] arr)
        {
            double z = arr.Min();
            return z;
        }
        static public double Max(double[] arr)
        {
            double z = arr.Max();
            return z;
        }
    }
}
