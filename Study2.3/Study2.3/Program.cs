using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ATM menu
            Console.WriteLine("Welcome to the ATM");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Please select an option: ");
            int option = Convert.ToInt32(Console.ReadLine());

            do {
            //switch statement
            switch (option)
            {
                case 1:
                    Console.WriteLine("Your balance is $1000");
                    break;
                case 2:
                    Console.WriteLine("Enter the amount to deposit: ");
                    int deposit = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("You have deposited $" + deposit);
                    break;
                case 3:
                    Console.WriteLine("Enter the amount to withdraw: ");
                    int withdraw = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("You have withdrawn $" + withdraw);
                    break;
                case 4:
                    Console.WriteLine("Thank you for using the ATM");
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
            } while (option != 4);
        }
    }
}
