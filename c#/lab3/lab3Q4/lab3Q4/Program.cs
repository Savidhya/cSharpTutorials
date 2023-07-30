using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter a positive integer: ");
            string userInput = Console.ReadLine();

          
            if (int.TryParse(userInput, out int x))
            {
                if (x > 0)
                {
                    int sumOfOddNumbers = 0;

                    
                    for (int i = 1; i <= x; i += 2)
                    {
                        sumOfOddNumbers += i;
                    }

                   
                    Console.WriteLine($"Sum of odd numbers from 1 to {x}: {sumOfOddNumbers}");
                }
                else
                {
                    Console.WriteLine(" enter a positive integer greater than zero.");
                }
            }
            else
            {
                Console.WriteLine("enter a valid positive integer.");
            }

            
            Console.ReadKey();
        }
    }
}
  
