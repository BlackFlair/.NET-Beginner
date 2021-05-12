using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Assignment
{
    class Magzine : Book
    {
        public string Author { get; set; }

        public Magzine(int id, string name, string author) : base(id, name)
        {
            Author = author;
        }
    }
}
