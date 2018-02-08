using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koostaminen2
{
    class PaidWithCard : ITransaction
    {
        float paymentrd;
        float bankacc = 0;
        public float GetAmount()
        {
            Console.WriteLine("How much will you pay?");
            paymentrd = float.Parse(Console.ReadLine());
            bankacc += paymentrd;
            return paymentrd;
        }

        public string ShowTransaction()
        {

            return "Total money put to our bankaccount is " + bankacc;
        }

        
    }
}
