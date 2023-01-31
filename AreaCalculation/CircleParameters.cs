using AreaCalculator.Interfaces;

namespace AreaCalculation
{
    public class CircleParameters : IParameters
    {
        private double _radius;

        public CircleParameters(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Radius must be positive");
            }
            _radius = radius;
        }
        public double Radius => _radius;
    }
}
