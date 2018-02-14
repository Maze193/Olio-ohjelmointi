using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exeptions5
{
    class Program
    {
        static void Main(string[] args)
        {
            string programs = @"TvPrograms.txt";

            TvProgram tvprogram = new TvProgram("Pasila", 1, "19:45", "20:15", "Poliiseja tai jotain");
            TvProgram tvprogram2 = new TvProgram("Emmerdale", 3, "16:30", "17:00", "Pisin puolituntia elämässäsi");
            TvProgram tvprogram3 = new TvProgram("Pikku Kakkonen", 2, "17:00", "18:00", "Oli paljon parempi 90-luvulla");

            List<TvProgram> tvprograms = new List<TvProgram>();
            tvprograms.Add(tvprogram);
            tvprograms.Add(tvprogram2);
            tvprograms.Add(tvprogram3);

            using (StreamWriter tv = new StreamWriter(programs))
            {
                foreach (TvProgram progs in tvprograms)
                {
                    tv.WriteLine(progs.ToString());
                }
                tv.Close();
            }

            if (File.Exists(programs))
            {
                //näytetään nimet
                string txt = File.ReadAllText(programs);
                Console.WriteLine("File {0} has programs: \n{1}", programs, txt);
            }
            else
            {
                Console.WriteLine("File {0} not found", programs);
            }
            
        }
    }
}
