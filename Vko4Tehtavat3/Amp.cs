using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vko4Tehtavat3
{
    class Amp
    {
        private int vol;

        public int Vol
        {
            get
            {
                return vol;
            }

            set
            {
                if (value >= 0 && value <= 100)
                {
                    vol = value;
                    Console.WriteLine("Amplifier volume is set to : " + vol);
                }

                else if (value < 0)
                {
                    Console.WriteLine("Too low volume - Amplifier volume is set to minimum : 0");
                    vol = 0;
                }

                else if (value > 100)
                {
                    Console.WriteLine("Too much volume -  Amplifier volume is set to maximum : 100");
                    vol = 100;
                }

                else
                {
                    Console.WriteLine("wat?");
                }
            }
        }

    }
}
