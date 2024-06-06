using System;

namespace Bai7c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint number;

            Console.WriteLine("Please enter a number: ");
            while(!uint.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Invalid value. Please reenter a number: ");
            }
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is a even number");
            }
            else
            {
                Console.WriteLine($"{number} is a even odd");
            }
        }
    }
}
