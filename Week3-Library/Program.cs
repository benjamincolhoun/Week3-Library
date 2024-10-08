﻿class Book
{
    string Title;
    string Author;
    string ISBN;

    void Display()
    {
        Console.WriteLine($"Book title: {Title}");
        Console.WriteLine($"Book Author: {Author}");
        Console.WriteLine($"Book ISBN: {ISBN}");
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        
        Book book = new Book();

        
        book.Title = "C# for beginners";
        book.Author = "BillGates";
        book.ISBN = "12345678";

        
        Book book1 = new Book();
        book1.Title = "C# Methods and classes";
        book1.Author = "Microsoft";
        book1.ISBN = "55667778";

        
        book.Display();
        book1.Display();
    }
}