


//First interface

//Interface inheritance another interfaces

//Class realize interface
//Main class

class InterfaceDemo
{
    static void Main()
    {
        int m = 9;

        MyClasss obj = new MyClasss(12345);

        for(int i = 0; i <= m; i++)
        {
            Console.Write("|"+ obj[m-i]);
        }
        Console.WriteLine("|");
    }
}