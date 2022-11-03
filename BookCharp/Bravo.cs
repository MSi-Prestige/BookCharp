
// Derivative class base on abstract class (Base)

class Bravo : Base
{
    protected int val;

    public Bravo(int n): base(n)
    {
        show();
    }

    public override void show()
    {
        Console.WriteLine("Bravo: {0}, {1} and {2}", num,val,get());
    }

    //override abstract method
    public override void set(int n)
    {
        num = n;
        val = n - 1;
    }

    //override abstract method
    public override int get()
    {
        return num / 5;
    }


}
