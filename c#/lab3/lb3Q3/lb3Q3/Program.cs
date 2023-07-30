using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb3Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {

  
            Console.Write(" enter a number: ");
            string userInput = Console.ReadLine();

          
            if (long.TryParse(userInput, out long number))
            {
                long sumOfDigits = 0;

           
                while (number > 0)
                {
                    long digit = number % 10;
                    sumOfDigits += digit;
                    number /= 10;
                }

              
                Console.WriteLine($"Sum of the digits: {sumOfDigits}");
            }
            else
            {
                Console.WriteLine("Error: Invalid input");
            }

            Console.ReadKey();
        }
    }
}
        