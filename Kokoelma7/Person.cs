using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kokoelma7
{
    class Person
    {
        Random rnd = new Random();
        
        public string FirstName{ get; set; }
        public string LastName{ get; set; }

        public Person()
        {

        }

        public Person(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
        }

        public string GetFirstName()
        {
            string txtRand = string.Empty;
            for (int i = 0; i < 4; i++) txtRand += ((char)rnd.Next(97, 122)).ToString();
            return txtRand;
        }

        public string GetLastName()
        {
            string txtRand = string.Empty;
            for (int i = 0; i < 10; i++) txtRand += ((char)rnd.Next(97, 122)).ToString();
            return txtRand;
        }
        
    }
}
