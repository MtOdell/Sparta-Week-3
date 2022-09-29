using FizzBuzzApp;
namespace FizzBuzzTest;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void GivenNegativeReturnsNone()
    {
        Assert.That(Program.FizzBuzz(-1), Is.EqualTo(""));
        Assert.That(Program.FizzBuzz(-3), Is.EqualTo(""));
        Assert.That(Program.FizzBuzz(-5), Is.EqualTo(""));
        Assert.That(Program.FizzBuzz(-15), Is.EqualTo(""));
    }

    [Test]
    public void GivenZeroReturnsNone()
    {
        Assert.That(Program.FizzBuzz(0), Is.EqualTo(""));
    }

    [Test]
    public void GivenOneReturnsOne()
    {
        Assert.That(Program.FizzBuzz(1), Is.EqualTo("1"));
    }

    [Test]
    public void GivenTwoReturnsTwo()
    {
        Assert.That(Program.FizzBuzz(2), Is.EqualTo("1 2"));
    }

    [Test]
    public void GivenThreeReturnsThree()
    {
        Assert.That(Program.FizzBuzz(3), Is.EqualTo("1 2 Fizz"));
    }

    [Test]
    public void FizzBuzzFifteen()
    {
        Assert.That(Program.FizzBuzz(15), Is.EqualTo("1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz"));
    }

    [Test]
    public void FizzBuzz100()
    {
        Assert.That(Program.FizzBuzz(100), Is.EqualTo("1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz 16 17 Fizz 19 Buzz Fizz 22 23 Fizz Buzz 26 Fizz 28 29 FizzBuzz 31 32 Fizz 34 Buzz Fizz 37 38 Fizz Buzz 41 Fizz 43 44 FizzBuzz 46 47 Fizz 49 Buzz Fizz 52 53 Fizz Buzz 56 Fizz 58 59 FizzBuzz 61 62 Fizz 64 Buzz Fizz 67 68 Fizz Buzz 71 Fizz 73 74 FizzBuzz 76 77 Fizz 79 Buzz Fizz 82 83 Fizz Buzz 86 Fizz 88 89 FizzBuzz 91 92 Fizz 94 Buzz Fizz 97 98 Fizz Buzz"));
    }

    [Test]
    public void FizzBuzzThirty()
    {
        string x = "Fizz";
        string y = "Buzz";
        string z = "FizzBuzz";
        Assert.That(Program.FizzBuzz(30), Is.EqualTo($"1 2 {x} 4 {y} {x} 7 8 {x} {y} 11 {x} 13 14 {z} 16 17 {x} 19 {y} {x} 22 23 {x} {y} 26 {x} 28 29 {z}"));
    }
}