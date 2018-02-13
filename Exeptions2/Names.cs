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
        int amount;
        public void NamesList()
        {
            string text = @"nimet.txt";
            if(File.Exists(text) == true)
            {
                var texti = File.ReadAllLines(@"nimet.txt");
                foreach (string name in texti)
                {
                    namelist.Add(name);
                    
                    amount++;
                }

                var q = namelist.GroupBy(i => i)
                    .Select(g => new { Value = g.Key, Count = g.Count() }).OrderBy(x => x.Value);

                Console.WriteLine(amount + " rows found and " + q.Count() + " names");

                foreach (var x in q)
                {
                    Console.WriteLine("Name " + x.Value + " is found " + x.Count + " times.");
                }
            }
        }
    }
}
