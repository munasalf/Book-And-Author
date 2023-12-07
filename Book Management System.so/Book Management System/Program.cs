using System.Runtime.CompilerServices;
using static System.Reflection.Metadata.BlobBuilder;

namespace Book_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Author and Book Management System!");
            Console.WriteLine("Author Information:");
            author authors = new author("J.K.Rowling" , 1965, "British");
            Console.WriteLine(authors.displayAuthorInfo());
            Console.WriteLine("--------------------------");
            Console.WriteLine( $"Adding Books for :  {authors.Getname} ") ;
           
            Console.Write($"Enter Book Title: ");
            string title = Console.ReadLine();

            Console.Write("Enter Publication Year: ");
             int.TryParse( Console.ReadLine(), out int publicationYear);

            Console.Write("Enter Genre:");
            string Genre = Console.ReadLine();

            Booking book = new Booking( title, publicationYear, Genre);

          authors.addBooking( book );
            Console.WriteLine("----------------------------");

            Console.Write($"Enter Book Title: ");
            string title2 = Console.ReadLine();

            Console.Write("Enter Publication Year: ");
            int.TryParse(Console.ReadLine(), out int publicationYear2);

            Console.Write("Enter Genre:");
            string Genre2 = Console.ReadLine();

            Booking book2 = new Booking(title2, publicationYear2, Genre2);
            authors.addBooking(book2);
            Console.WriteLine("----------------------------");

            Console.Write($"Enter Book Title: ");
            string title3 = Console.ReadLine();

            Console.Write("Enter Publication Year: ");
            int.TryParse(Console.ReadLine(), out int publicationYear3);

            Console.Write("Enter Genre:");
            string Genre3 = Console.ReadLine();

            Booking book3 = new Booking(title3, publicationYear3, Genre3);
            authors.addBooking(book2);
            Console.WriteLine("----------------------------");

            Console.WriteLine("Displaying Books for J.K. Rowling:\r");
            Console.WriteLine("Books Authored by J.K. Rowling:\r ");

            authors.displaybooking();




        }
    }
}