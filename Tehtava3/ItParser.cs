using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava3
{
    class ItParser
    {
        int count = 0, sum = 0, div = 1, num;
        double average = 0;


        public int Count(string syote)
        {
            string[] stringSeparators = new string[] { "," };
            string[] result;

            result = syote.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in result)
            {
                count++;
            }
            Console.WriteLine();


            return count;
        }

        public int Sum(string syote)
        {
            string[] stringSeparators = new string[] { "," };
            string[] result;

            result = syote.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in result)
            {
                num = int.Parse(s);

                sum += num;
            }
            Console.WriteLine();

            return sum;
        }

        public double Average(string syote)
        {

            string[] stringSeparators = new string[] { "," };
            string[] result;

            result = syote.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in result)
            {
                div++;
            }
            Console.WriteLine();

            div -= 1;

            average = sum / div;

            return average;
        }

        public void Announcement()
        {
            Console.WriteLine(" there is " + count + " numbers, and their sum is " + sum + " and the average is " + average);
        }

    }
}
