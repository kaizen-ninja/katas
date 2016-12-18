using NUnit.Framework;

namespace Katas.TheStringSum
{
    [TestFixture]
    [Category("StringSumkata")]
    public class TestStringSumKata
    {
        StringSumKata ss = new StringSumKata();

        [TestCase("", null, "0")]
        [Test]
        public void AddReturnSum(string num1, string num2, string expectedResult)
        {
            var result = ss.StringSum(num1, num2);

            Assert.That(expectedResult, Is.EqualTo(result));
        }
    }
}