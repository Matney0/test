using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRolling
{
    //Create a class for the random number generator
    internal class RandomNumber
    {
        //Create a static instance of the Random class
        public static Random _random = new Random();
        public static int GetRandomNumber()
        {
            //Create a random number between 1 and 6
            int min = 1;
            int max = 6;

            int enemyMin = 1;
            int enemyMax = 6;

            return _random.Next(min, max);

            return _random.Next(enemyMin, enemyMax);

        }
    
    
        static void Main(string[] args)
        {
            int timesRolled = 0;
            int userInput = 0;
            int rollNumber = 0;
            do
            {
                //Prompt the user to pick a number between 1 and 6
                Console.WriteLine("Enter a number between 1 to 6");
                Console.WriteLine("Or press 'q' to quit");
                userInput = Convert.ToInt32(Console.ReadLine());
                rollNumber = GetRandomNumber();

                Console.WriteLine("The enemy rolled: " + rollNumber);

                //Condition if user input is greater than the random number
                if (userInput >rollNumber)
                {
                    Console.WriteLine("You win!");
                }
                //Condition if user input is equal to the random number
                else if (userInput ==rollNumber)
                {
                    Console.WriteLine("It's a tie!");
                }
                //Condition if user input is less than the random number
                else
                {
                    Console.WriteLine("You lose!");
                }



                (timesRolled)++;
                //Prompt the user to roll the dice again until they have rolled 6 times
            } while (userInput != 'q' && timesRolled < 6);
        }
    }

}
