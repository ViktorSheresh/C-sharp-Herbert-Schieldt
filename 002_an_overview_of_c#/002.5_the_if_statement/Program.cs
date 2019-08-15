using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_if_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Demonstrate the if

            int a, b, c;

            a = 2;
            b = 3;

            if (a < b) Console.WriteLine("a is less than b");

            //This won't display anything.

            if (a == b) Console.WriteLine("you won't see this");

            Console.WriteLine();

            c = a - b; // c contains -1

            Console.WriteLine("c contains - 1");

            if (c >= 0) Console.WriteLine("c is non-negative");
            if (c < 0) Console.WriteLine("c is negative");

            Console.WriteLine();

            c = b - a; // c now contains -1
            Console.WriteLine("c contains 1");
            if (c >= 0) Console.WriteLine("c is non-negative");
            if (c < 0) Console.WriteLine("c is negative");
        }
    }
}
