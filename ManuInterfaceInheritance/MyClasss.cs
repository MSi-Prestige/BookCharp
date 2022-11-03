
//Interface inheritance another interfaces
//Class realize interface
class MyClasss : MyInterface
{
    private int num;
    public MyClasss(int n)
    {
        number = n;
        show();
    }

    public void show()
    {
        Console.WriteLine("Properties number="+number);
    }

    public void setNum(int n)
    {
        num = n;
    }

    public int getNum()
    {
        return num;
    }

    public int number
    {
        get
        {
            return getNum();
        }
        set
        {
            setNum(value);
        }
    }

    public int this[int k]
    {
        get
        {
            int r = number;

            for (int i = 0; i < k; i++)
            {
                r /= 10;
            }
            return r%10;
        }
    }

}
