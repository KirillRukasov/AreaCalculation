using AreaCalculator.Interfaces;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("AreaCalculation.Tests")]
namespace AreaCalculation
{
    internal class Triangle : IFigure
    {
        private double _sideA;
        private double _sideB;
        private double _sideC;

        public Triangle(TriangleParameters parameters)
        {
            _sideA = parameters.SideA;
            _sideB = parameters.SideB;
            _sideC = parameters.SideC;
        }
        public double GetArea()
        {
            if (!IsTriangle())
            {
                throw new ArgumentException("This is not a triangle");
            }
            double p = (_sideA + _sideB + _sideC) / 2;
            return Math.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC));
        }

        public bool IsRightTriangle()
        {
            return Math.Pow(_sideA, 2) + Math.Pow(_sideB, 2) == Math.Pow(_sideC, 2) ||
                   Math.Pow(_sideA, 2) + Math.Pow(_sideC, 2) == Math.Pow(_sideB, 2) ||
                   Math.Pow(_sideB, 2) + Math.Pow(_sideC, 2) == Math.Pow(_sideA, 2);
        }

        private bool IsTriangle()
        {
            return _sideA + _sideB > _sideC && _sideA + _sideC > _sideB && _sideB + _sideC > _sideA;
        }
    }
}
