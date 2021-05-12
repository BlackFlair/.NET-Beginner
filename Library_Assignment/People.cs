using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Assignment
{
    abstract class People
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public People(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public abstract void generateIdentityCard();
    }
}
