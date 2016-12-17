using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Katas.NUnit
{
    class CalcTests
    {
        CalcClass cc = new CalcClass(new int[] { 6, 9, 15, -2, 92, 11 });
        CalcClass newcc = new CalcClass(new int[] { 5, 1, 14, -21 });
        CalcClass newcc2 = new CalcClass(new int[] { 11, -89, 111 });

        [Test]
        public void CalcTest()
        {
            Assert.AreEqual(-2, cc.Min());
            Assert.AreEqual(92, cc.Max());
            Assert.AreEqual(6, cc.Number());
            Assert.AreEqual(21.83333, cc.Average());
            Assert.IsNotNull(cc);
        }

        [Test]
        public void CalcTest2()
        {
            Assert.AreEqual(-21, newcc.Min());
            Assert.AreEqual(14, newcc.Max());
            Assert.AreEqual(4, newcc.Number());
            Assert.AreEqual(-0.25000, newcc.Average());
            Assert.IsNotNull(newcc);
        }

        [Test]
        public void CalcTest3()
        {
            Assert.AreEqual(-89, newcc2.Min());
            Assert.AreEqual(111, newcc2.Max());
            Assert.AreEqual(3, newcc2.Number());
            Assert.AreEqual(11.00000, newcc2.Average());
            Assert.IsNotNull(newcc2);
        }
    }
}
