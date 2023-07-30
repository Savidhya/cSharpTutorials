using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb2q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radius = 7;
            double area;
            double circumference;
            Console.WriteLine("circle radius="+ radius);
            area = 49 * 22 / 7;
            circumference = 2 * 22 / 7 * 7;
            Console.WriteLine("area=" + area);
            Console.WriteLine("circumference=" + circumference);
            Console.ReadKey();
        }
    }
}
