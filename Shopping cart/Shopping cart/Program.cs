using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_cart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Decleratrions of variables
            Dictionary<string, int> sub = new Dictionary<string, int>();

            //Adding elements to the dictionary
            sub.Add("Apple", 1);
            sub.Add("Banana", 2);
            sub.Add("Orange", 3);
            sub.Add("Grapes", 4);
            sub.Add("Mango", 5);

            //Prioduct management
            Console.WriteLine("Welcome to The Product Management App!");

            Console.WriteLine("1. Add Product  2.Remove Product  3.Search for pricing 4.Display all products  5.Quit");
            int input = Convert.ToInt32(Console.ReadLine());

            if ( input == 1)
            {
                Console.WriteLine("Enter the product name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the product price");
                int price = Convert.ToInt32(Console.ReadLine());
                sub.Add(name, price);
            }
            else if (input == 2)
            {
                Console.WriteLine("Enter the product name to remove");
                string name = Console.ReadLine();
                sub.Remove(name);
            }
            else if (input == 3)
            {
                Console.WriteLine("Enter the product name to search for pricing");
                string name = Console.ReadLine();
                Console.WriteLine("The price of the product is " + sub[name]);
            }
            else if (input == 4)
            {
                foreach (KeyValuePair<string, int> kvp in sub)
                {
                    Console.WriteLine("Product = {0}, Price = {1}", kvp.Key, kvp.Value);
                }
            }
            else if (input == 5)
            {
                Console.WriteLine("Thank you for using the app!");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
