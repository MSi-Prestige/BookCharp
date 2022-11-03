using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCharp
{
    class AbstrPropAndIndexDemo
    {
        //main method

        static void Main()
        {
            //reference on object inheritance class is writening into object variable (base class)

            BaseText obj = new Alpha1("Alpha1");

            Console.WriteLine(obj.text);

            //new value text field

            obj.text = "BaseText";

            //indexing object

            for (int k = 0; k < obj.length; k++)
            {
                Console.Write("|" + obj[k]);
            }

            Console.WriteLine("|");

            // link/reference on object inheritance class writtening into object variable base class

            obj = new Bravo1("Bravo1");

            for(int k = 0; k < obj.length; k++)
            {
                Console.Write("|" + obj[k]);
            }

            Console.WriteLine("|");
            //new value text properties 

            obj.text = "Base1";

            Console.WriteLine(obj.text);

        }
    }
}
