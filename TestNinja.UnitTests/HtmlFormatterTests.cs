using NUnit.Framework;
using TestNinja.Fundamentals;


namespace TestNinja.UnitTests
{
    [TestFixture]
    public class HtmlFormatterTests
    {
        public void FormatAsBold_WhenCalled_ShouldEncloseTheStringWithStrongElement() {
            var formatter = new HtmlFormatter();

            var result = formatter.FormatAsBold("abc");


            // Specific assertion

            Assert.That(result, Is.EqualTo("<strong>abc</strong>"));

            // More general assertion

            Assert.That(result, Does.StartWith("<strong>"));
            Assert.That(result, Does.Contain("abc"));
            Assert.That(result, Does.EndWith("</strong>"));
        }
    }
}
