using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study2._2
{
    internal class Program
    {
        public class CountVowels
        {
            public static int Count(string s)
            {
                int count = 0;
                foreach (char c in s)
                {
                    if ("aeiou".Contains(c))
                    {
                        count++;
                    }
                }
                return count;
            }
        }
        static void Main(string[] args)
        {
            //Ask the user for a string
            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();

            //Call the Count method and store the result in a variable
            int vowels = CountVowels.Count(input);
            Console.WriteLine("The number of vowels in the string is: " + vowels);
        }
    }
}
