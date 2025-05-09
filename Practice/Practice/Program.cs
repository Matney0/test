using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class CharCount
    {
        static void Main(string[] args)
        {
            //String an application to input string and count how many times each character is duplicated in the string
            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();
            input = input.ToLower();

            //Create a dictionary to store the characters and their count
            char[] characters = input.ToCharArray();
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            foreach (char c in characters) {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount.Add(c, 1);
                }
                Console.WriteLine("Character: {0} Count: {1}", c, charCount[c]);
            }
    }
}
}
