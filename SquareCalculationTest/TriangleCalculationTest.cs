using Microsoft.VisualStudio.TestTools.UnitTesting;
using SquareCalculation;
using System;

namespace SquareCalculationTest
{
    [TestClass]
    public class TriangleCalculationTest
    {
        [TestMethod]
        public void TriangleTest()
        {            
            double sideA = 5;
            double sideB = 3;
            double sideC = 4;            

            var test = new Triangle(sideA, sideB, sideC);
            
            Assert.AreEqual(6, test.GetSquare());
        }

        [TestMethod]
        public void IsTriangleRightTest()
        {
            double sideA = 5;
            double sideB = 3;
            double sideC = 4;

            var test = new Triangle(sideA, sideB, sideC);

            test.IsThisRightTriangle();

            Assert.IsTrue(test.IsThisRightTriangle());            
        }

        [TestMethod]
        public void InvalidSidesTriangleTest()
        {
            double sideA = 6;
            double sideB = 1;
            double sideC = 4;

            Triangle test;

            Assert.ThrowsException<NonExistentTriangleException>(() => test = new Triangle(sideA, sideB, sideC));
        }

    }
}
