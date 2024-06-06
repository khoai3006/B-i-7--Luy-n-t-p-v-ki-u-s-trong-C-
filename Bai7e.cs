using System;
using System.CodeDom;

namespace Bai7e
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint n;
            ulong sum = 0;
            Console.WriteLine("Please enter a 4 byte number: ");
            while(!uint.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Invalid value. Please reenter a 4 byte number: ");
            }
            
            for (uint i = 1; i <= n; i++)
            {
                sum += i;
            }
            Console.WriteLine($"{sum} is the sum of numbers from 1 to {n}");
        }
    }
}
