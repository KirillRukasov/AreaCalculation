namespace AreaCalculation
{
    public class Circle : AbstractFigure
    {
        private double _radius;

        public Circle(double radius)
        {
            if (!IsPositiveRadius(radius))
            {
                throw new ArgumentException("Radius must be positive");
            }
            _radius = radius;
        }

        private bool IsPositiveRadius(double radius)
        {
            return radius > 0;
        }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}
