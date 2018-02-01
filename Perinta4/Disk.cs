using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perinta4
{
    abstract class Disk : Item
    {
        int DataAmount, MaxData;
        public abstract string Contents();
    }
}
