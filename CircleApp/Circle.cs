using System;
using System.Collections.Generic;
using System.Text;

namespace CircleApp
{
    class Circle
    {
        public double Radius { get; set; }
        public double Circumference { get; set; }
        public double Area { get; set; }
        
        public Circle(double radius)
        {
            this.Radius = Radius;
            this.Circumference = Circumference;
            this.Area = Area;
        }

        public double CalculateCircumference(double radius)
        {
            double pi = Math.PI;
            double circumference = 2 * pi * radius;
            Console.WriteLine($"The circumference is: {Math.Round(circumference, 2)}.");
            return circumference;
        }
        public double CalculateArea(double radius)
        {
            double pi = Math.PI;
            double area = pi * Math.Pow(radius, 2.00);
            Console.WriteLine($"The area is: {Math.Round(area, 2)}.");
            return area;
        }
    }
}
