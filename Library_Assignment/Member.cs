using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Assignment
{
    class Member : People
    {
        public int Due { get; set; }
        public Member(int id, string name, int due) : base(id, name)
        {
            Due = due;
        }

        public List<Book> Referred { get; set; }
        public List<Visit> Visits { get; set; }

        public override void generateIdentityCard()
        {
            throw new NotImplementedException();
        }
    }
}
