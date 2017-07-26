using System;
using FluentAssertions;
using NUnit.Framework;

namespace Katas.CircularPrimes
{
    [TestFixture]
    public class TestCircularPrimes
    {
        [Test]
        [TestCase(1, 0)]
        [TestCase(10, 4)]
        [TestCase(100, 13)]
        [TestCase(1000, 25)]
        [TestCase(10000, 33)]
        [TestCase(100000, 43)]
        [TestCase(1000000, 55)]
        public void TestPrimesBelow(int n, int expected)
        {
            var circularPrimes = new CircularPrimes();
            circularPrimes.CalcCircularPrimesCount(n).Should().Be(expected);
        }
    }
}