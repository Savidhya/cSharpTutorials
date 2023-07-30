using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb2Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;
            double sum;
            Console.WriteLine("enter num1:");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("enter num2:");
            num2 = double.Parse(Console.ReadLine());
            sum = num1 + num2;
            Console.WriteLine("sum=" + sum);
            Console.ReadKey();
        }
    }
}
