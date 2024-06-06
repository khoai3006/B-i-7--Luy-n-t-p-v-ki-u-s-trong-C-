using System;

namespace Bai7h
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;

            Console.Write("Enter the first integer: ");
            while (!int.TryParse(Console.ReadLine(), out num1))
            {
                Console.Write("Invalid input. Please enter the first integer: ");
            }

            Console.Write("Enter the second integer: ");
            while (!int.TryParse(Console.ReadLine(), out num2))
            {
                Console.Write("Invalid input. Please enter the second integer: ");
            }

            Console.Write("Enter the third integer: ");
            while (!int.TryParse(Console.ReadLine(), out num3))
            {
                Console.Write("Invalid input. Please enter the third integer: ");
            }
            int max = num1;
            if (num2 > max)
            {
                max = num2;
            }
            if (num3 > max)
            {
                max = num3;
            }
            Console.WriteLine($"The largest of the three integer is {max}");
        }
    }
}
