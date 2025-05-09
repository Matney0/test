using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Collect of character letters/vowels
            var vowels = new System.Collections.Generic.HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
            //Total sum
            int totalVowels = 0;
            //User prompt
            Console.WriteLine("Enter a string to count the number of vowels:");

            //Takes answer and makes it lower case
            string userText = Console.ReadLine().ToLower();

            //Increments and counts all charachters
            for (int i = 0; i < userText.Length; i++)
            {
                if (vowels.Contains(userText[i]))
                {
                    //If vowel found, the total goes up
                    totalVowels++;
                }
            }
            Console.WriteLine("Total vowel count:" + totalVowels);

        }
    }
}
