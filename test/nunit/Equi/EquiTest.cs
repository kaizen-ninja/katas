using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Katas.Equi
{
    [TestFixture]
    class EquiTest
    {
        [Test]
        public void EquiTest()
        {
            Assert.AreEqual(1, Equi.EquiRun(new int[] { -1, 3, -4, 5, 1, -6, 2, 1 }, 8));
            Assert.AreEqual(2, Equi.EquiRun(new int[] { 3, 0, -4, 5, 1, -6, 2, 1 }, 8));
        }

    }
}
