using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Delegaatit2
{
    class MailBook:Friend
    {

        string tutut = @"tutut.csv";

        MailBook()
        {
            List<Friend> friends = new List<Friend>();

            using (StreamReader str = new StreamReader(tutut))
            {

            }

        }

    }
}
