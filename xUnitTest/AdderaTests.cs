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

        [Fact]
        public void Add_PositivtOchNegativtNummer_ReturneraRoundedSum()
        {
            // Arrange
            Addera adderaMera = new Addera();

            double a = -6.8;
            double b = 2.345678;

            // Act
            double result = adderaMera.Add(a, b);
            double result2 = adderaMera.Add(-3.5456, 0);

            // Assert

            Assert.Equal(-4.45, result, precision: 2);
            Assert.Equal(-3.55, result2, precision: 2);
        }

        [Fact]
        public void Add_TvaFlyttalForAvrundningstest_ReturneraRoundedSum()
        {
            // Arrange
            Addera addera = new Addera();

            double a = 0.1;
            double b = 0.2;

            // Act

            double result = addera.Add(a, b);
            double result2 = addera.Add(0.22, a);

            // Assert
            Assert.Equal(0.30, result, precision: 2);
            Assert.Equal(0.32, result2, precision: 2);
        }
    }
}
