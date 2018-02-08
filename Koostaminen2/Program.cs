using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koostaminen2
{
    public interface ITransaction
    {
        // interface members 
        string ShowTransaction();
        float GetAmount();
    }
    class Program
    {
        static void Main(string[] args)
        {

            PaidWithCard withCard = new PaidWithCard();
            PaidWithCash withCash = new PaidWithCash();

            string vastaus = "";
            
            do
            {
                Console.WriteLine("What would you like to pay with? card/cash");
                vastaus = Console.ReadLine();
                if(vastaus != "card" && vastaus != "cash")
                {
                    break;
                }
                else if(vastaus == "card")
                {
                    withCard.GetAmount();
                }
                else if (vastaus == "cash")
                {
                    withCash.GetAmount();
                }
                else
                {
                    break;
                }

            } while (vastaus == "card" || vastaus == "cash");

            Console.WriteLine(withCard.ShowTransaction());
            Console.WriteLine(withCash.ShowTransaction());

        }
    }
}
