using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrakti1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Tyre> tyres = new List<Tyre>();
            /*Tyre tyre1 = new Tyre();
            Tyre tyre2 = new Tyre();
            Tyre tyre3 = new Tyre();*/
            Vehicle car = new Vehicle("Porche", "911");
            Vehicle bike = new Vehicle("Ducati", "Diavel");

            tyres.Add(new Tyre("Nokia", "Hakkapeliitta", "205R16"));
            tyres.Add(new Tyre("Nokia", "Hakkapeliitta", "205R16"));
            tyres.Add(new Tyre("Nokia", "Hakkapeliitta", "205R16"));
            tyres.Add(new Tyre("Nokia", "Hakkapeliitta", "205R16"));

            Console.WriteLine("Vehicle Name: " + car.Name + " model " + car.Model);
            Console.WriteLine("Tyres:");

            foreach(Tyre tyre in tyres)
            {
                Console.WriteLine(tyre.ToString());
            }

            tyres.Clear();

            Console.WriteLine();

            tyres.Add(new Tyre("MIC", "Pilot", "160R17"));
            tyres.Add(new Tyre("MIC", "Pilot", "140R17"));

            Console.WriteLine("Vehicle Name: " + bike.Name + " model " + bike.Model);
            Console.WriteLine("Tyres:");

            foreach (Tyre tyre in tyres)
            {
                Console.WriteLine(tyre.ToString());
            }

        }
    }
}
