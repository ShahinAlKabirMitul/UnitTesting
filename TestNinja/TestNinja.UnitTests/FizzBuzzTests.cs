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
    public class FizzBuzzTests
    {
        [Test]
        public void GetOutPut_InputIsDivisibleBy3And5_ReturnFizzBuzz()
        {
            var result = FizzBuzz.GetOutput(15);
            Assert.That(result,Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void GetOutput_InputIsDivisibleBy3Only_ReturnFizz()
        {
            var result = FizzBuzz.GetOutput(6);
            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Test]
        public void Getoutput_InputIsDivisibleBy5Only_RetunBuzz()
        {
            var result = FizzBuzz.GetOutput(10);
            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [Test]
        public void Getoutput_InputIsNotDivisibleBy3r5_ReturnSameNumber()
        {
            var result = FizzBuzz.GetOutput(7);
            Assert.That(result, Is.EqualTo("7"));
        }
    }

}
