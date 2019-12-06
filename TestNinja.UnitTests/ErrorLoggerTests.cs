﻿using TestNinja.Fundamentals;
using NUnit.Framework;
namespace TestNinja.UnitTests
{
    public class ErrorLoggerTests
    {

        [Test]

        public void Log_WhenCalled_SetTheLastErrorProperty() {
            var logger = new ErrorLogger();
            logger.Log("a");

            Assert.That(logger.LastError, Is.EqualTo('a'));
        }
       
    }
}
