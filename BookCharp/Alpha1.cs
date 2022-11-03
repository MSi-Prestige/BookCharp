namespace BookCharp
{
    class Alpha1 : BaseText
    {
        //private field link to array
        private char[] symbs;

        //constructor

        public Alpha1(string t) : base()
        {
            //text field setup value   Text into t goes from method and setup text = t;
            text = t;
        }

        //override text method from baseText class

        public override string text
        {
            get
            {
                return new string(symbs);

            }   //result text string

            set
            {
                // creating sybm array and setup value to field
                symbs = value.ToCharArray();
            }
        }

        //override int lenght method value
        public override int length
        {
            get
            {
                return symbs.Length;
            }
        }

        //override indexator
        public override char this[int k]
        {
            get
            {
                return symbs[k];
            }
        }


    }
}
