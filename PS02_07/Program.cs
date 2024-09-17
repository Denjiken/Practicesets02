using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS02_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers separated by spaces:");
            string input = Console.ReadLine();

            int[] numbers = input.Split().Select(int.Parse).ToArray();
            int sum = numbers.Sum();

            Console.WriteLine($"The sum of the numbers is: {sum}");
        }
    }
}