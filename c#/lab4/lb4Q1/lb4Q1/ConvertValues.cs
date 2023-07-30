using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb4Q1
{
    internal class ConvertValues
    {
        public void KilometerToMeter()
      
        {
            Console.Write("Enter the distance in kilometers: ");
            double kilometers = Convert.ToDouble(Console.ReadLine());
            double meters = kilometers * 1000;

            Console.WriteLine("in meteres="+meters+"meters");
            Console.ReadKey();
        }
       
    }
}

