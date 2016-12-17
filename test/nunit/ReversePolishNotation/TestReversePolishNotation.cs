using NUnit.Framework;
using System.Collections.Generic;

namespace Katas.ReversePolishNotation
{
    [TestFixture]
    [Category("ReversePolishNotationKata")]
    class TestReversePolishNotation
    {
        Dictionary<string, double> testsTable;
        ReversePolishNotation rpn = new ReversePolishNotation("");

        [SetUp]
        public void InitializeTestTable()
        {
            testsTable = new Dictionary<string, double>
            {
                { "5", 5 },                 //  5
                { "3 4 +", 3 + 4 },         //  7
                { "3 4 - 5 +", 3 - 4 + 5 }, //  -4
                { "3 4 5 * -", 3 - 4 * 5 }, //  -17
                { "2 2 2 * +", 2 + 2 * 2 }, //  6
                { "2 2 2 + *", (2 + 2) * 2 }//  8
            };
        }

        [Test]
        public void TestnotnullReversePolishNotation()
        {
            rpn = new ReversePolishNotation("");
            Assert.NotNull(rpn);
        }

        [Test]
        public void TestCalculate()
        {
            foreach (var test in testsTable)
            {
                rpn = new ReversePolishNotation(test.Key);
                Assert.AreEqual(test.Value, rpn.Calculate());
            }
        }
    }
}
