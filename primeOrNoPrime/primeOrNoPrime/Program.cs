using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeOrNoPrime
{
    internal class Program
    {
        static int Main(string[] args)
        {
            //Program to check if a number is prime or not
            Console.WriteLine("Enter a number to check if it is prime or not");
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 1; i <= num)
            {
                if (num % i == 0)
                {
                    count;
                }
                if (count == 2)
                {
                    Console.WriteLine("The number is prime");
                }
                else
                {
                    Console.WriteLine("The number is not prime");
                }
            }


        }
    }
}
