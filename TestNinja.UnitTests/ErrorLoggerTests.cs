﻿using TestNinja.Fundamentals;
using NUnit.Framework;
using System;

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


        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase("  ")]
        public void Log_InvalidError_ThrowArgumentNullException(string err)
        {
            var logger = new ErrorLogger();
            Assert.That(() => logger.Log(err), Throws.ArgumentNullException);
           
        }


        [Test]

        public void Log_ValidError_RaiseErrorLoggedEvent()
        {
            var logger = new ErrorLogger();
            var id = Guid.Empty;
            logger.ErrorLogged += (sender, args) => { id = args; };

            logger.Log("a");

            Assert.That(id, Is.Not.EqualTo(Guid.Empty));
        }


    }
}
