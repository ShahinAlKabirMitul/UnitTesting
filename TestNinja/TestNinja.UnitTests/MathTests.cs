using NUnit.Framework;
using Math = TestNinja.Fundamentals.Math;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        private Math _math;
        // Setup
        // TearDown

        [SetUp]
        public void Setup()
        {
            _math=new Math();
        }
        
        [Test]
        public void Add_WhenCalled_ReturnTheSUMofArgunents()
        {
            _math = new Math();
            var result = _math.Add(1, 2);
            Assert.That(result,Is.EqualTo(3));
        }
        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 1, 1)]
        public void Add_WhenCalled_ReturnTheGreaterArgument(int a, int b, int expectedReturn)
        {
            _math = new Math();
            var result = _math.Add(a, b);
            Assert.That(result, Is.EqualTo(expectedReturn));
        }

    }
}
