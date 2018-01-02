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
        //[Ignore("I wanted to")]
        public void Add_WhenCalled_ReturnTheSUMofArgunents()
        {
            var result = _math.Add(1, 2);
            Assert.That(result,Is.EqualTo(3));
        }
        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 1, 1)]
        public void Add_WhenCalled_ReturnTheGreaterArgument(int a, int b, int expectedReturn)
        {
            var result = _math.Add(a, b);
            Assert.That(result, Is.EqualTo(expectedReturn));
        }

        [Test]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumbersUpToLimit()
        {
            var result = _math.GetOddNumbers(5);
            // Assert.That(result, Is.Not.Empty);

            //Assert.That(result, Is.EqualTo(3));

            //Assert.That(result, Does.Contain(1));
            //Assert.That(result, Does.Contain(3));
            //Assert.That(result, Does.Contain(5));

            Assert.That(result, Is.EquivalentTo(new [] {1,3,5}));

            //Assert.That(result, Is.Ordered);
            //Assert.That(result, Is.Unique);
        }

    }
}
