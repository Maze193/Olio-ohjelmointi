using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exeptions4
{
    class Saving
    {
        string intfile = @"T2Integers.txt", doublefile = @"T2Doubles.txt";
        public void Integers(List<int> i)
        {
            using (StreamWriter intf = new StreamWriter(intfile))
            {
                foreach (int t in i)
                {
                    intf.WriteLine(t);
                }
                intf.Close();
            }
        }

        public void Doubles(List<double> d)
        {
            using (StreamWriter doubf = new StreamWriter(doublefile))
            {
                foreach (double p in d)
                {
                    doubf.WriteLine(p);
                }
                doubf.Close();
            }
        }

        public void ReadFiles()
        {
            if (File.Exists(intfile))
            {
                //näytetään nimet
                string txt = File.ReadAllText(intfile);
                Console.WriteLine("File {0} has numbers: \n{1}", intfile, txt);
            }
            else
            {
                Console.WriteLine("File {0} not found", intfile);
            }
            if (File.Exists(doublefile))
            {
                //näytetään nimet
                string txt2 = File.ReadAllText(doublefile);
                Console.WriteLine("File {0} has numbers: \n{1}", doublefile, txt2);
            }
            else
            {
                Console.WriteLine("File {0} not found", doublefile);
            }
        }
    }
}
