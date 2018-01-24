using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vko4Tehtavat2
{
    class Hissi
    {
        private int floor = 1;

        public int Floor
        {
            get
            {
                return floor;
            }

            set
            {
                if (value > 0 && value < 6)
                {
                    floor = value;
                }

                else if (value < 1)
                {
                    Console.WriteLine("Floor is too small!");
                }

                else if (value > 5)
                {
                    Console.WriteLine("Floor is too big!");
                }

                else
                {
                    Console.WriteLine("wat?");
                }
            }
        }
        
    }
}
