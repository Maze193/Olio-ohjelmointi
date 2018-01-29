using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perinta1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "Kirsti";
            employee.LastName = "Kernel";
            employee.Profession = "Teacher";
            employee.Salary = 1200;
            Console.WriteLine(employee.ToString());

            Boss boss = new Boss();
            boss.FirstName = "Jussi";
            boss.LastName = "Jurkka";
            boss.Profession = "Head of Institute Salary";
            boss.Salary = 9000;
            boss.Car = "Audi";
            boss.Bonus= 5000;
            Console.WriteLine(boss.ToString());

            Console.WriteLine("Please change their information");
            Console.Write("Employee first name: ");
            employee.FirstName = Console.ReadLine();
            Console.Write("Employee last name: ");
            employee.LastName = Console.ReadLine();
            Console.Write("Employee profession: ");
            employee.Profession = Console.ReadLine();
            Console.Write("Employee salary: ");
            employee.Salary = int.Parse(Console.ReadLine());

            Console.Write("Boss first name: ");
            boss.FirstName = Console.ReadLine();
            Console.Write("Boss last name: ");
            boss.LastName = Console.ReadLine();
            Console.Write("Boss profession: ");
            boss.Profession = Console.ReadLine();
            Console.Write("Boss salary: ");
            boss.Salary = int.Parse(Console.ReadLine());
            Console.Write("Boss car: ");
            boss.Car = Console.ReadLine();
            Console.Write("Boss bonus: ");
            boss.Bonus= int.Parse(Console.ReadLine());

            Console.WriteLine(employee.ToString());
            Console.WriteLine(boss.ToString());

            Console.ReadLine();
        }
    }
}
