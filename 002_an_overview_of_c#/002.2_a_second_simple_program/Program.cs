using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_second_simple_program
{
    class Program
    {
        // This program demonstrates variables.
        static void Main(string[] args)
        {
            int x; // this declares a variable
            int y; // this declares another variable

            x = 100; //this assigns 100 to x

            Console.WriteLine("x contains " + x);

            y = x / 2;
            Console.Write("y containts x / 2: ");
            Console.WriteLine(y);
        }
    }
}
