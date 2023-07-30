using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salary;
            double tax;
            double salaryAfterTax;
            Console.WriteLine("enetr salary:");
            salary=double.Parse(Console.ReadLine());
            Console.WriteLine("tax rate:");
            tax=double.Parse(Console.ReadLine());
            salaryAfterTax = salary-(salary * tax / 100);
            Console.WriteLine("salary after the tax=" + salaryAfterTax);
            Console.ReadKey();



        }
    }
}
