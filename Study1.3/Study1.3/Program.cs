using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calculate the area and perimeter of a rectangle

            Console.WriteLine("Enter the length of the rectangle: ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the width of the rectangle: ");
            double width = Convert.ToDouble(Console.ReadLine());

            //Calculate the area of the rectangle
            double area = length * width;
            Console.WriteLine("The area of the rectangle is: " + area);

            //Calculate the perimeter of the rectangle
            double perimeter = 2 * (length + width);
            Console.WriteLine("The perimeter of the rectangle is: " + perimeter);
        }
    }
}
