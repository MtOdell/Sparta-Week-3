namespace SafariParkApp;

internal class Program
{
    static void Main(string[] args)
    {
        //Person cathy = new Person("Catherine", "French") {Age = 21};
        //Console.WriteLine(cathy.GetFullName());
        //Console.WriteLine(cathy.GetAge());
        //Console.WriteLine(cathy.GetNickname());
        //ShoppingList aList = new ShoppingList { Bread = 2, Bacon = 100 };
        Point3D point = new Point3D(1, 3, 4);
        point.Translate();
        Console.WriteLine(point.y);
    }
}