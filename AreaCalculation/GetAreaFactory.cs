using AreaCalculator.Interfaces;

namespace AreaCalculation
{
    public class GetAreaFactory : IGetAreaFactory
    {
        public double GetFigureArea(IParameters param)
        {
            switch (param)
            {
                case CircleParameters circleParameters:
                    return new Circle(circleParameters).GetArea();
                case TriangleParameters triangleParameters:
                    return new Triangle(triangleParameters).GetArea();
                default:
                    throw new ArgumentException("Unknown figure");
            }
        }
    }
}
