using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegaatit2
{
    class Friend
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Friend(){ }

        public Friend(string name, string email)
        {
            Name = name;
            Email = email;
        }

    }
}
