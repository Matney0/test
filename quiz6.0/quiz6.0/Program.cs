using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz6._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                //Making menu for string manipulation
                Console.WriteLine("Enter the string you want to manipulate");
                string input = Console.ReadLine();

                Console.WriteLine("Enter the number of the operation you want to perform");
                Console.WriteLine("1. Reverse the string");
                Console.WriteLine("2. Count the voewls in the string");
                Console.WriteLine("3. See if the string is a palindrome");
                Console.WriteLine("4. Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                //Menu for string manipulation
                //Switch case for the menu and for its meultiple options
                //Program will run until the user chooses to exit
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("The reversed string is: " + ReverseString(input));
                        break;
                    case 2:
                        Console.WriteLine("The number of vowels in the string are: " + CountVowels(input));
                        break;
                    case 3:
                        Console.WriteLine("The string is a palindrome: " + IsPalindrome(input));
                        break;
                    case 4:
                        //Exit the program
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }

            public static string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

            public static int CountVowels(string input)
        //Counting the number of vowels in the string
        {
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u')
                {
                    count++;
                }
            }
            return count;
        }

        public static bool IsPalindrome(string input)
        //Checking if the string is a palindrome
        {
            string reverse = ReverseString(input);
            if (input == reverse)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
