using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrakti3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Club club = new Club();

            club.Ilves.Add(new Player("Riku", "Helenius", "mv", "vasen"));
            club.Ilves.Add(new Player("Waltteri", "Urpolahti", "mv", "vasen"));
            club.Ilves.Add(new Player("Antti", "Lehtonen", "mv", "vasen"));
            club.Ilves.Add(new Player("Valtteri", "Viljanen", "p", "oikea"));
            club.Ilves.Add(new Player("Olli", "Vainio", "p", "oikea"));
            club.Ilves.Add(new Player("Valtteri", "Ilomäki", "p", "oikea"));
            club.Ilves.Add(new Player("Mark", "Flood",  "p", "oikea"));
            club.Ilves.Add(new Player("Joe", "Piskula", "p", "vasen"));
            club.Ilves.Add(new Player("Arto", "Laatikainen", "p", "vasen"));
            club.Ilves.Add(new Player("Henry", "Mäntylä", "p", "vasen"));
            club.Ilves.Add(new Player("Juuso", "Pulli", "p", "vasen"));
            club.Ilves.Add(new Player("Jarkko", "Parikka", "p", "vasen"));
            club.Ilves.Add(new Player("Eemeli", "Suomi", "h", "vasen"));
            club.Ilves.Add(new Player("Joona", "Koppanen", "h", "vasen"));
            club.Ilves.Add(new Player("Otto", "Koivula", "h", "vasen"));
            club.Ilves.Add(new Player("Ville", "Meskanen", "h", "oikea"));
            club.Ilves.Add(new Player("Teemu", "Rautiainen", "h", "vasen"));
            club.Ilves.Add(new Player("Arttu", "Ruotsalainen", "h", "vasen"));
            club.Ilves.Add(new Player("Joona", "Ikonen", "h", "oikea"));
            club.Ilves.Add(new Player("Sami", "Sandell", "h", "vasen"));
            club.Ilves.Add(new Player("Tapio", "Laakso", "h", "vasen"));
            club.Ilves.Add(new Player("Julius", "Valtonen", "h", "oikea"));
            club.Ilves.Add(new Player("Teemu", "Lepaus", "h", "vasen"));
            club.Ilves.Add(new Player("Juhani", "Tamminen", "h", "vasen"));

            using (System.IO.StreamWriter ilves = new System.IO.StreamWriter("Ilves.txt", true))
            {
                foreach (Player player in club.Ilves)
                {
                    ilves.WriteLine(player.ToString());
                }
            }

            club.Tappara.Add(new Player("Christian", "Heljanko", "mv", "vasen"));
            club.Tappara.Add(new Player("Dominik", "Hrachovina", "mv", "vasen"));
            club.Tappara.Add(new Player("Mikko", "Lehtonen", "p", "vasen"));
            club.Tappara.Add(new Player("Aleksi", "Salonen", "p", "oikea"));
            club.Tappara.Add(new Player("Valtteri", "Kemiläinen", "p", "oikea"));
            club.Tappara.Add(new Player("Toni", "Utunen", "p", "vasen"));
            club.Tappara.Add(new Player("Aleksi", "Elorinne", "p", "vasen"));
            club.Tappara.Add(new Player("Veli-Matti", "Vittasmäki", "p", "vasen"));
            club.Tappara.Add(new Player("Otso", "Rantakari", "p", "oikea"));
            club.Tappara.Add(new Player("Niko", "Mikkola", "p", "vasen"));
            club.Tappara.Add(new Player("Matti", "Järvinen", "h", "vasen"));
            club.Tappara.Add(new Player("Teemu", "Nurmi", "h", "oikea"));
            club.Tappara.Add(new Player("Niko", "Ojamäki", "h", "oikea"));
            club.Tappara.Add(new Player("Jere", "Karjalainen", "h", "oikea"));
            club.Tappara.Add(new Player("Otto", "Rauhala", "h", "vasen"));
            club.Tappara.Add(new Player("Jan-Mikael", "Järvinen", "h", "vasen"));
            club.Tappara.Add(new Player("Juhani", "Jasu", "h", "oikea"));
            club.Tappara.Add(new Player("Tomas", "Zaborsky", "h", "vasen"));
            club.Tappara.Add(new Player("Joona", "Luoto", "h", "vasen"));
            club.Tappara.Add(new Player("Kristian", "Kuusela", "h", "oikea"));
            club.Tappara.Add(new Player("Jukka", "Peltola", "h", "vasen"));
            club.Tappara.Add(new Player("Sebastian", "Repo", "h", "vasen"));

            using (System.IO.StreamWriter tappara = new System.IO.StreamWriter("Tappara.txt", true))
            {
                foreach (Player player in club.Tappara)
                {
                    tappara.WriteLine(player.ToString());
                }
            }

            foreach (Player player in club.Ilves)
            {
                Console.WriteLine(player.ToString());
            }

            foreach (Player player in club.Tappara)
            {
                Console.WriteLine(player.ToString());
            }*/

            // Read the file as one string.
            string text = System.IO.File.ReadAllText("Ilves.txt");

            // Display the file contents to the console. Variable text is a string.
            System.Console.WriteLine(text);

            // Read the file as one string.
            string text2 = System.IO.File.ReadAllText("Tappara.txt");

            // Display the file contents to the console. Variable text is a string.
            System.Console.WriteLine(text2);            

        }
    }
}
