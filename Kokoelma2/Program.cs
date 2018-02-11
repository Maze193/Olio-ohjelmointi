using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kokoelma2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cd cd = new Cd("Endless Forms Most Beautiful", "Nightwish");

            cd.songs.Add("- Shudder Before the Beautiful, 6:29");
            cd.songs.Add("- Weak Fantasy, 5:23");
            cd.songs.Add("- Elan, 4:45");
            cd.songs.Add("- Yours Is an Empty Hope, 5:34");
            cd.songs.Add("- Our Decades in the Sun, 6:37");
            cd.songs.Add("- My Walden, 4:38");
            cd.songs.Add("- Endless Forms Most Beautiful, 5:07");
            cd.songs.Add("- Edema Ruh, 5:15");
            cd.songs.Add("- Alpenglow, 4:45");
            cd.songs.Add("- The Eyes of Sharbat Gula, 6:03");
            cd.songs.Add("- The Greatest Show on Earth, 24:00");

            cd.Info();

        }
    }
}
