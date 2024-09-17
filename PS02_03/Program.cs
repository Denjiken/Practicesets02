using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS02_03
{
    internal class Program
    {
        static string CheckVowelConsonant(char c) =>
            !char.IsLetter(c) ? $"{c} is not a letter." :
            "aeiou".Contains(char.ToLower(c)) ? $"{c} is a vowel." :
            $"{c} is a consonant.";

        static void Main(string[] args)
        {
            Console.Write("Enter a character: ");
            var input = Console.ReadLine();
            Console.WriteLine(input.Length == 1 ? CheckVowelConsonant(input[0]) : "Please enter a single character.");
        }
    }
}