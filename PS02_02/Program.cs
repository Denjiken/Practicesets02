using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS02_02
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int number = 1; number <= 20; number++)
            {
                if (number % 2 != 0)
                {
                   Console.WriteLine("odd numbers: " + number); 
                }
            }
        }
    }
}