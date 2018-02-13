using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exeptions4
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            List<int> numbs = new List<int>();
            List<double> numbs2 = new List<double>();
            int num;
            double num2;

            Saving saving = new Saving();

            do
            {
                Console.WriteLine("Give a number (blank and other than number ends loop)");
                line = Console.ReadLine();
                if (line.Length > 0)
                {
                    if (int.TryParse(line, out num) == true)
                    {
                        num = int.Parse(line);
                        numbs.Add(num);
                    }

                    else if (double.TryParse(line, out num2) == true)
                    {
                        num2 = double.Parse(line);
                        numbs2.Add(num2);
                    }

                    else
                    {
                        Console.WriteLine("That wasn't a number");
                        break;
                    }
                }
            } while (line.Length > 0);
            saving.Integers(numbs);
            saving.Doubles(numbs2);
            saving.ReadFiles();
        }
    }
}
