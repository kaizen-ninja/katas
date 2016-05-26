using NUnit.Framework;

namespace Katas.StringSum
{
    [TestFixture]
    [Category("StringSumkata")]
    public class AnotherStringSumKataFixture
    {
        [Test]
        [TestCase("111", "111", "222")]
        [TestCase("999", "1", "1000")]
        [TestCase("12345", "123", "12468")]
        [TestCase("0", "0", "0")]
        [TestCase("0", "asd", "0")]
        [TestCase("zxc", "5", "5")]
        [TestCase("-1", "5", "5")]
        [TestCase("-1", "-5", "0")]
        [TestCase("-1", "-5", "0")]
        //Very very big integer string which u can't parse into int
        [TestCase("999999999999999999999999999999999999999999999999", "1", "1000000000000000000000000000000000000000000000000")]
        public void SumStringsTest(string left, string right, string expected)
        {
            string actual = AnotherStringSumKata.Sum(left, right);

            Assert.AreEqual(expected, actual);
        }
    }
}