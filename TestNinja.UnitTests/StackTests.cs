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
    }
}
