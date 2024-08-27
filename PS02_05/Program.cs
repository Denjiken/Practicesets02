using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PS02_05
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            Dictionary<char, int> frequency = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (frequency.ContainsKey(c))
                {
                    frequency[c]++;
                }
                else
                {
                    frequency[c] = 1;
                }
            }

            foreach (var kvp in frequency)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}