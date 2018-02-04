using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrakti5
{
    public abstract class Mammal
    {
        public abstract string Move();

        public int Age
        {
            get;
            set;
        }
    }
}
