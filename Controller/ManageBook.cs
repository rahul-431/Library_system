using System;
namespace Library_system{
    class ManageBook{
        List<Book> books= new List<Book>();
        public void addNewBook(string bookId,string author, string title,string price, bool avail)
        {
            Book book=new Book();
            book.BookId=bookId;
            book.Author=author;
            book.Title=title;
            book.Price=price;
            book.Available=avail;
            books.Add(book);   
        }
        public void removeBook(string bookId)
        {

        }
        public List<Book> getAllBooks()
        {
            return books;
        }
    }
}