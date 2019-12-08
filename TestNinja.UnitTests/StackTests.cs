using TestNinja.Fundamentals;
using NUnit.Framework;
namespace TestNinja.UnitTests
{
    [TestFixture]
    public class StackTests
    {

        [Test]
        public void Push_ArgsIsNull_ThrowArgumentNullException()
        {

            var stack = new Stack<string>();
            Assert.That(() => stack.Push(null), Throws.ArgumentNullException);

        }



        [Test]
        public void Push_ValidArgument_AddTheObjectToTheStack()
        {

            var stack = new Stack<string>();
            stack.Push("a");
            Assert.That(stack.Count, Is.EqualTo(1));

        }

        [Test]
        public void Count_EmptyStack_ReturnZero()
        {

            var stack = new Stack<string>();
            Assert.That(stack.Count, Is.EqualTo(0));

        }
    }
}
