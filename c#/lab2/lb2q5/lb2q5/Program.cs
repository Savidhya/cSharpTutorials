using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb2q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num;
            Console.WriteLine("enter num:");
            num = double.Parse(Console.ReadLine());
            for (int x = 1; x <= 2; x++)
            {
                

                if (num%2 == 0 ) 
                 
                Console.WriteLine("the nmber is an even number: ");

                
                else
                
                    Console.WriteLine("the number is an odd number:");
                
                Console.WriteLine("enter num:");
                num = double.Parse(Console.ReadLine());
               
                
            }

            Console.ReadKey();
        }
    }
}
