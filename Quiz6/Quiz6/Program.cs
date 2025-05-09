using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz6
{
    internal class Program
    {

        static void Main(string[] args)
        {

            //Program that preforms multiple string manipulations
            //Allows user to input a string and then preform multiple manipulations on it

            //Welcome message
            Console.WriteLine("Welcome to the string manipulation program!");
            Console.ReadKey();
            Console.WriteLine("Please enter a string: ");
            //Reads user input for the string
            string sentence = Console.ReadLine();

            Console.WriteLine("You entered: " + sentence);

            //User options for the menu
            Console.WriteLine("Now that you've written your string, what would you like to do with it?");
            Console.WriteLine("1. Check if the string is a palindrome");
            Console.WriteLine("2. Count the number of vowels in the string");
            Console.WriteLine("3. Reverse the string");
            Console.WriteLine("4. Exit the program");
            //Reads user input for the menu
            int option = Convert.ToInt32(Console.ReadLine());
            do             {
                Menu(sentence);
            } while (option != 4);



         static void Menu(string sentence)
            //Menu
            switch (option)
            {
                case 1:
                    //Checks if the string is a palindrome
                    if (IsPalindrome(sentence))
                    {
                        Console.WriteLine("The string is a palindrome!");
                    }
                    else
                    {
                        Console.WriteLine("The string is not a palindrome!");
                    }
                    break;
                case 2:
                    //Counts the number of vowels in the string
                    Console.WriteLine("The number of vowels in the string is: " + CountVowels(sentence));
                    break;
                case 3:
                    //Reverses the string
                    Console.WriteLine("The reversed string is: " + ReverseString(sentence));
                    break;
                case 4:
                    //Exits the program
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    //Error message for invalid input
                    Console.WriteLine("Invalid input, please try again.");
                    break;





              //Method to see if a string is a palindrome
        public static bool IsPalindrome(string input)
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

        //Method to count the vowels in a string
        public static int CountVowels(string input)
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

        //Method to reverse the string
        public static string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }

}
}
