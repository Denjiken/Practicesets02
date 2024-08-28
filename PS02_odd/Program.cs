using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace PS02_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Listing odd numbers between 1 and 20:");

            for (int number = 1; number <= 20; number++)
            {
                if (number % 2 != 0)
                {
                    Console.WriteLine("Odd number: " + number);
                }
            }

            Console.WriteLine("Finished listing all odd numbers.");
        }
    }
}