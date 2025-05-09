using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Starting message not incluided in loop
            Console.WriteLine("Welcome to the ATM simulator!");
            //Starting amount outside of while statement so it doesnt reset to 1000 after every option
            int balance = 1000;
            //Loop
            while (true)
            {
                //Menu options
                Console.WriteLine("What option from the menu would you like?");
                Console.WriteLine("1. Check balance");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Exit");

                //User choice 
                int menuChoice = int.Parse(Console.ReadLine());

                //Switch statement for each option
                switch (menuChoice)
                {
                    case 1:
                        //Displays balance
                        Console.WriteLine("Your balance is: $" + balance);
                        break;
                    case 2:
                        //Deposit option
                        Console.WriteLine("How much would you like to deposit?");
                        int deposit = int.Parse(Console.ReadLine());
                        //Add deposit to balance
                        balance += deposit;
                        //Displays new balance
                        Console.WriteLine("Your balance is now: $" + balance);
                        break;
                    case 3:
                        //Withdraw option
                        Console.WriteLine("How much would you like to withdraw?");
                        int withdraw = int.Parse(Console.ReadLine());
                        //If the withdraw is more then the balance, theyll have to try again
                        if (balance < withdraw)
                        {
                            Console.WriteLine("You dont have enough money to withdraw that much. Try again.");
                        }
                        //Otherwise the requested amount is withdrawen
                        else {
                            balance -= withdraw;
                            Console.WriteLine("Your balance is now: $" + balance);
                        }
                        break;
                    case 4:
                        //Can only leave when you chose the exit option
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
