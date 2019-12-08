using TestNinja.Fundamentals;
using NUnit.Framework;


namespace TestNinja.UnitTests
{
    public class FizzBuzzTests
    {
        [Test]

        public void GetOutput_WhenCalledWithNumberDivisibleByFiveAndThree_ReturnFizzBuzz()
        {
            var result = FizzBuzz.GetOutput(15);

            Assert.That(result, Is.EqualTo("FizzBuzz"));

        }
    }
}
