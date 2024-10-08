using Week3_Library;
class Program
{
    static void Main(string[] args)
    {
        
        Book book = new Book("C# for beginners", "Bill Gates", "1234567");
        Book book1 = new Book("C# Methods and classes", "Microsoft","55667778");

        

        
        book.DisplayInfo();
        book1.DisplayInfo();

    }
}