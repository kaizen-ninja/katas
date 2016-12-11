using NUnit.Framework;
using System.Collections.Generic;

namespace Katas.Equi
{
    class TestEqui
    {
        Equi equi = new Equi();

        [Test]
        public void ExistsTest()
        {
            Assert.IsNotNull(equi);
        }

        [Test]
        public void DivideSumTest()
        {
            var arr = new int[] { -1, 3, -4, 5, 1, -6, 2, 1 };
            Assert.IsTrue(equi.DivideSum(arr, 1));
        }
        [Test]
        public void SolutionTest()
        {
            var arr = new int[] { -1, 3, -4, 5, 1, -6, 2, 1 };
            Assert.AreEqual(new List<int>() { 1, 3, 7 }, equi.Solution(arr));
        }
    }
}
