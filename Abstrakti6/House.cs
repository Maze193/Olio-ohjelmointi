using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrakti6
{
    public class Room
    {
        public int SizeX { get; set; }
        public int SizeY { get; set; }

        public Room(int x, int y)
        {
            SizeX = x;
            SizeY = y;
        }
    }

    class House
    {
        public string OwnerName { get; set; }
        public string City { get; set; }
        public Room room;

        public House(string oname, string city, Room rom)
        {
            OwnerName = oname;
            City = city;
            room = rom;
        }

        public override string ToString()
        {
            return "House is owned by " + OwnerName + " and it's in " + City + " and in it there's room that's " + room.SizeX + " by " + room.SizeY;
        }

    }
}
