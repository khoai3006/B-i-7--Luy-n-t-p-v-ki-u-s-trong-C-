using System;

namespace Bai7d
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sbyte num1,num2;
            sbyte sum;

            Console.WriteLine("Please enter the first 1 byte number: ");
            while (!sbyte.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Invalid value. Please reenter the first 1 byte number: ");
            }

            Console.WriteLine("Please enter the second 1 byte number: ");
            while (!sbyte.TryParse(Console.ReadLine(),out num2))
            {
                Console.WriteLine("Invalid value. Please reenter the second 1 byte number: ");
            }

            sum = (sbyte)(num1 + num2);
            Console.WriteLine($"The sum of two 1 byte number is {sum} ");
        }
    }
}
