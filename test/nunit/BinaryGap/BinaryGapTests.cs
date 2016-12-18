using System;
using NUnit.Framework;

namespace Katas.BinaryGap
{
    [TestFixture]
    public class BinaryGapTests
    {
        [Test]
        public void GetGap_9_2expected()
        {
            int n = 9;
            int expected = 2;

            BinaryGap g = new BinaryGap();
            int actual = g.GetGap(n);

            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void GetGap_529_4expected()
        {
            int n = 529;
            int expected = 4;

            BinaryGap g = new BinaryGap();
            int actual = g.GetGap(n);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetGap_15_0expected()
        {
            int n = 15;
            int expected = 0;

            BinaryGap g = new BinaryGap();
            int actual = g.GetGap(n);

            Assert.AreEqual(expected, actual);
        }


    }
}
