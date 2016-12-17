using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Katas.NUnit
{
    class EquiTests
    {
        EquiClass ec = new EquiClass(new int [] { -1, 3, -4, 5, 1, -6, 2, 1 });
        EquiClass newec = new EquiClass(new int[] { -2, 3, -1, 5, -1, -2, 8, -1 });
        EquiClass newec2 = new EquiClass(new int[] { -2, 3, -1, 5, -1, -2, 7, -1 });

        [Test]
        public void EquiTest()
        {
            Assert.AreEqual(1, ec.Solution());
            Assert.AreEqual(-1, ec.Value(1, false));
            Assert.IsNotNull(ec);
        }
        [Test]
        public void EquiTest2()
        {
            Assert.AreEqual(4, newec.Solution());
            Assert.AreEqual(5, newec.Value(4, false));
            Assert.IsNotNull(newec);
        }
        [Test]
        public void EquiTest3()
        {
            Assert.AreEqual(-1, newec2.Solution());
            Assert.IsNotNull(newec2);
        }
    }
}
