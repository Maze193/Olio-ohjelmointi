using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Delegaatit2
{
    class MailBook : Friend
    {
        int num = 0;
        string tutut = @"tutut.csv", added = @"addedfriends.txt", addname, addaddress;
        Friend friend;
        List<string> names = new List<string>();
        List<string> addresses = new List<string>();
        List<Friend> friends = new List<Friend>();

        public MailBook()
        {
            if (File.Exists(tutut))
            {

                using (StreamReader str = new StreamReader(tutut))
                {

                    while (!str.EndOfStream)
                    {
                        var line = str.ReadLine();
                        var values = line.Split(';');

                        names.Add(values[0]);
                        addresses.Add(values[1]);
                    }
                    str.Close();
                }

                Console.WriteLine(names.Count() + " names in mail book");

                foreach (string name in names)
                {
                    Console.WriteLine(name);

                    friend = new Friend(name, addresses[num]);

                    friends.Add(friend);

                    num++;

                }
            }

            else
            {
                Console.WriteLine("File not found!");
            }

        }

        public void Adding()
        {
            Console.WriteLine("Give new persons name");
            addname = Console.ReadLine();

            Console.WriteLine("and address");
            addaddress = Console.ReadLine();

            friend = new Friend(addname, addaddress);

            friends.Add(friend);

            if (File.Exists(added))
            {
                using (StreamWriter addings = new StreamWriter(added))
                {
                    foreach (Friend friendsis in friends)
                    {
                        addings.WriteLine(friendsis);
                    }
                    addings.Close();
                }
            }

            else
            {
                Console.WriteLine("File not found!");
            }
        }

        public void Search()
        {
            Console.WriteLine("Give name or part of name you want to find");
            addname = Console.ReadLine();

            var foo = friends.FirstOrDefault(x => x.Name.StartsWith(addname));

            foreach (Friend frie in friends)
            {
                
                Friend friend = foo;
                Console.WriteLine(friend.Name);
            }
            
        }

    }

    
}
