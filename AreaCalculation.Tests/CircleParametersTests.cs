using Xunit;

namespace AreaCalculation.Tests
{
    public class CircleParametersTests
    {
        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(100)]
        public void Constructor_ValidRadius_RadiusSet(double radius)
        {
            // Act
            var parameters = new CircleParameters(radius);

            // Assert
            Assert.Equal(radius, parameters.Radius);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void Constructor_InvalidRadius_ThrowsException(double radius)
        {
            // Act & Assert
            Assert.Throws<ArgumentException>(() => new CircleParameters(radius));
        }
    }
}
