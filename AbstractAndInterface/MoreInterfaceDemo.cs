

//Main class
class MoreInterfaceDemo
{
    static void Main()
    {
        int m = 9;

        MyClass obj = new MyClass(12345);

        for (int i = 0; i <= m; i++)
        {
            Console.Write("|" + obj[m - i]);
        }
        Console.WriteLine("|");
    }
}