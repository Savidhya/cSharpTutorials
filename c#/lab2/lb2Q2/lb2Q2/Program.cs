using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb2Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;
            double sum, substraction, division, multiplication;
            Console.WriteLine("enetr your num1:");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("enetr your num2");
            num2 = double.Parse(Console.ReadLine());
            sum = num1 + num2;
            substraction = num1 - num2;
            division = num1 / num2;
            multiplication = num1 * num2;
            Console.WriteLine("sum=" + sum);
            Console.WriteLine("substraction=" + substraction);
            Console.WriteLine("division=" + division);
            Console.WriteLine("multiplication=" + multiplication);
            Console.ReadKey();
        }
    }
}
