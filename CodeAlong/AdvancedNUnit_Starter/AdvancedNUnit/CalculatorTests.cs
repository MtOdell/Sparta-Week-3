using NUnit.Framework;
using System.Collections.Generic;

namespace AdvancedNUnit
{
    public class CalculatorTests
    {
        [SetUp]
        public void Setup() { }

        [Test]
        public void Add_Always_ReturnsExpectedResult()
        {
            // Arrange
            var expectedResult = 6;
            var subject = new Calculator { Num1 = 2, Num2 = 4 };
            // Act
            var result = subject.Add();
            // Assert
            Assert.That(result, Is.EqualTo(expectedResult), "optional failure message");
        }

        [Test]
        public void SameAsTest()
        {
            string val = "9";
            string val2 = val;
            Assert.That(val, Is.SameAs(val2));
        }

        [Test]
        public void NullTest()
        {
            string val = null;
            Assert.That(val, Is.Null);
        }

        [TearDown]
        public void TearDown()
        {
            //teardown allows us to reverse any permenant changes to databases after a test ends.
        }
    }
}