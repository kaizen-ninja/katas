using NUnit.Framework;
using System.Collections.Generic;

namespace EquiKata
{
    [TestFixture]
    public class TestEqui
    {
        Equi Eq = new Equi(new int[] { -1, -2, 4, -6, 1 });

        [Test]
        public void TestCreateEkz()
        {
            Assert.IsNotNull(Eq);
        }
        [Test]
        public void TestIsEquilibrium()
        {
            Assert.IsTrue(Eq.IsEquilibrium(3));
            Assert.IsTrue(Eq.IsEquilibrium(1));
        }
        [Test]
        public void TestGetIndexOfEq()
        {
            Assert.AreEqual(new List<int>() {1,3}, Eq.GetIndexOfEquilibrium());
        }
    }
}
