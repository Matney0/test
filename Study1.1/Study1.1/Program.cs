using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Asks users for personal information then print out a statement
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();

            Console.WriteLine("Hello! My name is " + name + " " + lastName + ". I am " + age + " years old and my favorite color is " + color + "!");
        }
    }
}
