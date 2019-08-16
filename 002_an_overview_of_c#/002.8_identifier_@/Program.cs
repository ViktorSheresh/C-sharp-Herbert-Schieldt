using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The___identifier
{
    class Program
    {
        static void Main(string[] args)
        {
            //Demonstrate an @ identifier

            int @if; // use if as an identifier
            for (@if = 0; @if < 10; @if++)
                Console.WriteLine("@if is " + @if);
        }
    }
}