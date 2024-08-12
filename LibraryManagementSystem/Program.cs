namespace LibraryManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome To The Libaray System.");
            Console.WriteLine("Are You Librarian or Regular User? (L/R)");
            Console.ResetColor();
            char userType = Console.ReadLine().ToUpper()[0];
            if (userType == 'L')
            {

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
