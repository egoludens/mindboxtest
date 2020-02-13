using System;
using Xunit;

namespace XUnitTest
{
    public class AreaTests
    {
        [Fact]
        public void CircleTest()
        {
            double expected = 314.159;
            double actual = Math.Round(AreaCalculatorLib.Shapes.Circle.CalculateArea(10), 3);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void RightTriangleTest()
        {
            double expected = 6;
            double actual = AreaCalculatorLib.Shapes.Triangle.CalculateArea(3, 4, 5);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TriangleTest()
        {
            double expected = 12;
            double actual = AreaCalculatorLib.Shapes.Triangle.CalculateArea(5, 5, 6);
            Assert.Equal(expected, actual);
        }
    }
}
