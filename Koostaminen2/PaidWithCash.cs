using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koostaminen2
{
    class PaidWithCash : ITransaction
    {
        float paymentsh;
        float register = 0;
        public float GetAmount()
        {
            Console.WriteLine("How much will you pay?");
            paymentsh = float.Parse(Console.ReadLine());
            register += paymentsh;
            return paymentsh;
        }

        public string ShowTransaction()
        {

            return "Total money put to cash register is " + register;
        }

        public float ShowCash()
        {

            return 0;
        }
    }
}
