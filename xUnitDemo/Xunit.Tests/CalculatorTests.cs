using AutoFixture;
using ConsoleApp;
using FluentAssertions;
namespace Xunit.Tests;

public class CalculatorTests
{
    [Theory]
    //[AutoData]
    [InlineData(1, 2, 3)]
    public void Add_Test(int x, int y, double expected)
    {
        //Arrange
        //var fixture = fixture.Freeze("Name");
        Fixture fixture = new Fixture();

        int expectedNumber = fixture.Create<int>();
        //Act
        double actual = CalulatorLoginc.Sum(x, y);

        //Assert
        Assert.Equal(expected, actual);

    }



    [Theory]
    [InlineData("akvar", "akvari")]
    [InlineData("akvar ", "eli")]
    [InlineData("", "")]

    public void Concat_Test(string a, string b)
    {
        //Arrange 

        //Act 
        var actualResualt = CalulatorLoginc.Concat(a, b);
        var expectedResualt = a + b;

        //Assert
        actualResualt.Should().Contain(a);
        actualResualt.Should().Contain(b);
        actualResualt.Should().Be(expectedResualt);
        actualResualt.Should().NotBeEmpty();



    }
}
