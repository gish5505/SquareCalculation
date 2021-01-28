using Microsoft.VisualStudio.TestTools.UnitTesting;
using SquareCalculation;
using System;

namespace SquareCalculationTest
{
    [TestClass]
    public class CircleCalculationTest
    {
        [TestMethod]
        public void CircleTest()
        {
            double radius = 5;

            var test = new Circle(radius);

            Assert.AreEqual(Math.PI * Math.Pow(radius, 2), test.GetSquare());
        }
    }
}
