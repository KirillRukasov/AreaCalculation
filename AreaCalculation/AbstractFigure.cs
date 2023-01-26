
namespace AreaCalculation
{
    public abstract class AbstractFigure
    {
        public abstract double GetArea();

        public static double CalculateArea(AbstractFigure figure)
        {
            return figure.GetArea();
        }
    }
}
