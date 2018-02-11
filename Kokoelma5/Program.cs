using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrakti3
{
    class Program
    {
        static void Main(string[] args)
        {
            Club club = new Club();

            club.Ilves.Add(new Player("Riku", "Helenius", 1, "left"));
            club.Ilves.Add(new Player("Waltteri", "Urpolahti", 1, "left"));
            club.Ilves.Add(new Player("Antti", "Lehtonen", 35, "left"));
            club.Ilves.Add(new Player("Valtteri", "Viljanen", 8, "right"));
            club.Ilves.Add(new Player("Olli", "Vainio", 9, "right"));
            club.Ilves.Add(new Player("Valtteri", "Ilomäki", 31, "right"));
            club.Ilves.Add(new Player("Mark", "Flood", 36, "right"));
            club.Ilves.Add(new Player("Joe", "Piskula", 43, "left"));
            club.Ilves.Add(new Player("Arto", "Laatikainen", 47, "left"));
            club.Ilves.Add(new Player("Henry", "Mäntylä", 50, "left"));
            club.Ilves.Add(new Player("Juuso", "Pulli", 55, "left"));
            club.Ilves.Add(new Player("Jarkko", "Parikka", 57, "left"));
            club.Ilves.Add(new Player("Eemeli", "Suomi", 10, "left"));
            club.Ilves.Add(new Player("Joona", "Koppanen", 11, "left"));
            club.Ilves.Add(new Player("Otto", "Koivula", 12, "left"));
            club.Ilves.Add(new Player("Ville", "Meskanen", 18, "right"));
            club.Ilves.Add(new Player("Teemu", "Rautiainen", 19, "left"));
            club.Ilves.Add(new Player("Arttu", "Ruotsalainen", 22, "left"));
            club.Ilves.Add(new Player("Joona", "Ikonen", 32, "right"));
            club.Ilves.Add(new Player("Sami", "Sandell", 42, "left"));
            club.Ilves.Add(new Player("Tapio", "Laakso", 71, "left"));
            club.Ilves.Add(new Player("Julius", "Valtonen", 72, "right"));
            club.Ilves.Add(new Player("Teemu", "Lepaus", 75, "left"));
            club.Ilves.Add(new Player("Juhani", "Tamminen", 88, "left"));

            Club ilves = new Club("Ilves", "Tampere", club.Ilves);
            ilves.Ilves = club.Ilves;

            ilves.GetPlayers(ilves, ilves.Ilves);

            using (System.IO.StreamWriter illves = new System.IO.StreamWriter("Ilves.txt", false))
            {
                foreach (Player player in club.Ilves)
                {
                    illves.WriteLine(player.ToString());
                }
            }

        }
    }
}
