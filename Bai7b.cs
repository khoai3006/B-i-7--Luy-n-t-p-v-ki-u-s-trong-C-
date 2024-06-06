using System;
using System.CodeDom;

namespace Bai7b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ushort length, width;
            uint area, perimeter;

            Console.WriteLine("Please enter the length of the rectangle");
            while (!ushort.TryParse(Console.ReadLine(), out length)) 
            {
                Console.WriteLine("Invalid value. Please reenter the length of the ractangle: ");
            }

            Console.WriteLine("Please enter the width of the rectangle");
            while (!ushort.TryParse(Console.ReadLine(), out width))
            {
                Console.WriteLine("Invalid value. Please reenter the width of the ractangle: ");
            }
            area = (uint)(length * width);
            perimeter = (uint)(2 * (area + width));
            Console.WriteLine($"The area of the rectangle is: {area}");
            Console.WriteLine($"The perimeter of the rectangle is: {perimeter}");

        }
    }
}
