using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kertaus1
{
    class Dice
    {
        Random die = new Random();
        int count, count1, count2, count3, count4, count5, count6;
        double number = 0.0000;

        public void Roll()
        {
            Console.WriteLine("How many dice you want to roll?");
            bool isdie = int.TryParse(Console.ReadLine(), out int numb);
            Console.WriteLine("\nYour rolls are:");

            for(int i = 0; i < numb; i++)
            {
                int num = die.Next(1, 7);

                Console.WriteLine(count);
                if(num == 1)
                {
                    count++;
                    count1++;
                }
                else if (num == 2)
                {
                    count++;
                    count2++;
                }
                else if (num == 3)
                {
                    count++;
                    count3++;
                }
                else if (num == 4)
                {
                    count++;
                    count4++;
                }
                else if (num == 5)
                {
                    count++;
                    count5++;
                }
                else if (num == 6)
                {
                    count++;
                    count6++;
                }
                else
                {
                    Console.WriteLine("wat");
                }
            }

            number = (count1 + 2 * count2 + 3 * count3 + 4 * count4 + 5 * count5 + 6 * count6) / count;

            Console.WriteLine("Dice have been thrown " + numb + " times\n- average is " + number + "\n- 1 count is " + count1 + "\n- 2 count is " + count2 + "\n- 3 count is " + count3 + "\n- 4 count is " + count4 + "\n- 5 count is " + count5 + "\n- 6 count is " + count6);

        }

    }
}
