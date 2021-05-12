using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Assignment
{
    class Comic : Book
    {
        public string Publication { get; set; }

        public Comic(int id, string name, string publication) : base(id, name)
        {
            Publication = publication;
        }
    }
}
