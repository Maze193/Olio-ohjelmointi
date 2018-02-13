using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exeptions5
{
    class Program
    {
        static void Main(string[] args)
        {
            TvProgram tvprogram = new TvProgram("Pasila", 1, "19:45", "20:15", "Poliisejatai jotain");
            TvProgram tvprogram2 = new TvProgram("Emmerdale", 3, "16:30", "17:00", "Pisin puolituntia elämässäsi");
            TvProgram tvprogram3 = new TvProgram("Pikku Kakkonen", 2, "17:00", "18:00", "Oli paljon parempi 90-luvulla");


        }
    }
}
