using NUnit.Framework;
using System.Collections.Generic;

namespace Katas.ReversePolishNotation
{
    [TestFixture]
    [Category("ReversePolishNotation")]
    class TestReversePolishNotation
    {
        Dictionary<string, double> testsTable;

        [SetUp]
        public void InitializeTestTable()
        {
            testsTable = new Dictionary<string, double>
            {
                { "5", 5 },                 //5
                { "2 3 +", 2 + 3 },         //5
                { "3 4 - 5 +", 4 - 3 + 5 }, //6
                { "3 4 5 * -", 5 * 4 - 3 }  //17
            };
        }

        [Test]
        public void RPN_One()
        {
            foreach (var test in testsTable)
            {
                var result = new ReversePolishNotationSession(test.Key).Evaluate();
                Assert.AreEqual(test.Value, result);
            }
        }
    }
}
