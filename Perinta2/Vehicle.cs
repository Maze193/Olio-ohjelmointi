using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perinta2
{
    class Vehicle
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int ModelYear { get; set; }

        public Vehicle()
        {
        }

        // constructor takes vehicles data as a parameters
        public Vehicle(string name, string model, string color, int myear)
        {
            Name = name;
            Model = model;
            Color = color;
            ModelYear = myear;
        }

        // return vehicle data as a one string, override Object class ToString()-method
        public override string ToString()
        {
            return "Name: " + Name + " " + "Model: " + Model + " " + "ModelYear: " + ModelYear + " " + "Color: " + Color;
        }
    }
}
