using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program is meant to calculate the sum of digits from a given integer! Lets begin.");
            Console.WriteLine("Enter an integer:");

            int userInt = int.Parse(Console.ReadLine());

            var sum = 0;

            while (userInt > 0)
            {
                //Extracts digit from Integer
                sum += userInt % 10;
                //Then removed when its added to sum
                userInt = userInt / 10;
            }
            Console.WriteLine("The sum of your integer is:" + sum);
        }
    }
}
