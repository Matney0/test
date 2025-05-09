using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaNDOM
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Random rnd = new Random();

        int secret = rnd.Next();

            bool winning = false;
            int guess = 0;
            {
                Console.WriteLine("What is your guess?");
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess > secret)
                {
                    Console.WriteLine("Too big");
                }
                else if (guess < secret)
                {
                    Console.WriteLine("Too small");
                }
                else
                {
                    winning = true;
                }




            }
            while (winning)
            {
                Console.WriteLine("You win!");

                Console.ReadLine();
            }

        }
    }
}
