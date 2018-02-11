using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kokoelma2
{
    class Cd
    {
        public string Name { get; set; }
        public string Artist { get; set; }
        public List<string> songs = new List<string>();

        public Cd()
        {

        }

        public Cd (string name, string artist)
        {
            Name = name;
            Artist = artist;
        }

        public void Info()
        {
            Console.WriteLine("CD data:");
            Console.WriteLine(" - name: " + Name);
            Console.WriteLine(" - artist: " + Artist);
            Console.WriteLine(" - songs: ");

            foreach(string song in songs)
            {
                Console.WriteLine("     " + song);
            }

        }

    }
}
