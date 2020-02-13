using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculatorLib.Shapes
{
    public class Circle : IShape
    {
        readonly double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double Area()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public static double CalculateArea(double radius)
        {
            return (new Circle(radius)).Area();
        }
    }
}
