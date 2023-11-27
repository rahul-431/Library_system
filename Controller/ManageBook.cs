using System;
namespace Library_system{
    class ManageBook{
        Book book=new Book();
        public void addNewBook(string bookId,string author, string title,string price, bool avail)
        {

            book.bookId=bookId;
            book.author=author;
            book.title=title;
            book.price=price;
            book.available=avail;   
        }
        public void removeBook(string bookId)
        {

        }
        public string getAllBooks()
        {
            return "Book id: "+book.bookId+" Title: "+book.title+" Author: "+book.author+" Price: "+book.price;
        }
    }
}