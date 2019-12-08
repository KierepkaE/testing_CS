using NUnit.Framework;
using System;
using TestNinja.Fundamentals;
namespace TestNinja.UnitTests
{
    public class DemeritPointsCalculatorTests
    {
        [Test]
        [TestCase(-1)]
        [TestCase(301)]
        public void CalculateDemeritPoints_SpeedIsOutOfRange_ReturnArgumentOutOfRangeException(int speed) {

            var calculator = new DemeritPointsCalculator();

            Assert.That(() => calculator.CalculateDemeritPoints(speed), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }

      

        [Test]
        [TestCase(0,0)]
        [TestCase(60, 0)]
        [TestCase(61, 0)]
        [TestCase(62, 0)]
        [TestCase(70, 1)]
        [TestCase(80, 3)]
        public void CalculateDemeritPoints_WhenCalled_ReturnDemetirPoints(int speed, int result)
        {

            var calculator = new DemeritPointsCalculator();
            var points = calculator.CalculateDemeritPoints(speed);

            Assert.That(points, Is.EqualTo(result));
        }
    }
}
  