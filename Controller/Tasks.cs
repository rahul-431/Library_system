using System;
namespace Library_system
{
    public class Tasks
    {
        ManageBook mb = new ManageBook();
        ManageMember mm=new ManageMember();
        ManagePublisher mp=new ManagePublisher();
        public void addNewBook()
        {
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
        }
        public void viewAllBooks()
        {
            List<Book> books = mb.getAllBooks();
            Console.WriteLine("\n------Book list-----\n");
            foreach (var i in books)
            {
                Console.WriteLine("Book Id :" + i.BookId + " Title: " + i.Title + " Author: " + i.Author + " Price: " + i.Price + " Availablity: " + i.Available);
            }
        }
        public void addNewMember()
        {
            Console.WriteLine("\n\n------Enter a new Member------");
            Console.WriteLine("Member Id: ");
            string memberId=Console.ReadLine();
            Console.WriteLine("Name: ");
            string name=Console.ReadLine();
            Console.WriteLine("Address: ");
            string address=Console.ReadLine();
            mm.addNewMember(memberId,name,address);               
        }
        public void showAllMember()
        {
            List<Member> members = mm.getAllMember();
            Console.WriteLine("\n -----Members List----\n");
            foreach (var i in members)
            {
                Console.WriteLine("Member Id :" + i.MemId + " Name: " + i.Name + " Address: " + i.Address);
            }
        }
        public void addNewPublisher()
        {
            Console.WriteLine("-----Add Publisher details------");
            Console.WriteLine("publisher Id: ");
            string pubId=Console.ReadLine();
            Console.WriteLine("Name: ");
            string name=Console.ReadLine();
            Console.WriteLine("Address: ");
            string address=Console.ReadLine();
            mp.addNewPublisher(pubId,name,address);
        }
        public void showAllPublisher()
        {
            Console.WriteLine("\n------Publisher List------\n");
            List<Publisher> publishers= mp.getAllPublisher();
            foreach (var i in publishers)
            {
                Console.WriteLine("Publisher Id: "+i.PubId+" name: "+i.Name+" address: "+i.Address);
            }
        }
        public void addNewBorrower(){

        }
        public void showAllBorrower(){

        }
    }
}