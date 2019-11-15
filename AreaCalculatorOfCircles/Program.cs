using System;

namespace AreaCalculatorOfCircles
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = 2.5;
            if (args.Length == 1)
            {
                radius = double.Parse(args[0]);
            }
            double radiusSquared = Math.Pow(radius, 2.0);
            double area = radiusSquared * Math.PI;
            Console.WriteLine($"I was given a circle with a radius of {radius} and the area equals {area} ");

        }
    }
}
