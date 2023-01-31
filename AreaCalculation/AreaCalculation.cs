using AreaCalculator.Interfaces;

namespace AreaCalculation
{
    public class AreaCalculation
    {
        private readonly IGetAreaFactory _factory;

        public AreaCalculation()
        {
            _factory = new GetAreaFactory();
        }

        public double GetArea(IParameters param)
        {
            return _factory.GetFigureArea(param);
        }
    }
}
