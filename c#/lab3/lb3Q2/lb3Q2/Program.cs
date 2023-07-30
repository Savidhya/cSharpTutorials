using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb3Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("enter a string: ");
            string inputString = Console.ReadLine();

         
            string lowerCaseInput = inputString.ToLower();

            int vowelCount = 0;
            foreach (char c in lowerCaseInput)
            {
                if (IsVowel(c))
                {
                    vowelCount++;
                }
            }

            
            Console.WriteLine($"Number of vowels in the given string: {vowelCount}");

            
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

       
        static bool IsVowel(char c)
        {
            return "aeiou".Contains(c);
        }
    }
}
        
    

