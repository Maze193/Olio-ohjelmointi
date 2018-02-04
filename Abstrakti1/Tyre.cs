using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrakti1
{
    class Tyre
    {

        public string Tyretype { get; set; }
        public string Tyremodel { get; set; }
        public string Tyresize { get; set; }

        public Tyre()
        {

        }

        public Tyre(string tyretype, string tyremodel, string tyresize)
        {
            Tyremodel = tyremodel;
            Tyretype = tyretype;
            Tyresize = tyresize;
        }

        public override string ToString()
        {
            return "Name: " + Tyretype + " " + "Model: " + Tyremodel +  " " + "Tyre size: " + Tyresize;
        }

    }
}
