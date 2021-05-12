﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Assignment
{
    abstract class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Book(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
