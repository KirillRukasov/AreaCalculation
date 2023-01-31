using Xunit;

namespace AreaCalculation.Tests
{
    public class TriangleParametersTests
    {
        [Theory]
        [InlineData(5, 10, 15)]
        [InlineData(10, 10, 10)]
        [InlineData(100, 200, 300)]
        public void Constructor_ValidSides_SidesSet(double sideA, double sideB, double sideC)
        {
            // Act
            var parameters = new TriangleParameters(sideA, sideB, sideC);

            // Assert
            Assert.Equal(sideA, parameters.SideA);
            Assert.Equal(sideB, parameters.SideB);
            Assert.Equal(sideC, parameters.SideC);
        }

        [Theory]
        [InlineData(0, 10, 15)]
        [InlineData(10, 0, 15)]
        [InlineData(10, 10, 0)]
        [InlineData(-1, 10, 15)]
        public void Constructor_InvalidSides_ThrowsException(double sideA, double sideB, double sideC)
        {
            // Act & Assert
            Assert.Throws<ArgumentException>(() => new TriangleParameters(sideA, sideB, sideC));
        }
    }
}
