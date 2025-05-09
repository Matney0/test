using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceFactorial
{
    internal class Program
    {
        //static void HandleFactorial 
        public static void HandleFactorial(int number)
        {
            //Writing code to calculate factorial of a number
            Console.WriteLine("enter number to calculate factorial of number");
            //Program ask and converts user input into integer
            number = Convert.ToInt32(Console.ReadLine());
            int factoral = Int32.MaxValue;
            int fact = 1;
            for (int i = 1; i <= number; i++)
            {
                fact = fact * 1;
            }
          factoral = fact;

            return factoral;
        }
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(HandleFactorial(i).ToString);
            }


        }
    }
}
