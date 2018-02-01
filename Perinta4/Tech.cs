using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perinta4
{
    abstract class Tech : Item
    {
        public abstract long ScreenSize();
        public abstract string Processor();
        public abstract string OperSystem();
    }
}
