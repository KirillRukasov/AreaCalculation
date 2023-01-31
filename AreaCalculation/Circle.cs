using AreaCalculator.Interfaces;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("AreaCalculation.Tests")]
namespace AreaCalculation
{
    internal class Circle : IFigure
    {
        private double _radius;

        public Circle(CircleParameters parameters)
        {
            _radius = parameters.Radius;
        }
        public double GetArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}
