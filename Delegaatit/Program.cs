using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Globalization;

namespace Delegaatit
{
    class Program
    {
        public delegate string Del(string word);

        static void Main(string[] args)
        {
            bool result, result0, result1, result2, result3, result4;
            string str;
            int num = 0;

            Changer changer = new Changer();

            Del del = new Del(changer.Uppercase);

            Console.WriteLine("Give word or words");
            string word = Console.ReadLine();

            while (true)
            {
                Console.WriteLine("Choose what to do with it, you can choose multiple things at same time for example '123':");
                Console.WriteLine("1 = Only uppercase letters \n2 = Only lowercase letters\n3 = Heading\n4 = Reverse\n0 = Ends loop");
                str = Console.ReadLine();
                result = int.TryParse(str, out num);

                if(result == true)
                {
                    num = int.Parse(str);
                    result0 = num.ToString().Contains("0");
                    result1 = num.ToString().Contains("1");
                    result2 = num.ToString().Contains("2");
                    result3 = num.ToString().Contains("3");
                    result4 = num.ToString().Contains("4");

                    if (result1 == true)
                    {
                        Console.WriteLine(del(word));
                    }

                    if (result2 == true)
                    {
                        del = new Del(changer.Lowercase);
                        Console.WriteLine(del(word));
                    }

                    if (result3 == true)
                    {
                        del = new Del(changer.Heading);
                        Console.WriteLine(del(word));
                    }

                    if (result4 == true)
                    {
                        del = new Del(changer.Reverse);
                        Console.WriteLine(del(word));
                    }

                    if (result0 == true)
                        break;

                }

                else
                {
                    Console.WriteLine("That wasn't a number");
                }

            }

        }

        public class Changer
        {
            public string Uppercase(string word)
            {
                return word.ToUpper();
            }

            public string Lowercase(string word)
            {
                return word.ToLower();
            }

            public string Heading(string word)
            {
                CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
                TextInfo textInfo = cultureInfo.TextInfo;

                return textInfo.ToTitleCase(word);
            }

            public string Reverse(string word)
            {
                char[] charArray = word.ToCharArray();
                Array.Reverse(charArray);

                string line = new string(charArray);

                return line;
            }

        }
    }
}
