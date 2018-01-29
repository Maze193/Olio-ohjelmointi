using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perinta2
{
    class Bike : Vehicle
    {
        
        public bool GearWheels { get; set; }
        public string GearName(string gearName)
        {
           
           if (GearWheels == false)
           {
                return "";
           }
           else
           {
               return gearName;
           }
        }

    }
}
