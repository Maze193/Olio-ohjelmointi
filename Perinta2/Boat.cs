using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perinta2
{
    class Boat : Vehicle
    {
        public string BoatType { get; set; }
        public int SeatCount { get; set; }

        public Boat()
        {

        }

        public Boat(string name, string model, string color, string btype, int myear, int secount)
        {
            BoatType = btype;
            SeatCount = secount;
        }

        public override string ToString()
        {
            return base.ToString() + " " + "SeatCount: " + SeatCount + " " + "BoatType: " + BoatType;
        }
    }
}
