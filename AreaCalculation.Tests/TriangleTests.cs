using Xunit;

namespace AreaCalculation.Tests
{
    public class TriangleTests
    {
        [Theory]
        [InlineData(3, 4, 5, 6)]
        [InlineData(5, 12, 13, 30)]
        [InlineData(8, 15, 17, 60)]
        public void GetArea_ValidTriangleSides_ReturnsExpectedResult(double sideA, double sideB, double sideC, double expectedArea)
        {
            // Arrange
            var parameters = new TriangleParameters(sideA, sideB, sideC);
            var triangle = new Triangle(parameters);

            // Act
            var actualArea = triangle.GetArea();

            // Assert
            Assert.Equal(expectedArea, actualArea, 2);
        }

        [Theory]
        [InlineData(3, 4, 5, true)]
        [InlineData(6, 12, 13, false)]
        [InlineData(8, 15, 17, true)]
        public void IsRightTriangle_ValidTriangleSides_ReturnsExpectedResult(double sideA, double sideB, double sideC, bool expectedResult)
        {
            // Arrange
            var parameters = new TriangleParameters(sideA, sideB, sideC);
            var triangle = new Triangle(parameters);

            // Act
            var actualResult = triangle.IsRightTriangle();

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData(3, 4, 5, true)]
        [InlineData(5, 12, 13, true)]
        [InlineData(8, 15, 17, true)]
        [InlineData(2, 3, 4, false)]
        public void IsRightTriangle_ReturnsExpectedResult(double sideA, double sideB, double sideC, bool expectedResult)
        {
            // Arrange
            var parameters = new TriangleParameters(sideA, sideB, sideC);
            var triangle = new Triangle(parameters);

            // Act
            var result = triangle.IsRightTriangle();

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
