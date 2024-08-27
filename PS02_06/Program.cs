using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PS02_06
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Enter a number: ");
            int n = int.Parse(Console.ReadLine());

            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }
            Console.WriteLine("Sum of digits: " + sum);
        }
    }
}