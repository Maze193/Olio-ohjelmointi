using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrakti3
{
    public class Player
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PlayerNumber{ get; set; }
        public string Hand { get; set; }

        public Player()
        {

        }

        public Player(string fname, string lname, int pnum, string hand)
        {
            FirstName = fname;
            LastName = lname;
            PlayerNumber = pnum;
            Hand = hand;

        }

        public override string ToString()
        {
            return FirstName + " " + LastName + " " + PlayerNumber + " " + Hand;
        }

    }
}
