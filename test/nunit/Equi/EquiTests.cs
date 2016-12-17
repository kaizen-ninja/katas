using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Katas.Equi
{
    [TestFixture]
    class EquiTests
    {
        Equi et = new Equi();
        [Test]
        public void Exist()
        {
            Assert.IsNotNull(et);
        }
        [Test]
        public void SolutionTest()
        {
            int[] arr = { -1, 3, -4, 5, 1, -6, 2, 1 };
            Assert.AreEqual(new int[] { 0, 1, 0, 1, 0, 0, 0, 1}, et.Solution(arr));
        }

        [Test]
        public void SolutionTestTwo()
        {
            int[] arr = { 2, -5, -3, -2, 4, -5 };
            Assert.AreEqual(new int[] { 0, 0, 1, 0, 0, 0 }, et.Solution(arr));
        }
    }
}
