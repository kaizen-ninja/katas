using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.BinaryGap
{
    [TestFixture]
    public class TestsBinaryGap
    {
        BinaryGap Bg = new BinaryGap();
        [Test]
        public void TestCreatingEkz()
        {
            Assert.IsNotNull(Bg);
        }
        [Test]
        public void TestConverting()
        {
            Assert.AreEqual("1000010001", Bg.ToBinary(529));
            Assert.AreEqual("11011000011", Bg.ToBinary(1731));
        }
        [Test]
        public void TestEndOfGap()
        {
            Assert.AreEqual(3, Bg.FindEndOfGap("0001001"));
            Assert.AreEqual(4, Bg.FindEndOfGap("0000100001"));
            Assert.AreEqual(5, Bg.FindEndOfGap("000001001"));
            Assert.AreEqual(1, Bg.FindEndOfGap("01001"));

        }
        [Test]
        public void TestSolution()
        {
            Assert.AreEqual(4, Bg.Solution(1731));
            Assert.AreEqual(4, Bg.Solution(529));
        }
    }
}
