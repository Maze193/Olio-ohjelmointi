using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegaatit2
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "";
            MailBook mailBook = new MailBook();

            do
            {
                Console.WriteLine("Do you want to add or search someone from mail book? add/search");

                answer = Console.ReadLine();

                if (answer == "add")
                {
                    mailBook.Adding();
                }

                else if (answer == "search")
                {
                    mailBook.Search();
                }

                else
                {
                    break;
                }

            } while (answer == "add" || answer == "search");
        }
    }
}
