using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrakti3
{
    class Club : Player
    {
        string answer, person;
        public string Name { get; set; }
        public string City { get; set; }

        public List<Player> Ilves = new List<Player>();
        
        public Club()
        {

        }

        public Club(string name, string city, List<Player> plist)
        {
            Name = name;
            City = city;
            string pfname, plname, handed;
            int pnum;
            do
            {
                Console.WriteLine("Do you want to remove or add players. remove/add");
                answer = Console.ReadLine();
                if (answer == "remove")
                {
                    Console.WriteLine("Who would you like to remove?");
                    person = Console.ReadLine();

                    foreach(Player player in plist)
                    {
                        if(player.FirstName == person || player.LastName == person)
                        {
                            plist.Remove(player);
                            break;
                        }
                    }
                }

                else if (answer == "add")
                {
                    Console.WriteLine("Please give information for the new player");

                    Console.WriteLine("First name:");
                    pfname = Console.ReadLine();

                    Console.WriteLine("Last name:");
                    plname = Console.ReadLine();

                    Console.WriteLine("Player number:");
                    pnum = int.Parse(Console.ReadLine());

                    do
                    {
                        Console.WriteLine("Handednes: left/right");
                        handed = Console.ReadLine();

                        if(handed == "left"|| handed == "right")
                        {
                            break;
                        }

                        else
                        {
                            Console.WriteLine("Only options are left and right");
                        }

                    } while (true);

                    Player player = new Player(pfname, plname, pnum, handed);
                    plist.Add(player);
                }
            } while (answer == "remove" || answer == "add");
            
        }

        public void GetPlayers(Club club, List<Player> listp)
        {
            Console.WriteLine("The team is " + Name + " and it's from " + City + ".");
            Console.WriteLine("Teams players are:");
            foreach(Player pelaaja in listp)
            {
                Console.WriteLine(pelaaja);
            }
        }

    }
}
