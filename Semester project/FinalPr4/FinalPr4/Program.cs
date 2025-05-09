using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPr4
{
    internal class Program
    {
        static void InputArray( int userNumber)
        {
            int[] integerArray = { };
            if (integerArray[10] <10 10)
            {
                Console.WriteLine("Enter another number");
                int anotherNumber =int.Parse(Console.ReadLine());
                integerArray[0] = anotherNumber;
            }

            
        }
        static void PrintArray()
        {

        }
        static void FindMax()
        {

        }
        static void SortArray()
        {

        }
        static void IsHaving()
        {

        }
        static void IsPrime()
        {

        }
        static void Main(string[] args)
        {

            Console.WriteLine("Sorry in advance the way i did it is torture");
            Console.WriteLine("Enter an iteger array with 10 elements: ");
            int userNumber = int.Parse(Console.ReadLine());
            InputArray(userNumber);

        }
    }
}
