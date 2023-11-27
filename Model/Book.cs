using System;
namespace Library_system{
    public class Book{
        private string bookId;
        private string author;
        private string price;
        private string title;
        private bool available=false;

        public string BookId{
            get{return bookId;}
            set{bookId=value;}
        }
        public string Author{
            get{return author;}
            set{author=value;}
        }
        public string Title{
            get{return title;}
            set{title=value;}
        }
         
         public string Price{
            get{return price;}
            set{price=value;}
        }
        public bool Available{
            get{return available;}
            set{available=value;}
        }
    }
}