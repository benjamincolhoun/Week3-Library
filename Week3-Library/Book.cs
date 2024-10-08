using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Library
{
    class Book
    {
        private string title; 
        private string author;
        private string isbn;
        private int pages;

        
        public string Title
        {
            get { return title; }  
            set { title = value; } 
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public string ISBN
        {
            get { return isbn; }
            set { isbn = value; }
        }

        
        public Book(string bookTitle, string bookAuthor, string bookISBN, int pages)
        {
            this.title = bookTitle;
            this.author = bookAuthor;
            this.isbn = bookISBN;
            this.pages = pages;
            
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Book title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine($"Book ISBN: {pages}");
            Console.WriteLine();
        }
    }
}
