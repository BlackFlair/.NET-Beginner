using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Assignment
{
    class Librarian : People
    {
        public Librarian(int id, string name) : base(id, name)
        {

        }

        public override void generateIdentityCard()
        {
            throw new NotImplementedException();
        }
    }
}
