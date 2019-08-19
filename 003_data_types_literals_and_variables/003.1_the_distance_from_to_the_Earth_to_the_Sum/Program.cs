using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_distance_from_Earth_to_the_Sun
{
    class Program
    {
        static void Main(string[] args)
        {
            // Compute the distance from the Earth to the Sun, in inches.

            long inches;
            long miles;

            miles = 93000000; // 93,000,000 miles to the Sun
            // 5,280 feet in a mile, 12 inches in a foot.
            inches = miles * 5280 * 12;

            Console.WriteLine("Distance to the sun: " + inches + " inches.");
        }
    }
}
