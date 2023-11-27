using System;
using System.Collections;
using System.Numerics;
namespace Library_system
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ManageBook mb = new ManageBook();
            do
            {
                Console.WriteLine("\n\n\n----welcome to Library system-----\n ******Choose Any Option*******\n 1. Enter a new Book \n 2. Show all books detail\n"+
                "\n 3. Enter new Member\n 4. Show all Members \n 5. Enter a new publisher\n 6. Show all publisher details\n 7. Enter a new Borrower \n 8. Show all Borrower \n 9. Exit App");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("\n\n-----Enter Book details-------");
                        Console.WriteLine("BookI Id: ");
                        string bid = Console.ReadLine();
                        Console.WriteLine("Title: ");
                        string title = Console.ReadLine();
                        Console.WriteLine("Author: ");
                        string author = Console.ReadLine();
                        Console.WriteLine("Price: ");
                        string price = Console.ReadLine();

                        mb.addNewBook(bid, author, title, price, true);
                        break;
                    case 2:
                        List<Book> books=mb.getAllBooks();
                        foreach (var i in books)
                        {
                            Console.WriteLine("Book Id :"+i.BookId+" Title: "+i.Title+" Author: "+i.Author+" Price: "+i.Price+" Availablity: "+i.Available);                            
                        }
                        break;
                    case 3:
                        Console.WriteLine("\n\n------Enter new Meber------");
                        
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("------Please Enter the right options. Thank you------");
                        break;
                }
            } while (true);
        }
    }
}