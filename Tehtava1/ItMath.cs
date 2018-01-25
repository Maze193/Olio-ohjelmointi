using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava1
{
    class ItMath
    {
        
        public static bool OnkoLuku(string syote)
        {
            bool ol;
            int luku = 0;
            ol = int.TryParse(syote, out luku);
            return ol;
        }
    }
}
