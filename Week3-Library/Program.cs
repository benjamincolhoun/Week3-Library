using Week3_Library;
class Program
{
    static void Main(string[] args)
    {
        
        Book book = new Book("C# for beginners", "Bill Gates", "1234567",50);
        Book book1 = new Book("C# Methods and classes", "Microsoft","55667778",100);

        book.DisplayInfo();
        book1.DisplayInfo();

        Console.WriteLine("Currently available books");
        book.DisplayInfo();
        book1.DisplayInfo();


        Member member = new Member(1, "John Smith", "1 High Street", 0790090090);
        Member member1 = new Member(2, "Mary Jones", "102 Garden Road", 0790345666);

        Console.WriteLine("Current library members");
        member.DisplayInfo();
        member1.DisplayInfo();

    }
}