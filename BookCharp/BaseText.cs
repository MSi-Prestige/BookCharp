using System;


namespace BookCharp
{
    abstract class BaseText
    {
        //abstract text value
        public abstract string text { get; set; }

        public abstract char this[int k] { get; }

        public abstract int length { get; }
    }

}
