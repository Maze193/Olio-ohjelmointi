using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vko4Tehtavat
{
    class Tank
    {
        public string name, type;
        float speed, speedm = 100;
        public int crewc;


        public string Name
        {
            get
            {
                return name;
            }

            set
            {

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
                CrewCount = crewc;

                if(CrewCount > 6)
                {
                    Console.WriteLine("There can't be more than six crew members");
                }

                if (CrewCount < 2)
                {
                    Console.WriteLine("There needs to be at least two crew members");
                    
                }
            }
        }

        private float Speed
        {
            get
            {
                Speed = 0;
                return speed;
            }

            set
            {
                
            }
        }

        public float AccelerateTo()
        {
            Console.WriteLine("Give the speed");

            Speed = float.Parse(Console.ReadLine());

            if (Speed > SpeedMax)
            {
                Console.WriteLine("Too much speed. Slowing down to maximum speed...");
                Speed = SpeedMax;
            }

            return Speed;
        }

        public float SlowTo()
        {
            Console.WriteLine("Give the speed");

            Speed = float.Parse(Console.ReadLine());

            if (Speed < 0)
            {
                Speed = 0;
            }

            return Speed;
        }

    }
}
