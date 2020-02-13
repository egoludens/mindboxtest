using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculatorLib.Shapes
{
    public class Triangle : IShape
    {
        readonly double sideA;
        readonly double sideB;
        readonly double sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        public double Area()
        {
            // Check for right triangle
            double sqrSideA = Math.Pow(sideA, 2);
            double sqrSideB = Math.Pow(sideB, 2);
            double sqrSideC = Math.Pow(sideC, 2);

            if (sqrSideA == sqrSideB + sqrSideC) { return sideB * sideC / 2; }
            else if (sqrSideB == sqrSideA + sqrSideC) { return sideA * sideC / 2; }
            else if (sqrSideC == sqrSideA + sqrSideB) { return sideA * sideB / 2; }
            else
            {
                double halfPerimeter = (sideA + sideB + sideC) / 2;
                return Math.Sqrt(halfPerimeter * (halfPerimeter - sideA) * (halfPerimeter - sideB) * (halfPerimeter - sideC));
            }
        }

        public static double CalculateArea(double sideA, double sideB, double sideC)
        {
            return (new Triangle(sideA, sideB, sideC)).Area();
        }

    }
}
