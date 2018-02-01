using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perinta3
{
    class Radio
    {
        int aani;
        double taajuus;

        public bool Onoff
        {
            get;
            set;
        }
        public int Aani
        {
            get
            {
                return aani;
            }
            set
            {
                if (aani <= 9 && aani >= 0)
                {
                    aani = value;
                }
                else if (aani > 9)
                {
                    aani = 9;
                }
                else
                {
                    aani = 0;
                }

            }
        }
        public double Taajuus
        {
            get
            {
                if (taajuus <= 26000 && taajuus >= 2000)
                {
                    return taajuus;
                }
                else if (taajuus > 26000)
                {
                    return 26000;
                }
                else
                {
                    return 2000;
                }
            }
            set
            {
                taajuus = value;
            }

        }
        
    }
}
