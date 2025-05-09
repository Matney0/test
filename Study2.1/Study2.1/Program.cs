using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Program that calculates the sum of digits of a given interger number
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            Console.WriteLine("The sum of the digits is: " + sum);
        }
    }
}
