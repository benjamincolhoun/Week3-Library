﻿class Book
{
    string Title;
    string Author;
    string ISBN;

    public Book(string bookTitle, string bookAuthor, string bookISBN)
    {
        Title = bookTitle;
        Author = bookAuthor;
        ISBN = bookISBN;
    }
    void Display()
    {
        Console.WriteLine($"Book title: {Title}");
        Console.WriteLine($"Book Author: {Author}");
        Console.WriteLine($"Book ISBN: {ISBN}");
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        
        Book book = new Book("C# for beginners", "Bill Gates", "1234567");
        Book book1 = new Book("C# Methods and classes", "Microsoft","55667778");

        

        
        book.Display();
        book1.Display();
    }
}