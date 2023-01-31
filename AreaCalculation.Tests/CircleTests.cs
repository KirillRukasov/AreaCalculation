using Xunit;

namespace AreaCalculation.Tests
{
    public class CircleTests
    {
        [Theory]
        [InlineData(5, 78.539816)]
        [InlineData(10, 314.159265359)]
        [InlineData(100, 31415.926535897932)]
        public void GetArea_ValidRadius_ReturnsExpectedResult(double radius, double expectedArea)
        {
            // Arrange
            var parameters = new CircleParameters(radius);
            var circle = new Circle(parameters);

            // Act
            var actualArea = circle.GetArea();

            // Assert
            Assert.Equal(expectedArea, actualArea, 5);
        }
    }
}