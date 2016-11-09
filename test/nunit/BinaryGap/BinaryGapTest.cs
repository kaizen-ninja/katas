using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.BinaryGap
{
    [TestFixture]
    [Category("BinaryGapKata")]
    class BinaryGapTest
    {
        Dictionary<int, int> testTable;

        [SetUp]
        public void InitializeTestTable()
        {
            testTable = new Dictionary<int, int>
            {
                { 9,    2 },
                { 529,  4 },
                { 20,   1 },
                { 15,   0 }
            };
        }

        [Test]
        public void BinaryGap_TableTest()
        {
            foreach (var pair in testTable)
            {
                Assert.AreEqual(pair.Value, BinaryGap.GetGapSize(pair.Key));
            }
        }
    }
}
