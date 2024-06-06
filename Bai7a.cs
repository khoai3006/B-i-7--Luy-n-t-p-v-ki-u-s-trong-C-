using System;
using System.Diagnostics;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace Bai7a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint num1, num2, sum;

            Console.Write("Please enter real number that is not negative: ");
            while (!uint.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Invalid number. Please reenter real number is not negative: ");
            }
            Console.Write("Enter the second real number that is not negative: ");
            while (!uint.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Invalid number. Please reenter the second real number is not negative: ");
            }

            sum = num1 + num2;
            
            Console.WriteLine($"The sum of two real number is not negative is {sum}");
        }
    }
}
