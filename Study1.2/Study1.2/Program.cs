using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calculate the intrest of a loan to produce the output 
            Console.WriteLine("Enter the loan amount: ");
            double loanAmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the interest rate: ");
            double interestRate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the number of years: ");
            double numberOfYears = Convert.ToDouble(Console.ReadLine());

            int intrest = (int)(loanAmount * interestRate * numberOfYears);
            Console.WriteLine("The interest on the loan is: " + intrest);
        }
    }
}
