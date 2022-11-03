

//Class realize interface and abstract class
class MyClass : BaseClass, First, Second
{
    private int num;

    //constructor with one argument (from abstracrt class)
    //constructor described to get value int(n) into base calass base(n)
    public MyClass(int n) : base(n) { } //because block is empty - logic in BaseClass



    //describe two methods from First interface
    public void setNum(int n)
    {
        num=n;
    }

    public int getNum()
    {
        return num;
    }


    public override int number //--- describe properties from the BaseClass 
    {
        //accesor to read value
        get
        {
            //call method from Firs interface
            return getNum();
        }
        set
        {
            //call method from Firs interface
            setNum(value);
        }
    }

    //describe indexator for Second interface

    public int this[int k]
    {
        //accesor for reading value
        get
        {
            //local variable
            int r = number;

            //cut numbers
            for (int i = 0; i < k; i++)
            {
                r /= 10;
            }
            //return result
            return r % 10;
        }
    }
}