using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kokoelma3
{
    class Deck
    {

        public List<string> decklist = new List<string>();

        private Random rng = new Random();

        public void Shuffle(List<string> list)
        {
            /*var rnd = new Random();
            var result = list.OrderBy(item => rnd.Next());*/
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                string value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

    }
}
