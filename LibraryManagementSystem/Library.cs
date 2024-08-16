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
        //private List<Book> books = new List<Book>(100)
        //{
        //    new Book ("AB", "AW", 2019, 193313)
        //};

        private List<Book> borrowedBooks = new List<Book>(50);

        public int AvailableBookCount => books.Count;
        public int BorrowedBookCount => borrowedBooks.Count;
        public void DisplayAllBooks()
        {
            if (AvailableBookCount != 0)
            {
                int titleWidth = 30;
                int authorWidth = 20;
                int yearWidth = 6;
                int isbnWidth = 13;

                // Print header with fixed widths
                Console.WriteLine($"{"Title".PadRight(titleWidth)}{"Author".PadRight(authorWidth)}{"Year".PadRight(yearWidth)}{"ISBN".PadRight(isbnWidth)}");

                // Print each book with fixed widths
                foreach (Book book in books)
                {
                    Console.WriteLine($"{book.Title.PadRight(titleWidth)}{book.Author.PadRight(authorWidth)}{book.Year.ToString().PadRight(yearWidth)}{book.ISBN.ToString().PadRight(isbnWidth)}");
                    Thread.Sleep(1000);
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Library is Empty!");
                Console.ResetColor();
            }

        }
        public void DisplayBorrowedBooks()
        {

            if (BorrowedBookCount != 0)
            {
                // Define column widths
                int titleWidth = 30;
                int authorWidth = 20;
                int yearWidth = 6;
                int isbnWidth = 13;

                // Print header with fixed widths
                Console.WriteLine($"{"Title".PadRight(titleWidth)}{"Author".PadRight(authorWidth)}{"Year".PadRight(yearWidth)}{"ISBN".PadRight(isbnWidth)}");

                // Print each borrowed book with fixed widths
                foreach (Book book in borrowedBooks)
                {
                    Console.WriteLine($"{book.Title.PadRight(titleWidth)}{book.Author.PadRight(authorWidth)}{book.Year.ToString().PadRight(yearWidth)}{book.ISBN.ToString().PadRight(isbnWidth)}");
                    Thread.Sleep(1000);
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("There is no borrowed books at this moment");
                Console.ResetColor();
            }
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
        public void BorrowBook(string bookName, string bookAuthor)
        {
            if (BorrowedBookCount < 50)
            {
                // Find the book by title and author
                Book? bookToBorrow = books.FirstOrDefault(book => book.Title == bookName && book.Author == bookAuthor);

                if (bookToBorrow != null)
                {
                    borrowedBooks.Add(bookToBorrow);
                    books.Remove(bookToBorrow);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Book Borrowed Successfully!\n");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Book Not Found!\n");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sorry! You cannot borrow a book at this moment.");
                Console.ResetColor();
            }
        }

        private Book findBookByISBN (uint isbn)
        {
            return books.FirstOrDefault(book => book.ISBN == isbn);
        }
    }
}
