using Xunit;
using ConsoleCalulator.Actions;

namespace xUnitTest
{
    public class AdderaTests
    {

        [Fact]
        public void Add_TvaPositiveNummer_ReturneraRoundedSum()
        {
            // Arrange
            var addera = new Addera();
            double a = 2.345, b = 3.335;

            // Act
            double result = addera.Add(a, b);

            // Assert
            Assert.Equal(5.68, result, precision: 2);
        }

    }
}
