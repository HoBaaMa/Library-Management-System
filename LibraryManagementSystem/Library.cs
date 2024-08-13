using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class Library
    {
        // Create A List for bookes And borrowedBooks
        private List<Book> books = new List<Book>(100);
        private List<Book> borrowedBooks = new List<Book>(50);

        public int AvailableBookCount => books.Count;
        public int BorrowedBookCount => borrowedBooks.Count;
        public void DisplayAllBooks()
        {
            //// Define the column widths for formatting
            //ushort titleWidth = 30;
            //ushort authorWidth = 20;
            //ushort yearWidth = 6;
            //ushort isbnWidth = 12;
            Console.WriteLine("Book Title\t Author\t Book Year\t ISBN");
            foreach (Book book in books)             
            {
                Console.WriteLine($"{book.Title}\t {book.Author}\t {book.Year}\t {book.ISBN}");
                Thread.Sleep(1000);
            }
        }
        public void DisplayBorrowedBooks()
        {

        }
        public void Add(Book newBook)
        {
            if (books.Count < 100) 
            {
                books.Add(newBook);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Book Added Successfully!\n");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("Library Capacity is Full!\n");
            }
        }
        public void Remove(uint isbn)
        {
            if (books.Count > 0)
            {
                Book FoundedBook = findBookByISBN(isbn);
                if (FoundedBook != null)
                {
                    books.Remove(FoundedBook);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Book Removed Successfully!\n");
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine("Book Not Found!\n");
                }
            }
            else
            {
                Console.WriteLine("Library is Empty!");
            }
        }
        private Book findBookByISBN (uint isbn)
        {
            return books.FirstOrDefault(book => book.ISBN == isbn);
        }

    }
}
