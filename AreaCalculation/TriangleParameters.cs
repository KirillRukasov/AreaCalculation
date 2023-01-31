using AreaCalculator.Interfaces;

namespace AreaCalculation
{
    public class TriangleParameters : IParameters
    {
        private double _sideA;
        private double _sideB;
        private double _sideC;
        public TriangleParameters(double sideA, double sideB, double sideC)
        {
            if (!IsPositiveSides(sideA, sideB, sideC))
            {
                throw new ArgumentException("Sides must be positive");
            }
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }
        public double SideA => _sideA;
        public double SideB => _sideB;
        public double SideC => _sideC;
        private bool IsPositiveSides(double sideA, double sideB, double sideC)
        {
            return sideA > 0 && sideB > 0 && sideC > 0;
        }
    }
}
