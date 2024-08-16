using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class LibraryUser : User
    {
        public LibraryCard? UserID { get; set; }

        public LibraryUser(string name) : base(name)
        {
            
        }

        public void BorrowBook(string bookName, string bookAuthor, Library library)
        {
            library.BorrowBook(bookName, bookAuthor);
        }
    }
}
