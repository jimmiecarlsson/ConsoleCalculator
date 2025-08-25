using Xunit;
using ConsoleCalulator.Actions;

namespace xUnitTest
{
    public class DivideraTests
    {

        [Fact]
        public void Dividera_TvaPositivaTal_ReturnerarKvot()
        {
            // Arrange
            Dividera dividera = new Dividera();

            double a = 10;
            double b = 4;

            // Act
            double result = dividera.Divi(a, b);

            // Assert
            Assert.Equal(2.50, result, precision: 2);
        }

        [Fact]
        public void Dividera_TäljarenNoll_ReturnerarNoll()
        {
            // Arrange
            Dividera dividera = new Dividera();

            double a = 0;
            double b = 5;

            // Act

            double result = dividera.Divi(a,b);

            // Assert
            Assert.Equal(0.00, result, precision: 2);

        }



    }
}
