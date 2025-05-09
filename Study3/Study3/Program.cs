using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study3
{
    internal class Program
    {
        //ConvertToUSD method
        public static double ConvertToUSD(double amount)
        {
            return amount * 1.3;
        }
        //ConvertToEUR method
        public static double ConvertToEUR(double amount)
        {
            return amount * 1.1;
        }
        //ConvertToJPY method
        public static double ConvertToJPY(double amount)
        {
            return amount * 110.0;
        }
        static void Main(string[] args)
        {
            //User to input amount and currency they want to convert from
            Console.WriteLine("Enter the amount you want to convert: ");
            double amount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the currency you want to convert from (USD, EUR, JPY): ");
            string currency = Console.ReadLine();
            //Switch statement to determine which method to call

            switch (currency)
            {
                case "USD":
                    Console.WriteLine("Amount in USD: " + amount);
                    Console.WriteLine("Amount in EUR: " + ConvertToEUR(amount));
                    Console.WriteLine("Amount in JPY: " + ConvertToJPY(amount));
                    break;
                case "EUR":
                    Console.WriteLine("Amount in USD: " + ConvertToUSD(amount));
                    Console.WriteLine("Amount in EUR: " + amount);
                    Console.WriteLine("Amount in JPY: " + ConvertToJPY(ConvertToUSD(amount)));
                    break;
                case "JPY":
                    Console.WriteLine("Amount in USD: " + ConvertToUSD(amount));
                    Console.WriteLine("Amount in EUR: " + ConvertToEUR(ConvertToUSD(amount)));
                    Console.WriteLine("Amount in JPY: " + amount);
                    break;
                default:
                    Console.WriteLine("Invalid currency");
                    break;
            }
        }
    }
}
