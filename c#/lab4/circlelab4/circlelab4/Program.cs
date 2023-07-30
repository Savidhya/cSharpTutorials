using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circlelab4
{
    class FindValues
    {
        public double FindArea(double radius)
        {
            return 22/7 * radius * radius;
        }

        public double FindCircumference(double radius)
        {
            return 2 * 22/7 * radius;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius of the circle:");
            double radius = Convert.ToDouble(Console.ReadLine());

            
            FindValues circleValues = new FindValues();

           
            double area = circleValues.FindArea(radius);
            Console.WriteLine($"Area of the circle: {area}");

           
            double circumference = circleValues.FindCircumference(radius);
            Console.WriteLine($"Circumference of the circle: {circumference}");

            Console.ReadLine();
        }
    }
}
      
