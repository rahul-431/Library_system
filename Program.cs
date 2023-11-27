using System;
using System.Collections;
using System.Numerics;
namespace Library_system
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Tasks task = new Tasks();
            do
            {
                Console.WriteLine("\n\n\n----welcome to Library system-----\n ******Choose Any Option*******\n 1. Enter a new Book \n 2. Show all books detail\n" +
                "3. Enter new Member\n 4. Show all Members \n 5. Enter a new publisher\n 6. Show all publisher details\n 7. Enter a new Borrower \n 8. Show all Borrower \n 9. Exit App");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        task.addNewBook();
                        break;
                    case 2:
                        task.viewAllBooks();
                        break;
                    case 3:
                        task.addNewMember();
                        break;
                    case 4:
                        task.showAllMember();
                        break;
                    case 5:
                        task.addNewPublisher();
                        break;
                    case 6:
                        task.showAllPublisher();
                        break;
                    case 7:
                        task.addNewBorrower();
                        break;
                    case 8:
                        task.showAllBorrower();
                        break;
                    case 9:
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