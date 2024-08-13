namespace LibraryManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome To The Libaray System.");
            Console.WriteLine("Are You Librarian or Regular User? (L/R)");
            Console.ResetColor();
            char userType = Console.ReadLine().ToUpper()[0];
            if (userType == 'L')
            {
                Console.WriteLine("Welcome Librarian! Pleae Enter Your Name: ");
                string librarianName = Console.ReadLine();
                Librarian librarian = new Librarian(librarianName);
                Console.WriteLine($"\nWelcome {librarian.Name} To Library Management System!");
                bool runApp = true;
                while (runApp) {
                    Console.WriteLine("Please Choose To:\n" +
                        "1. Add Book\n" +
                        "2. Remove Book\n" +
                        "3. Display All Books\n" +
                        "4. Display Borrowed Books\n" +
                        "5. Number of Available Books\n" +
                        "6. Number of Borrowed Books\n" +
                        "7. Exit\n");
                    ushort choice;
                    if (ushort.TryParse(Console.ReadLine(), out choice))
                    {
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("Please Enter Book Title: ");
                                string title = Console.ReadLine(); // Null Reference Exception
                                Console.WriteLine("Please Enter Book Author: ");
                                string author = Console.ReadLine(); // Null Reference Exception
                                Console.WriteLine("Please Enter Book Year: ");
                                ushort year = ushort.Parse(Console.ReadLine()); // Format Exception
                                Console.WriteLine("Please Enter Book ISBN: ");
                                uint isbn = uint.Parse(Console.ReadLine()); // Format Exception
                                Book newBook = new Book(title, author, year, isbn);
                                librarian.AddBook(newBook ,library);
                                break;
                            case 2:
                                Console.WriteLine("Please Enter Book ISBN to Remove: ");
                                uint isbnToRemove = uint.Parse(Console.ReadLine());
                                librarian.RemoveBook(isbnToRemove, library);
                                break;
                            case 3:
                                library.DisplayAllBooks();
                                break;
                            case 5:
                                Console.WriteLine("Number of Available Books in The Library: " +
                                    $"{librarian.AvailableBooks(library)}");
                                break;
                            case 6:
                                Console.WriteLine("Number of Borrowed Books in The Library: " +
                                    $"{librarian.BorrowedBooks(library)}");
                                break;

                            case 7:
                                Console.WriteLine("\nExiting...");
                                Thread.Sleep(1000);
                                runApp = false;
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                }

            }
            else if (userType == 'R')
            {

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please Enter Valid Input (L/R)!");
                Console.ResetColor();
            }
        }
    }
}
