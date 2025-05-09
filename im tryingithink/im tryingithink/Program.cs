using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace im_tryingithink
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 0;

            int sum = 0;
            while (number == 0) {
            try
            {
                Console.WriteLine("Enter a number");

                number = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Wrong");
            }

            Console.ReadLine();


            for (int i = i; i < number; i = i + 2)
            {
                sum = sum + i;
            }
            Console.WriteLine("Sum of odds", sum);
            }
    }
}
