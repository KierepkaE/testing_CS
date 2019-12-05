﻿using NUnit.Framework;
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


        }
    }
}
