﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class Book
    {
        public string? Title { get; set; }
        public string? Author { get; set; }
        public ushort Year { get; set; }
        public uint ISBN { get;  set; }
        public Book(string title, string author, ushort year, uint isbn)
        {
            Title = title;
            Author = author;
            Year = year;
            ISBN = isbn;
        }

    }
}
