
// Derivative class base on abstract class (Base)

class Alpha : Base
{
    //need imeplemet all inheritance abstract members get,set,show

    // proteccted int field
    protected int val;

    //Constructor 
    public Alpha(int n) : base(n)
    {
        show();
    }

    //override abstract method
    public override void show()
    {
        Console.WriteLine("Alpha: {0}, {1} and {2}", num,val,get());
    }

    //override abstract method
    public override void set(int n)
    {
        num = n;
        val = n + 3;
    }

    //override abstract method
    public override int get()
    {
        // num ( first number 50/2  = 25 )
        return num / 2;
    }

}
