using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003._3_find_radius
{
    class Program
    {
        static void Main(string[] args)
        {
            Double r;
            Double area;

            area = 10.0;

            r = Math.Sqrt(area / 3.1416);
            Console.WriteLine("Radius is " + r);
        }
    }
}
