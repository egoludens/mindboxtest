using System;

namespace ManualTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Manual test for AreaCalculatorLib");
            ManualTestCircle();
            ManualTestTriangle();

            Console.WriteLine("Press Enter to close this window.");
            Console.ReadLine();
        }

        static void ManualTestCircle()
        {
            Console.Write("Enter the circle radius: ");
            double circleRadius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(String.Format("Cirle area, radius {0}: {1}",
                circleRadius.ToString(),
                AreaCalculatorLib.Shapes.Circle.CalculateArea(circleRadius)));
        }

        static void ManualTestTriangle()
        {
            Console.Write("Enter the length of triangle side A: ");
            double sideA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the length of triangle side B: ");
            double sideB = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the length of triangle side C: ");
            double sideC = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(String.Format("Triangle area (sides: {0}; {1}; {2}): {3}",
                sideA.ToString(),
                sideB.ToString(),
                sideC.ToString(),
                AreaCalculatorLib.Shapes.Triangle.CalculateArea(sideA, sideB, sideC)));
        }

    }
}
