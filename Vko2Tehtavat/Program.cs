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
            int[] arr = new int[] { 1, 2, 33, 44, 55, 68, 77, 96, 100 }, arr1 = new int[] { 3, 4, 34, 45, 56, 67, 78, 99, 101 };
            int tehtava, number = 0, number0 = 0, number1 = 0, number2 = 0, number3 = 0, number4 = 0, number5 = 0,
                hour = 0, minute = 0, lettersRevealed = 0, lives = 5;
            float luku1 = 0, luku2 = 0, luku3 = 0, average = 0;
            double gas = 0, price = 0;
            char guess, t = '*';
            string pal, input;
            bool won = false;
            Random random = new Random((int)DateTime.Now.Ticks);
            int rnd = random.Next(0, 100);
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

                    Console.WriteLine("To stop giving grades give a number more than 5");

                    do
                    {
                        Console.WriteLine("Please give a grade ");
                        number = int.Parse(Console.ReadLine());

                        if (number == 0)
                        {
                            number0++;
                        }

                        if (number == 1)
                        {
                            number1++;
                        }

                        if (number == 2)
                        {
                            number2++;
                        }

                        if (number == 3)
                        {
                            number3++;
                        }

                        if (number == 4)
                        {
                            number4++;
                        }

                        if (number == 5)
                        {
                            number5++;
                        }

                    } while (number < 6);


                    Console.Write("0: ");
                    for (int i = 0; i < number0; i++)
                    {
                        Console.Write(t);
                    }
                    Console.WriteLine("");

                    Console.Write("1: ");
                    for (int i = 0; i < number1; i++)
                    {
                        Console.Write(t);
                    }
                    Console.WriteLine("");

                    Console.Write("2: ");
                    for (int i = 0; i < number2; i++)
                    {
                        Console.Write(t);
                    }
                    Console.WriteLine("");

                    Console.Write("3: ");
                    for (int i = 0; i < number3; i++)
                    {
                        Console.Write(t);
                    }
                    Console.WriteLine("");

                    Console.Write("4: ");
                    for (int i = 0; i < number4; i++)
                    {
                        Console.Write(t);
                    }
                    Console.WriteLine("");

                    Console.Write("5: ");
                    for (int i = 0; i < number5; i++)
                    {
                        Console.Write(t);
                    }
                    Console.WriteLine("");

                    break;

                case 15:

                    //Tehtava15

                    Console.WriteLine("Give size of the tree");
                    number = int.Parse(Console.ReadLine());
                    number0 = number - 2;

                    for (int i = 0; i < number0; i++)
                    {
                        number1 = number0 - i - 1;
                        for (int j = 0; j < number1; j++)
                        {
                            Console.Write(" ");
                        }

                        number2 = 2 * i + 1;
                        for (int k = 0; k < number2; k++)
                        {
                            Console.Write(t);
                        }

                        Console.WriteLine("");
                    }

                    for(int i = 0; i < 2; i++)
                    {
                        
                        for (int j = 1; j < number0; j++)
                        {
                            Console.Write(" ");
                        }

                        Console.WriteLine(t);
                    }

                    break;

                case 16:

                    //Tehtava16

                    do
                    {
                        Console.Write("Guess the number: ");
                        number = int.Parse(Console.ReadLine());
                        number0++;
                        if (number < rnd)
                        {
                            Console.WriteLine("The number is bigger ");
                        }

                        else if (number > rnd)
                        {
                            Console.WriteLine("The number is smaller");
                        }

                        else if (number == rnd)
                        {
                            Console.Write("You guessed correct, it took " + number0 + " guesses!");
                            break;
                        }

                    } while (number != rnd);


                    break;

                case 17:

                    //Tehtava17

                    int[] carr = new int[] { arr[0], arr[1], arr[2], arr[3], arr[4], arr[5], arr[6], arr[7], arr[8],
                        arr1[0], arr1[1], arr1[2], arr1[3], arr1[4], arr1[5], arr1[6], arr1[7], arr1[8]};
                    Array.Sort(carr, StringComparer.InvariantCulture);
                    Console.Write("Array number 1 is: ");
                    for(int i = 0; i < 9; i++)
                    {
                        Console.Write(arr[i] + " ");
                    }
                    Console.WriteLine("");

                    Console.Write("Array number 2 is: ");
                    for (int i = 0; i < 9; i++)
                    {
                        Console.Write(arr1[i] + " ");
                    }
                    Console.WriteLine("");

                    Console.Write("Array number 1 is: ");
                    for (int i = 0; i < 18; i++)
                    {
                        Console.Write(carr[i] + " ");
                    }
                    Console.WriteLine("");

                    break;

                case 18:

                    //Tehtava18

                    Console.WriteLine("Please write something to check if it is a palidrome");

                    pal = Console.ReadLine();

                    string pal1 = new string(pal.Reverse().ToArray());

                    if(pal == pal1)
                    {
                        Console.WriteLine("Your writing is a palidrome");
                    }

                    else
                    {
                        Console.WriteLine("Your writing is not a palidrome");
                    }

                    break;

                case 19:

                    //Tehtava19

                    string wordToGuess = "Ohjelmointi";
                    string wordToGuessUppercase = wordToGuess.ToUpper();

                    StringBuilder displayToPlayer = new StringBuilder(wordToGuess.Length);
                    for (int i = 0; i < wordToGuess.Length; i++)
                        displayToPlayer.Append('_');

                    List<char> correctGuesses = new List<char>();
                    List<char> incorrectGuesses = new List<char>();

                    while (!won && lives > 0)
                    {
                        Console.Write("Guess a letter: ");

                        input = Console.ReadLine().ToUpper();
                        guess = input[0];

                        if (correctGuesses.Contains(guess))
                        {
                            Console.WriteLine("You've already tried '{0}', and it was correct!", guess);
                            continue;
                        }
                        else if (incorrectGuesses.Contains(guess))
                        {
                            Console.WriteLine("You've already tried '{0}', and it was wrong!", guess);
                            continue;
                        }

                        if (wordToGuessUppercase.Contains(guess))
                        {
                            correctGuesses.Add(guess);

                            for (int i = 0; i < wordToGuess.Length; i++)
                            {
                                if (wordToGuessUppercase[i] == guess)
                                {
                                    displayToPlayer[i] = wordToGuess[i];
                                    lettersRevealed++;
                                }
                            }

                            if (lettersRevealed == wordToGuess.Length)
                                won = true;
                        }
                        else
                        {
                            incorrectGuesses.Add(guess);

                            Console.WriteLine("Nope, there's no '{0}' in it!", guess);
                            lives--;
                        }

                        Console.WriteLine(displayToPlayer.ToString());
                    }

                    if (won)
                        Console.WriteLine("You won!");
                    else
                        Console.WriteLine("You lost! It was '{0}'", wordToGuess);

                    break;

                case 20:

                    //Tehtava20
                    //Shadowrun 5e dice roller

                    Console.WriteLine("Give the number of dice to roll");
                    number = int.Parse(Console.ReadLine());

                    Console.WriteLine("Do you want to use 'Push the limits' (y/n)");
                    string yn = Console.ReadLine();

                    if (yn == "y")
                    {
                        Console.WriteLine("Please give the edge value");
                        number3 = int.Parse(Console.ReadLine());

                        number += number3;
                    }

                    for (int i = 0; i < number; i++)
                    {
                        number0 = random.Next(1, 7);

                        if (number0 > 4)
                        {
                            number1++;
                        }

                        if (number0 == 6)
                        {
                            number2++;
                        }

                        Console.WriteLine(number0);
                    }

                    Console.WriteLine("You got " + number1 + " hits");

                    if (yn == "y")
                    {
                        for (int i = 0; i < number2; i++)
                        {
                            number0 = random.Next(1, 7);

                            if (number0 > 4)
                            {
                                number4++;
                            }

                            Console.WriteLine(number0);
                        }

                        number5 = number4 + number1;

                        Console.WriteLine("And you got " + number4 + " hits with rule of six, wich totals to " + number5 + " hits!");
                    }

                    break;

                default:
                    Console.WriteLine("Given number doesn't compare to any of the homework");
                    break;

            }

            Console.ReadLine();
        }
    }
}
    
