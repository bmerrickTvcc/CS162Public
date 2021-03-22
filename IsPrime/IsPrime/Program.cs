using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IsPrime.Helpers;

namespace IsPrime
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine($"2: {PrimeHelper.IsPrime(2)} (should be true)");

            Console.WriteLine($"61: {PrimeHelper.IsPrime(61)} (should be true)");

            Console.WriteLine($"999: {PrimeHelper.IsPrime(999)} (should be false)");

            Console.WriteLine($"3623: {PrimeHelper.IsPrime(3623)} (should be true)");

            Console.WriteLine($"9973: {PrimeHelper.IsPrime(9973)} (should be true)");
        }
    }
}
