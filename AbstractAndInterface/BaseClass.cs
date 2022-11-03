

abstract class BaseClass
{

    //abstract properties
    public abstract int number //public abstract 
    {
        get; set; 
    }

    //Constructor
    public BaseClass(int n)
    {
        // setup value to abstract properties
        number = n;
        //call simple (not abstract) methood - show();
        show();
    }

       //description simple not abstract method - not need to be implement in inheritance class
       //because public
    public void show()
    {
        //console input properies value
        Console.WriteLine("Properties number="+number); //we see on abstract properties on top
    }
}
