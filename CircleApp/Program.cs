using System;
using System.Collections.Generic;

namespace CircleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            List<double> storage = new List<double>();
            bool goOn = true;

            Console.WriteLine("Circle Calculator 2: Electric Boogaloo!");

            while (goOn)
            {
                Console.WriteLine("Please enter the radius of the circle:");
                double radius = Calculator.NumCheck(Console.ReadLine());
                Circle c = new Circle(radius);
                double circumference = Math.Round(c.CalculateCircumference(radius), 2);
                double area = Math.Round(c.CalculateArea(radius), 2);
                storage.Add(radius);
                storage.Add(circumference);
                storage.Add(area);
                goOn = Calculator.Continue("Would you like to continue? y/n\n");
            }
            
            foreach(double item in storage)
            {
                Console.WriteLine(item);
            }
        }


    }
}
