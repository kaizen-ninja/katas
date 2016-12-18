using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Katas.BearAndSteadyGene
{
    [TestFixture]
    class BearAndSteadyGeneTest
    {
        [Test]
        public void TestMinSubstring()
        {
            Assert.AreEqual(2, BearAndSteadyGene.getMinimumSubstring(8, "ATTTACCA"));
            Assert.AreEqual(4, BearAndSteadyGene.getMinimumSubstring(12, "CTTTTTTACTAA"));
        }
    }
}
