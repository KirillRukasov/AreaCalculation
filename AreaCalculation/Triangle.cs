namespace AreaCalculation
{
    public class Triangle : AbstractFigure
    {
        private double _sideA;
        private double _sideB;
        private double _sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (!IsPositiveSides(sideA, sideB, sideC))
            {
                throw new ArgumentException("Sides must be positive");
            }
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        public override double GetArea()
        {
            if (!IsTriangle())
            {
                throw new ArgumentException("This is not a triangle");
            }
            double p = (_sideA + _sideB + _sideC) / 2;
            return Math.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC));
        }

        //Check for rightness of a triangle
        public bool IsRightTriangle()
        {
            return Math.Pow(_sideA, 2) + Math.Pow(_sideB, 2) == Math.Pow(_sideC, 2) ||
                   Math.Pow(_sideA, 2) + Math.Pow(_sideC, 2) == Math.Pow(_sideB, 2) ||
                   Math.Pow(_sideB, 2) + Math.Pow(_sideC, 2) == Math.Pow(_sideA, 2);
        }

        //Determining the existence of a triangle
        private bool IsTriangle()
        {
            return _sideA + _sideB > _sideC && _sideA + _sideC > _sideB && _sideB + _sideC > _sideA;
        }

        //Check for positive sides of a triangle
        private bool IsPositiveSides(double sideA, double sideB, double sideC)
        {
            return sideA > 0 && sideB > 0 && sideC > 0;
        }
    }
}
