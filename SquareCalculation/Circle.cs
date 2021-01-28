using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareCalculation
{
    public class Circle : Shape
    {
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius { get; private set; }

        public override double GetSquare()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
