using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Demonstrate the for loop

            int count;

            for (count = 0; count < 5; count = count + 1)
                Console.WriteLine("This is count: " + count);
            Console.WriteLine("Done!");
        }
    }
}
