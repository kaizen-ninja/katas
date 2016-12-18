using NUnit.Framework;
using System.Collections.Generic;

namespace Katas.Equi
{
    [TestFixture]
    public class EquiTests
    {
        [Test]
        public void GetEqui_123m1123_34expected()
        {
            List<int> expected = new List<int>();
            expected.Add(3);
            expected.Add(4);
            int[] m = { 1, 2, 3, -1, 1, 2, 3 };
            bool a = true, e = true;

            Equi eq = new Equi();
            List<int> actual = new List<int>();
            actual = eq.GetEqui(7, m);

            //Comparing lists
            for (int i = 0; i < actual.Count; i++)
                if (actual[i] != expected[i])
                    a = false;

            Assert.AreEqual(e, a);
        }

        [Test]
        public void GetEqui_m13m451m621_137expected()
        {
            List<int> expected = new List<int>();
            expected.Add(1);
            expected.Add(3);
            expected.Add(7);
            int[] m = { -1, 3, -4, 5, 1, -6, 2, 1 };
            bool a = true, e = true;

            Equi eq = new Equi();
            List<int> actual = new List<int>();
            actual = eq.GetEqui(8, m);

            //Comparing lists
            for (int i = 0; i < actual.Count; i++)
                if (actual[i] != expected[i])
                    a = false;

            Assert.AreEqual(e, a);
        }
    }
}
