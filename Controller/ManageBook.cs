using System;
namespace Library_system{
    class ManageBook{
        Book book=new Book();
        public void addNewBook(string bookId,string author, string title,string price, bool avail)
        {

            book.BookId=bookId;
            book.Author=author;
            book.Title=title;
            book.Price=price;
            book.Available=avail;   
        }
        public void removeBook(string bookId)
        {

        }
        public string getAllBooks()
        {
            return "Book id: "+book.BookId+" Title: "+book.Title+" Author: "+book.Author+" Price: "+book.Price;
        }
    }
}