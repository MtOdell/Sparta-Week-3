using NUnit.Framework.Internal;
using SafariParkApp;
namespace SafariTests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase("Nish", "Mandel", 99)]
    public void PersonConstructsCorrectly(string fName, string lName, int age)
    {
        var sut = new Person(fName, lName) { Age = 99 };
        Assert.That(sut._firstName, Is.EqualTo("Nish"));
    }

    [TestCase(1, 2, 3, 2, 4, 6)]
    public void Point3DTest(int x, int y, int z, int expX, int expY, int expZ)
    {
        var sut = new Point3D(x, y, z);
        sut.Translate();
        Assert.That(sut.x, Is.EqualTo(expX));
        Assert.That(sut.y, Is.EqualTo(expY));
        Assert.That(sut.z, Is.EqualTo(expZ));
    }

    [Test]
    public void IsPoint3DTypePoint3D()
    {
        var sut = new Point3D(1, 4, 7);
        Assert.That(sut, Is.InstanceOf<Point3D>());
    }
}