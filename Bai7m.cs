using System;
using System.Diagnostics.Contracts;

namespace Bai7m
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Please enter an integer: ");

            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.Write("Invalid input. Please enter an integer: ");
            }

            bool isPerfect = IsPerfectNumber(n);

            if(isPerfect)
            {
                Console.WriteLine($"{n} is a perfect number");
            }
            else
            {
                Console.WriteLine($"{n} is not a perfect number");
            }
        }

        static bool IsPerfectNumber(int u)
        {
            if (u <= 1)
            {
                return false;
            }

            int sumOfDivisors = 0;
            
            for (int i = 1; i <= u / 2; i++)
            {
                if(u % 1 == 0)
                {
                    sumOfDivisors += i;
                }
            }
            return sumOfDivisors == u;
        }
    }
}
