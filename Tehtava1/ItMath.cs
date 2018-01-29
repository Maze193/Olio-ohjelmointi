using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava1
{
    class ItMath
    {
        //public string syote = "testi";
        /*public string Lukuko
        {
            get
            {
                return syote;
            }

            set
            {
                syote = value;
            }
        }*/

        public static bool OnkoLuku(string syote)
        {
            // = Console.ReadLine();
            double luku = 0;
            bool ol = double.TryParse(syote, out luku);
            return ol;
        }
    }
}
