using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace BinaryGap
{
    [TestFixture]
    public class BinaryGapTest
    {
        BinaryGap p = new BinaryGap();
        [Test]
        public void Exist()
        {
            Assert.IsNotNull(p);
        }

        [Test]
        public void SolutionTest()
        {
            Assert.AreEqual(4, p.Solution(529));
        }
    }
}
