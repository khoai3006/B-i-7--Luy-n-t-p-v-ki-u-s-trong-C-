using System;

namespace Bai7g
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double length, width, area, perimeter;

            Console.WriteLine("Please enter the length of the rectangle (8-byte floating point): ");
            while(!double.TryParse(Console.ReadLine(),out length))
            {
                Console.WriteLine("Invalid value. Please reenter the length of the rectangle (8-byte floating point: )");
            }

            Console.WriteLine("Please enter the width of the rectangle (8-byte floating point)");
            while(!double.TryParse(Console.ReadLine(),out width))
            {
                Console.WriteLine("Please enter the width of the rectangle (8-byte floating point)");
            }

            area = length * width;

            perimeter = 2 * (length + width);

            Console.WriteLine($"The area of the rectangle is: {area}");
            Console.WriteLine($"The perimeter of the rectangle is: {perimeter}");

        }
    }
}
