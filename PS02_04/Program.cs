using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PS02_04
{
    public class Program
    {
        public static void Main(string[] args)
        {
      Console.Write("Enter a string: ");
      string input = Console.ReadLine();

      string cleanedString = new string(input.Where(char.IsLetterOrDigit).ToArray()).ToLower();
      bool isPalindrome = true;
      for (int i = 0; i < cleanedString.Length / 2; i++)
      {
        if (cleanedString[i] != cleanedString[cleanedString.Length -i - 1])
        {
            isPalindrome = false;
            break;
        }
      }
      if (isPalindrome)
      {
        Console.WriteLine($"{input} is palindrome.");
      }
      else
      {
        Console.WriteLine($"{input} is not palindrome.");
      }
      }
    }  
}