using Microsoft.VisualStudio.TestTools.UnitTesting;
using SquareCalculation;
using System;
using System.Collections.Generic;

namespace SquareCalculationTest
{
    [TestClass]
    public class RandomPolygonTest
    {
        [TestMethod]
        public void RandomPolygonCalculationTest()
        {
            var importedCoordinatesList = new List<(double X, double Y)>
            {
                (0,0),
                (0,4),
                (3,0)
            };

            var test = new RandomPolygon(importedCoordinatesList);

            Assert.AreEqual(6, test.GetSquare());
        }
    }
}
