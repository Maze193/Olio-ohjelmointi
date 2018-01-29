using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perinta1
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Profession { get; set; }
        public int Salary { get; set; }
        
        // default constructor
        public Employee()
        {
        }

        // constructor takes employee firstname and lastname as a parameter
        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        // just one method what Employee can do
        public void EmployeeMethod()
        {
            Console.WriteLine("This method belongs to Employee!");
        }

        // return Employee data as a one string, override Object class ToString()-method
        public override string ToString()
        {
            return FirstName + " " + LastName + " " + Profession + " " + Salary;
        }
    }
}
