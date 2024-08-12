using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class LibraryUser : User
    {
        public LibraryCard? LibraryID { get; set; }


        public void BorrowBook(Book book)
        {

        }
    }
}
