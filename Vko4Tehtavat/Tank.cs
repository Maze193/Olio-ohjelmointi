﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vko4Tehtavat
{
    class Tank
    {
        public string name, type;
        float speedm = 100, speed;
        public int crewc;


        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }

        private float SpeedMax
        {
            get
            {
                return speedm;
            }
        }
        

        public int CrewCount
        {
            get
            {
                return crewc;
            }

            set
            {

                crewc = value;

                if(crewc > 6)
                {
                    Console.WriteLine("There can't be more than six crew members. Dropping some people off...");
                    crewc = 6;
                }

                if (crewc < 2)
                {
                    Console.WriteLine("There needs to be at least two crew members. Recruiting more members...");
                    crewc = 2;
                }
            }
        }

        private float Speed
        {
            get
            {
                //speed = 0;
                return speed;
            }

            set
            {
                speed = value;
            }

        }

        public float AccelerateTo(float spee)
        {
            for (int i = 0; i < spee; i++)
            {
                speed++;
            }

            if (speed > SpeedMax)
            {
                Console.WriteLine("Too much speed. Slowing down to maximum speed...");
                speed = SpeedMax;
            }

            return speed;
        }

        public float SlowTo(float slow)
        {
            for (int i = 0; i < slow; i++)
            {
                speed--;
            }

            if (speed < 0)
            {
                Console.WriteLine("Speed too small setting it to zero...");
                speed = 0;
            }

            return speed;
        }

    }
}
