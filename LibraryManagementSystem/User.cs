﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public abstract class User
    {
        public string? Name { get; set; }
        protected User(string name)
        {
            Name = name;
        }
        //public Book[] DisplayBooks()
        //{

        //}
    }
}
