using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.BearAndSteadyGene
{
    [TestFixture]
    public class TestBearAndSteadyGene
    {
        BearAndSteadyGene BASG = new BearAndSteadyGene();
        [Test]
        public void TestCreatingEkz()
        {
            Assert.IsNotNull(BASG);
        }

        [Test]
        public void TestFourFold()
        {
            Assert.IsTrue(BASG.FourFold("AGCT"));
            Assert.IsFalse(BASG.FourFold("AGCTA"));
            Assert.IsFalse(BASG.FourFold("AGCTGG"));
            Assert.IsTrue(BASG.FourFold("AGCTCTGA"));

        }
        [Test]
        public void TestTheAmountOfEachGene()
        {
            Assert.AreEqual(4, BASG.TheAmountOfEachGene("AAAAAAGGCCTTCGTT"));
            Assert.AreEqual(2, BASG.TheAmountOfEachGene("AAAAGGTT"));
            Assert.AreEqual(3, BASG.TheAmountOfEachGene("AAAAAAGGCCTT"));
        }
        [Test]
        public void TestResultCountOfEachOfGens()
        {
            Assert.AreEqual(new int[] { 4, 1, 0, 3 }, BASG.ResultCountOfEachOfGens("AAAAGTTT"));
            Assert.AreEqual(new int[] { 4, 1, 4, 3 }, BASG.ResultCountOfEachOfGens("AAAAGTTTCCCC"));
            Assert.AreEqual(new int[] { 5, 2, 2, 3 }, BASG.ResultCountOfEachOfGens("AAAAAGGCCTTT"));
        }
        [Test]
        public void TestReplaceableNumberOfGenes()
        {
            Assert.AreEqual(4,BASG.ReplaceableNumberOfGenes("AAAAAAGGTTTA"));
            Assert.AreEqual(3, BASG.ReplaceableNumberOfGenes("AAAA"));
            Assert.AreEqual(3, BASG.ReplaceableNumberOfGenes("ACCGGGGC"));
        }
    }
}
