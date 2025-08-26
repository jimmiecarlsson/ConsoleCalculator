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
        public void Dividera_TaljarenNoll_ReturnerarNoll()
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

        [Fact]
        public void Dividera_NegativTaljare_ReturneraKvot()
        {
            //Arrange
            Dividera dividera = new Dividera();

            double a = -7;
            double b = 3;

            //Act
            double result = dividera.Divi(a, b);

            //Assert
            Assert.Equal(-2.33, result, precision: 2);

        }

        [Fact]
        public void Dividera_NamnareNoll_ReturneraUndantag()
        {
            //Arrange

            Dividera dividera = new Dividera();

            double a = 5;
            double b = 0;

            //Act
            //double result = dividera.Divi(a, b);
            //behöver en delegate som körs senare

            Action act = () => dividera.Divi(a,b);
        

            //Assert
            //Kastas rätt undantag? Kastas rätt type
            DivideByZeroException ex = Assert.Throws<DivideByZeroException>(act);

            //Är meddelandet exakt?
            Assert.Equal("Division med noll är inte tillåten.", ex.Message);
        }

    }
}
