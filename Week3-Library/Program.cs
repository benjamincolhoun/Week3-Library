class Book
{
    string Title;
    string Author;
    string ISBN;

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

        
        Console.WriteLine($"Book title: {book.Title}");
        Console.WriteLine($"Book Author: {book.Author}");
        Console.WriteLine($"Book ISBN: {book.ISBN}");
        Console.WriteLine();

        
        Console.WriteLine($"Book title: {book1.Title}");
        Console.WriteLine($"Book Author: {book1.Author}");
        Console.WriteLine($"Book ISBN: {book1.ISBN}");
    }
}