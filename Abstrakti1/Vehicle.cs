﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrakti1
{
    class Vehicle : Tyre
    {
        
        public string Name { get; set; }

        public string Model { get; set; }

        public Vehicle()
        {

        }

        public Vehicle(string name, string model)
        {
            Name = name;
            Model = model;
        }


    }
}
