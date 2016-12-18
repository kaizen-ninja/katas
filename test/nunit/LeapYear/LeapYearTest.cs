using NUnit.Framework;

namespace Katas.TheLeapYearKata
{
    [TestFixture]
    [Category("The LeapYear")]
    public class LeapYearTest
    {
        [Test]
        [TestCase(2011, false)]
        [TestCase(2000, true)]
        [TestCase(1900, false)]
        [TestCase(2004, true)]
        [TestCase(1999, false)]
        public void CanTestForLeapYears(int year, bool answer)
        {
            Assert.AreEqual(LeapYear.IsLeapYear(year), answer);
        }
    }
}