using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Paivamaara paivamaara = new Paivamaara();
            bool po = false;
            while (po != true)
            {
                Console.WriteLine("Give a date");


                int paiva = int.Parse(Console.ReadLine());
                int kuu = int.Parse(Console.ReadLine());
                int vuosi = int.Parse(Console.ReadLine());

                //if (paiva < 32 && paiva > 0 && kuu < 13 && kuu > 0 && vuosi > 0)
                //{
                    string syo = paiva + "";

                    string syo2 = kuu + "";

                    string syo3 = vuosi + "";

                    //paivamaara.OnkoPvm(syote: syo, syote2: syo2, syote3: syo3);
                Console.WriteLine(Paivamaara.OnkoPvm(syote: syo, syote2: syo2, syote3: syo3));

                    po = true;
                //}

                /*else
                {
                    Console.WriteLine("Please give a date...");
                }*/
            }

            Console.ReadLine();
        }
    }
}
