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
    class TestBinaryGap
    {
        Dictionary<int, int> testTable;
        BinaryGap binarygap = new BinaryGap(1);

        [SetUp]
        public void InitializeTestTable()
        {
            testTable = new Dictionary<int, int>
            {
                { 9,    2 },
                { 529,  4 },
                { 20,   1 },
                { 15,   0 },
                { 1041, 5 },
                { 2,    0 }
            };
        }

        [Test]
        public void TestnotnullBinaryGap()
        {
            binarygap = new BinaryGap(0);
            Assert.NotNull(binarygap);
        }

        [Test]
        public void TestFindBinaryGap()
        {
            foreach (var pair in testTable)
            {
                binarygap = new BinaryGap(pair.Key);
                Assert.AreEqual(pair.Value, binarygap.Findbinarygap());
            }
        }
    }
}
