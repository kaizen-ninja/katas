using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.CalcStats
{
    [TestFixture]
    public class TestCalc_Stats
    {
        List<double> set = new List<double>() {1,2.54,5,16,54.789 };
        CalcStats CS = new CalcStats();
        [Test]
        public void TestCreatingEkz()
        {
            Assert.IsNotNull(CS);
        }
        [Test]
        public void TestMinValue()
        {
            Assert.AreEqual(1, CS.MinValue(set));
        }
        [Test]
        public void TestMaxValue()
        {
            Assert.AreEqual(54.789, CS.MaxValue(set));
        }
        [Test]
        public void TestAverageValue()
        {
            Assert.AreEqual(15, CS.AverageValue(set));
        }
        [Test]
        public void TestNumberOfElementsInTheSequence()
        {
            Assert.AreEqual(5, CS.NumberOfElementsInTheSequence(set));
        }
    }
}
