using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareCalculation
{
    public class RandomPolygon : Shape
    {
        // Предполагаю то, что многоугольник является простым и использую формулу площади Гаусса

        private List<(double X, double Y)> _currentPolygon;

        public RandomPolygon(List<(double X, double Y)> coordinates)
        {   
            _currentPolygon = coordinates;          
        }
        
        public override double GetSquare()
        {
            int numberOfAngles = _currentPolygon.Count;

            double square = 0;

            for (int i = 0; i < numberOfAngles-1; i++)
            {
                square = 0.5 * Math.Abs(_currentPolygon[i].X * _currentPolygon[i + 1].Y - _currentPolygon[i + 1].X * _currentPolygon[i].Y);
            }

            return square;
        }
    }
}
