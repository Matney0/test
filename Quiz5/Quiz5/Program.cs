using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            int n = 1;
            int sum = 2;
            //Calculate sum of the factorials of all even numbers greater then 2, less then 10
            Console.WriteLine("This program calculates the sum of the factorials of all even numbers greater than 2 and less than 10. Press any key to begin");
            Console.ReadKey();
            //Calculate factorial of a number
            //Loop through all even numbers greater then 2, less then 10
            //Loop starts at 4 and increments by 2
            for (int i = 4; i < 10; i += 2)
            {
                //Set n as the inter i value
                n = i;
                //Factorial of a number
                int fact = 1;
                //Increments through all numbers less then n
                for (int j = 1; j <= n; j++)
                {
                    //Factorial is set as inter j value
                    fact *= j;
                }
                //Add the factorial to the sum
                sum += fact;
            }
            //Sum value of factorials
            //Program should spit out 41066 as the sum of all even numbers in 8 
            Console.WriteLine("The sum of the factorials is: " + sum);

        }
    }
}
