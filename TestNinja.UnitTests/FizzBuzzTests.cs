using TestNinja.Fundamentals;
using NUnit.Framework;


namespace TestNinja.UnitTests
{
    public class FizzBuzzTests
    {
        [Test]

        public void GetOutput_InputIsDivisibleBy5And3_ReturnFizzBuzz()
        {
            var result = FizzBuzz.GetOutput(15);

            Assert.That(result, Is.EqualTo("FizzBuzz"));

        }


        [Test]
        public void GetOutput_InputIsDivisibleBy3_ReturnFizz()
        {
            var result = FizzBuzz.GetOutput(3);

            Assert.That(result, Is.EqualTo("Fizz"));

        }



        [Test]
        public void GetOutput_InputIsDivisibleBy5_ReturnBuzz()
        {
            var result = FizzBuzz.GetOutput(5);

            Assert.That(result, Is.EqualTo("Buzz"));

        }



        [Test]
        public void GetOutput_InputIsNotDivisibleBy3Or5_ReturnSameInputNumber()
        {
            var result = FizzBuzz.GetOutput(1);

            Assert.That(result, Is.EqualTo("1"));

        }


    }


}


