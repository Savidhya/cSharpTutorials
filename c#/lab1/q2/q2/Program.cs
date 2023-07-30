using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radius;
            double area;
            Console.WriteLine("enetr radius:");
            radius = double.Parse(Console.ReadLine());
            area = radius * radius *22/7;
            Console.WriteLine("the circles area:" + area);
            Console.ReadLine();
        }
    }
}
