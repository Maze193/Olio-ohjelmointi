using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perinta2
{
    class Bike : Vehicle
    {
        bool gearwheels;

        public bool GearWheels {
            get
            { 
                return gearwheels;
            }
            set
            {
                gearwheels = value;
            }
        }
        public string GearName { get; set; }

        public Bike()
        {

        }

        public Bike(string name, string model, string color, string gearname, int myear)
        {
            GearName = gearname;
            
        }

        public override string ToString()
        {
            return base.ToString() + " " + "GearWheels: " + GearWheels + " " + "GearName: " + GearName;
        }

    }
}
