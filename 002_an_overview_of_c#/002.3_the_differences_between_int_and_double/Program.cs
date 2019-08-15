using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Int_and_double
{
    class Program
    {
        static void Main(string[] args)
        {
            int ivar;       // this declares an int variable
            double dvar;    // this declares a floating-point variable

            ivar = 100;     // assign ivar the value 100
            dvar = 100.0;   // assign dvar the value 100.0

            Console.WriteLine("Original value of ivar: " + ivar);
            Console.WriteLine("Original value of dvar: " + dvar);

            Console.WriteLine(); // print a blank line

            //Now, divide both by 3.
            ivar = ivar / 3;
            dvar = dvar / 3.0;

            Console.WriteLine("ivar after division: " + ivar);
            Console.WriteLine("ivar afte division: " + dvar);
        }
    }
}
