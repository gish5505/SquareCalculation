using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareCalculation
{
    public class Triangle : Shape
    {
        public Triangle(double sideA, double sideB, double sideC)
        {
            var sortedSides = new List<double> { sideA, sideB, sideC };
            sortedSides.Sort();

            SideA = sortedSides[0];
            SideB = sortedSides[1];
            SideC = sortedSides[2];

            ValidateTriangle();
        }

        public double SideA { get; private set; }
        public double SideB { get; private set; }
        public double SideC { get; private set; }

        public override double GetSquare()
        {
            double halfP = 0.5 * (SideA + SideB + SideC);
            return Math.Sqrt(halfP * (halfP - SideA) * (halfP - SideB) * (halfP - SideC));
        }

        public bool IsThisRightTriangle()
        {
            return (Math.Pow(SideA, 2) + Math.Pow(SideB, 2) == Math.Pow(SideC, 2));
        }

        private void ValidateTriangle() 
        {
            if (!(SideA > 0 && SideB > 0 && SideC > 0)) 
            {
                throw new NonExistentTriangleException();
            }

            if (!(SideA + SideB > SideC))
            {
                throw new NonExistentTriangleException();
            }
        }
    }
}
