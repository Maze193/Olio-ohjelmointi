using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kokoelma3
{
    class Program
    {
        static void Main(string[] args)
        {
            int j = 0, k = 0;
            Deck deck = new Deck();

            //Hertta
            for(int i = 1; i < 14; i++)
            {
                deck.decklist.Add("Heart #" + i);
            }

            //Pata
            for (int i = 1; i < 14; i++)
            {
                deck.decklist.Add("Spade #" + i);
            }

            //Ruutu
            for (int i = 1; i < 14; i++)
            {
                deck.decklist.Add("Diamond #" + i);
            }

            //Risti
            for (int i = 1; i < 14; i++)
            {
                deck.decklist.Add("Club #" + i);
            }

            foreach(string card in deck.decklist)
            {
                j++;
                Console.WriteLine("Number " + j + " in the deck is " + card);
            }

            Console.WriteLine("\nShuffling deck...\n");

            deck.Shuffle(deck.decklist);

            foreach (string card in deck.decklist)
            {
                k++;
                Console.WriteLine("Number " + k + " in the deck is " + card);
            }

        }
    }
}
