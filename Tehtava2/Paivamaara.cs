using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava2
{
    class Paivamaara
    {
        public bool OnkoPvm(string syote, string syote2, string syote3)
        {
            
            int luku = 0;
            int luku2 = 0;
            int luku3 = 0;

            bool op = int.TryParse(syote, out luku);

            if (op == true && luku < 32 && luku > 0)
            {
                op = int.TryParse(syote2, out luku2);
            }

            if (op == true && luku2 < 13 && luku2 > 0)
            {
                op = int.TryParse(syote3, out luku3);
            }

            if (op == true && luku3 > 0)
            {
                Console.WriteLine(luku + "." + luku2 + "." + luku3);
            }

            else
            {
                Console.WriteLine("It wasn't a date");
            }
            

            return op;
        }
    }
}
