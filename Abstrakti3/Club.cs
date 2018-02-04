using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrakti3
{
    class Club : Player
    {
        public string Name { get; set; }
        public string City { get; set; }

        public List<Player> Ilves = new List<Player>();
        public List<Player> Tappara = new List<Player>();

        public Club()
        {

        }

        public Club(string name, string city)
        {
            Name = name;
            City = city;
        }

    }
}
