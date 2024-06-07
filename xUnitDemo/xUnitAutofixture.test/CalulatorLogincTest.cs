using AutoFixture.Xunit2;
using ConsoleApp;

namespace xUnitAutofixture.test
{
    public class CalulatorLogincTest
    {
        [Theory, AutoData]
        public void Sum(int x, int y)
        {

            //Arrange 


            //Act
            int actual = CalulatorLoginc.Sum(x, y);
            int expected = x + y;

            //Assert
            Assert.Equal(expected, actual);

        }
    }
}