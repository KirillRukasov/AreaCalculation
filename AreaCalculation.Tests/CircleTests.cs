using Xunit;

namespace AreaCalculation.Tests
{
    public class CircleTests
    {
        [Fact]
        public void GetArea_ValidRadius_ReturnsExpectedArea()
        {
            // Arrange
            double radius = 2;
            var circle = new Circle(radius);

            // Act
            var area = circle.GetArea();

            // Assert
            var expectedArea = Math.PI * Math.Pow(radius, 2);
            Assert.Equal(expectedArea, area, 2);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void Constructor_InvalidRadius_ThrowsArgumentException(double radius)
        {
            // Assert
            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }
    }
}