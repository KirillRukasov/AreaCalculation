using Xunit;

namespace AreaCalculation.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void GetArea_ValidSides_ReturnsExpectedArea()
        {
            // Arrange
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            var triangle = new Triangle(sideA, sideB, sideC);

            // Act
            var area = triangle.GetArea();

            // Assert
            var p = (sideA + sideB + sideC) / 2;
            var expectedArea = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
            Assert.Equal(expectedArea, area, 2);
        }

        [Theory]
        [InlineData(0, 2, 3)]
        [InlineData(2, -1, 3)]
        [InlineData(2, 3, 0)]
        public void Constructor_InvalidSides_ThrowsArgumentException(double sideA, double sideB, double sideC)
        {
            // Assert
            Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(3, 4, 7)]
        public void GetArea_NotATriangle_ThrowsArgumentException(double sideA, double sideB, double sideC)
        {
            // Arrange
            var triangle = new Triangle(sideA, sideB, sideC);

            // Assert
            Assert.Throws<ArgumentException>(() => triangle.GetArea());
        }

        [Theory]
        [InlineData(3, 4, 5, true)]
        [InlineData(5, 12, 13, true)]
        [InlineData(8, 15, 17, true)]
        [InlineData(2, 3, 4, false)]
        public void IsRightTriangle_ReturnsExpectedResult(double sideA, double sideB, double sideC, bool expectedResult)
        {
            // Arrange
            var triangle = new Triangle(sideA, sideB, sideC);

            // Act
            var result = triangle.IsRightTriangle();

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
