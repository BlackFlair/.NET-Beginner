using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Assignment
{
    class Author : People
    {
        public Author(int id, string name) : base(id, name)
        {

        }

        public List<Visit> Visits { get; set; }

        public override void generateIdentityCard()
        {
            throw new NotImplementedException();
        }
    }
}
