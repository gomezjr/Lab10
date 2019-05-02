using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Circle
    {
        double pi = Math.PI;
        private double radius;


        public Circle(double r)
        {
            radius = r;


        }

        public double GetCircumference()
        {
            double circumference = 2 * pi * radius;
            return circumference;
        }

        public double GetArea()
        {
            double area = pi * (Math.Pow(radius, 2));
            return area;
        }

        public void PrintInfo()
        {
            Console.WriteLine("The Radius of the circle is {0}.", radius);
            Console.WriteLine("The Area of the circle is {0}.", GetArea());
            Console.WriteLine("The Circumeference of the circle is {0}.", GetCircumference());
            Console.WriteLine();
        }
    }
}
