using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003._5_decimal_type
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal price;
            decimal discount;
            decimal discounted_price;
            // Compute discounted price.
            price = 19.95m;
            discount = 0.15m; // discount rate is 15%
            discounted_price = price - (price * discount);
            Console.WriteLine("Discounted price: $" + discounted_price);
        }
    }
}
