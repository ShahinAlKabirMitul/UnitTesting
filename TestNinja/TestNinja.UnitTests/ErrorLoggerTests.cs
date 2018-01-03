using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ErrorLoggerTests
    {
        private ErrorLogger logger;
        [SetUp]
        public void Setup()
        {
            logger = new ErrorLogger();
        }

        [Test]
        public void Log_WhenCalled_SetTheLatestErrorProperty()
        {
            logger.Log("a");
            Assert.That(logger.LastError,Is.EqualTo("a"));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void Log_InvalidError_ThrowArgumentNullException(string error)
        {
            Assert.That( ()=>logger.Log(error),Throws.ArgumentNullException );

           // Assert.That(() => logger.Log(error), Throws.Exception.TypeOf<DivideByZeroException>());
        }

        [Test]
        public void Log_ValidError_RaiseErrorLoggedEvent()
        {
            var id = Guid.Empty;
            logger.ErrorLogged += (sender, args) => { id = args; };
            logger.Log("a");
            Assert.That(id,Is.Not.EqualTo(Guid.Empty));
        }

       
    }
}
