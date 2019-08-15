using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_code_block
{
    class Program
    {
        static void Main(string[] args)
        {
            //Demonstrate a block of code

            int i, j, d;

            i = 5;
            j = 10;

            //The target of this if is a block.
            if (i != 0)
            {
                Console.WriteLine("i does not equal zero");
            }
            d = j / i;
            Console.WriteLine("j / i is" + d);
        }
    }
}
