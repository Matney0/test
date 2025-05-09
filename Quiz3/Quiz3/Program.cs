using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Promting user for the first of three number to be entered
            Console.WriteLine("Enter first number");
            //As an example i have a practice user imput
            int number = 6;

            Console.WriteLine("Enter second number");
            //As an example i have a practice user imput
            int secondNumber = 13;

            Console.WriteLine("Lastly enter third number");
            //As an example i have a practice user imput
            int thirdNumber = 2;
            //testing first condition 
            if ( number > secondNumber)
                    {
                Console.WriteLine("First number has higher value");
            }
            else if (secondNumber > thirdNumber)
                {
                Console.WriteLine("The second number is of higher value");
            }
            else
               {
                Console.WriteLine("The third number is of higher value");
                Console.WriteLine("Out of the first and last number, the third number is the highest value")
            }
            
        }
    }
}
