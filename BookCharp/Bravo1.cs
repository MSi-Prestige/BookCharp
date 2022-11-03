namespace BookCharp
{
    class Bravo1 : BaseText
    {
        //private field link to array
        private string txt;

        //constructor

        public Bravo1(string t) : base()
        {
            //text field setup value   Text into t goes from method and setup text = t;
            text = t;
        }

        //override text method from baseText class

        public override string text
        {
            get
            {
                return txt;

            }   //result text string

            set
            {
                txt = value;
            }
        }

        //override int lenght method value
        public override int length
        {
            get
            {
                return txt.Length;
            }
        }

        //override indexator
        public override char this[int k]
        {
            get
            {
                return txt[k];
            }
        }


    }

}
