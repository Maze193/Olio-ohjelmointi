using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrakti5
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            Adult adult = new Adult();
            Baby baby = new Baby();

            human.Age = 39;
            human.FirstName = "Fnu";
            human.LastName = "Virtanen";
            human.Height = 151;
            human.Weight = 151;

            adult.Age = 34;
            adult.Car = "Nissan Micra";
            adult.FirstName = "Kari";
            adult.LastName = "Heikkinen";
            adult.Height = 196;
            adult.Weight = 104;

            baby.Age = 1;
            baby.Diaper = "full";
            baby.FirstName = "Corianteri-Oregano";
            baby.LastName = "Ranta";
            baby.Height = 60;
            baby.Weight = 30;

            Console.WriteLine(human.ToString());
            Console.WriteLine(human.Move());

            Console.WriteLine(adult.ToString());
            Console.WriteLine(adult.Move());

            Console.WriteLine(baby.ToString());
            Console.WriteLine(baby.Move());

        }
    }
}
