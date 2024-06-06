using System;

namespace Bai7i
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint n;

            Console.Write("Enter a non-negative integer: ");
            while (!uint.TryParse(Console.ReadLine(), out n))
            {
                Console.Write("Invalid input. Please enter a non-negative integer: ");
            }

            bool isPrime = IsPrime(n);

            if (isPrime)
            {
                Console.WriteLine($"{n} is a prime number");
            }
            else
            {
                Console.WriteLine($"{n} is not a prime number");
            }
        }
        
        static bool IsPrime(uint u)
        {
            if( u < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(u); i++)
            {
                if (u % i == 0 )
                {
                    return false;
                }
            }
            return true;
        }
    }
}
