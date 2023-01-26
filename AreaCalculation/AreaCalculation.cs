namespace AreaCalculation
{
    public class AreaCalculation
    {
        //The next step is to use the pattern factory method.
        //At the moment I don't see the point of making the structure more complex with additional interfaces
        public static void CalculateArea(FigureType figureType, double sideA, double sideB = 0, double sideC = 0)
        {
            AbstractFigure figure;
            switch (figureType)
            {
                case FigureType.Circle:
                    figure = new Circle(sideA);
                    break;
                case FigureType.Triangle:
                    figure = new Triangle(sideA, sideB, sideC);
                    Console.WriteLine("This is a right triangle: {0}", ((Triangle)figure).IsRightTriangle());
                    break;
                default:
                    throw new ArgumentException("Unknown figure type");
            }
            Console.WriteLine("Area: {0}", AbstractFigure.CalculateArea(figure));
        }
    }
}
