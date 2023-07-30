using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb3Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("enetr number:");
            number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
                Console.WriteLine("odd");
            Console.ReadLine();
        }

      

    }
}
