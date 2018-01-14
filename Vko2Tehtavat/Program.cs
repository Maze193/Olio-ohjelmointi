using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vko2Tehtavat
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 33, 44, 55, 68, 77, 96, 100 };
            int tehtava, number = 0, number0 = 0, number1 = 0, number2 = 0, number3 = 0, number4 = 0, number5 = 0, hour = 0, minute = 0;
            float luku1 = 0, luku2 = 0, luku3 = 0, average = 0;
            double gas = 0, price = 0;
            char t = '*';
            Console.Write("Give number of the homework you want to check \n");
            tehtava = int.Parse(Console.ReadLine());
            switch (tehtava)
            {
                case 1:

                    //Tehtava1
                    

                    Console.Write("Give a number between 1 and 3 \n");
                    number = int.Parse(Console.ReadLine());

                    switch (number)
                    {
                        case 1:
                            Console.WriteLine("Yksi");
                            break;
                        case 2:
                            Console.WriteLine("Kaksi");
                            break;
                        case 3:
                            Console.WriteLine("Kolme");
                            break;
                        default:
                            Console.WriteLine("Joku muu luku");
                            break;
                    }
                    break;

                case 2:

                    //Tehtava2
                    int points;

                    Console.Write("Give students points ");
                    points = int.Parse(Console.ReadLine());

                    switch(points)
                    {
                        case 0:
                        case 1:

                            number = 0;
                            break;

                        case 2:
                        case 3:

                            number = 1;
                            break;

                        case 4:
                        case 5:

                            number = 2;
                            break;

                        case 6:
                        case 7:

                            number = 3;
                            break;

                        case 8:
                        case 9:

                            number = 4;
                            break;

                        case 10:
                        case 11:
                        case 12:

                            number = 5;
                            break;

                        default:
                            Console.WriteLine("Not a possible score");
                            break;
                    }
                    if(number >= 0 && number <= 5 )
                    {
                        Console.WriteLine("Students number is " + number);
                    }
                    break;

                case 3:

                    //Tehtava3

                    Console.Write("Give three numbers ");
                    luku1 = float.Parse(Console.ReadLine());
                    luku2 = float.Parse(Console.ReadLine());
                    luku3 = float.Parse(Console.ReadLine());

                    luku1 = luku1 + luku2 + luku3;
                    average = (luku1) / 3;
                    Console.WriteLine("Sum of the numbers is " + luku1 + "\n" + "And average is " + average);

                    break;

                case 4:

                    //Tehtava4

                    Console.WriteLine("Give your age ");
                    luku1 = float.Parse(Console.ReadLine());
                    if(luku1 < 18)
                    {
                        Console.WriteLine("alaikäinen");
                    }
                    else if(luku1 >= 18 && luku1 <= 65)
                    {
                        Console.WriteLine("aikuinen");
                    }
                    else
                    {
                        Console.WriteLine("seniori");
                    }

                    break;

                case 5:

                    //Tehtava5

                    Console.WriteLine("Give a time in seconds ");
                    number = int.Parse(Console.ReadLine());

                    while(number >= 3600)
                    {
                        number = number - 3600;
                        hour++;
                    }

                    while(number >= 60)
                    {
                        number = number - 60;
                        minute++;
                    }

                    Console.WriteLine("Seconds can be shown as " + hour + " hour(s) " + minute + " minute(s) and " + number + " second(s)");

                    break;

                case 6:

                    //Tehtava6

                    Console.WriteLine("Give distance ");
                    number = int.Parse(Console.ReadLine());

                    gas = (number / 100) * 7.02 ;
                    price = gas * 1.595;

                    Console.WriteLine("Gasoline consume is " + gas + " liters and cost is " + price + " euros");

                    break;

                case 7:

                    //Tehtava7

                    Console.WriteLine("Give a year ");
                    number = int.Parse(Console.ReadLine());

                    if(number % 100 == 0)
                    {
                        if (number % 400 == 0)
                        {
                            Console.WriteLine("That year is a leap year");
                        }

                        else
                        {
                            Console.WriteLine("That year is not a leap year");
                        }
                    }

                    else if(number % 4 == 0)
                    {
                        Console.WriteLine("That year is a leap year");
                    }

                    else
                    {
                        Console.WriteLine("That year is not a leap year");
                    }

                    break;

                case 8:

                    //Tehtava8

                    do
                    {

                        Console.WriteLine("Give three different numbers ");
                        number1 = int.Parse(Console.ReadLine());
                        number2 = int.Parse(Console.ReadLine());
                        number3 = int.Parse(Console.ReadLine());

                        if (number1 == number2 || number1 == number3 || number2 == number3)
                        {
                            Console.WriteLine("Please give different numbers");
                        }

                        else if (number1 > number2)
                        {
                            if (number1 > number3)
                            {
                                Console.WriteLine("Biggest number is " + number1);
                            }

                            else
                            {
                                Console.WriteLine("Biggest number is " + number3);
                            }
                        }

                        else if (number2 > number1)
                        {
                            if (number2 > number3)
                            {
                                Console.WriteLine("Biggest number is " + number2);
                            }

                            else
                            {
                                Console.WriteLine("Biggest number is " + number3);
                            }
                        }

                        else
                        {
                            Console.WriteLine("This shouldn't happen?");
                        }

                    } while (number1 == number2 || number1 == number3 || number2 == number3);

                    break;

                case 9:

                    //Tehtava9

                    do
                    {
                        Console.WriteLine("Give a number ");
                        number = int.Parse(Console.ReadLine());

                        number1 += number;

                        Console.WriteLine(" Given numbers add to " + number1);

                    } while (number != 0);

                    break;

                case 10:

                    //Tehtava10

                    for (int i = 0; i < arr.Length; i++)
                    {
                        if(arr[i] % 2 == 0 )
                        {
                            Console.WriteLine("HEP");
                        }
                    }

                        break;

                case 11:

                    //Tehtava11

                    Console.WriteLine("How many row would you like? ");
                    number = int.Parse(Console.ReadLine());

                    for(int i = 0; i < number; i++)
                    {
                        for(int j = 0; j < i; j++)
                        {
                            Console.Write(t);
                        }
                        Console.WriteLine("");
                    }

                    break;

                case 12:

                    //Tehtava12

                    Console.WriteLine("Give five numbers ");
                    number = int.Parse(Console.ReadLine());
                    number1 = int.Parse(Console.ReadLine());
                    number2 = int.Parse(Console.ReadLine());
                    number3 = int.Parse(Console.ReadLine());
                    number4 = int.Parse(Console.ReadLine());

                    int[] arr2 = new int[] { number, number1, number2, number3, number4 };

                    Array.Sort(arr2, StringComparer.InvariantCulture);
                    Array.ForEach(arr2, x => Console.WriteLine(x));

                    break;

                case 13:

                    //Tehtava13

                    Console.WriteLine("Give points five times ");
                    number = int.Parse(Console.ReadLine());
                    number1 = int.Parse(Console.ReadLine());
                    number2 = int.Parse(Console.ReadLine());
                    number3 = int.Parse(Console.ReadLine());
                    number4 = int.Parse(Console.ReadLine());

                    int[] arr3 = new int[] { number, number1, number2, number3, number4 };

                    Array.Sort(arr3, StringComparer.InvariantCulture);

                    for(int i = 1; i < 4; i++)
                    {
                        number5 += arr3[i];
                    }

                    Console.WriteLine("Points are " + number5);

                    break;

                case 14:

                    //Tehtava14

                    Console.WriteLine("To stop giving grades give a number less than 0 or more than 5");

                    do
                    {
                        Console.WriteLine("Please give a grade ");
                        number = int.Parse(Console.ReadLine());



                    } while (number > 0 || number < 5);

                    break;

                case 15:

                    //Tehtava15



                    break;

                case 16:

                    //Tehtava16



                    break;

                case 17:

                    //Tehtava17



                    break;

                case 18:

                    //Tehtava18



                    break;

                case 19:

                    //Tehtava19



                    break;

                case 20:

                    //Tehtava20



                    break;

                default:
                    Console.WriteLine("Given number doesn't compare to any of the homework");
                    break;

            }

            Console.ReadLine();
        }
    }
}
    
