using System;

//Abstract class
abstract class Base
{
    // protected int field
    protected int num;

    //Constructor
    public Base(int n)
    {
        // call mathod
        set(n);
    }

    //Abstract method
    public abstract void show();
    public abstract void set(int n);
    public abstract int get();

}
