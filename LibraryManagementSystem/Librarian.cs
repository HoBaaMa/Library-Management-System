using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class Librarian : User
    {
        public Librarian(string librarianName) : base (librarianName)
        {
            
        }
        public uint EmployeeId { get; set; }
        public void AddBook (Book newBook, Library library)
        {
            library.Add(newBook);
        }
        public void RemoveBook (uint isbn, Library library)
        {
            library.Remove(isbn);
        }
        public int AvailableBooks (Library library)
        {
            return library.AvailableBookCount;
        }
        public int BorrowedBooks (Library library)
        {
            return library.BorrowedBookCount;
        }
    }
}
