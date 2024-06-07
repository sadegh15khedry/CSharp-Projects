namespace NUnitProject;
public class SumTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Sum_Test()
    {
        //assign
        int z1 = 10;

        //Act
        int z2 = NUnitDemoConsoleApp.SimpleFunctions.Sum(5, 5);

        //Assert
        Assert.AreEqual(z1, z2);
    }

    [TestCase(5, 5, 10)]
    [TestCase(3, 2, 1)]
    [TestCase(5, 10, 15)]

    public void Sum_TestCase(int x, int y, int z)
    {
        //assign


        //Act
        int z2 = NUnitDemoConsoleApp.SimpleFunctions.Sum(x, y);

        //Assert
        Assert.AreEqual(z, z2);
    }
}