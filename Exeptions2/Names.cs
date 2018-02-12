using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exeptions2
{
    class Names
    {
        List<string> namelist = new List<string>();
        int amount, amount2;
        public void NamesList()
        {
            string text = @"D:\L4072\nimet.txt";
            if(File.Exists(text) == true)
            {
                var texti = File.ReadAllLines(@"D:\L4072\nimet.txt");
                foreach (string name in texti)
                {
                    namelist.Add(name);
                    
                    amount++;
                }

                var duplicates = namelist
                    .GroupBy(i => i)
                    .Where(g => g.Count() > 0)
                    .Select(g => g.Key);
                foreach (var d in duplicates)
                    Console.WriteLine(d + d.Count()); // 4,3
            }
        }
    }
}
