using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kokoelma7
{
    class Program
    {
        static void Main(string[] args)
        {
            

            List<Person> persons = new List<Person>();

            Person person = new Person();


            for (int i = 0; i < 10000; i++)
            {
                string fname = "", lname = "";

                
                    fname = person.GetFirstName();
                
                    lname = person.GetLastName();
                

                person = new Person(fname, lname);
                persons.Add(person);
                
            }

        }
    }
}
