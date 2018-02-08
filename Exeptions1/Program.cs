using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exeptions1
{
    class Program
    {
        static void Test()
        {
            
            try
            {
                string line;
                string myfile = @"\L4072\testi.txt";
                //luodaan tiedosto
                using (StreamWriter sw = new StreamWriter(myfile))
                {

                    //Kysytään käyttäjältä nimet ja kirjoitetaan tiedostoon
                    do
                    {
                        Console.WriteLine("Give persons name (blank ends loop)");
                        line = Console.ReadLine();
                        if (line.Length > 0)
                        {
                            sw.WriteLine(line);
                        }
                    } while (line.Length > 0);
                    sw.Close();
                }
                //avataantiedosto lukua varten
                if ( File.Exists(myfile))
                {
                    //näytetään nimet
                    string txt = File.ReadAllText(myfile);
                    Console.WriteLine("File {0} has names: \n{1}", myfile, txt);
                }
                else
                {
                    Console.WriteLine("File {0} not found", myfile);
                }
                

            }
            catch (Exception)
            {
                
                throw;
            }            
            
        }
        static void Main(string[] args)
        {
            try
            {
                Test();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
