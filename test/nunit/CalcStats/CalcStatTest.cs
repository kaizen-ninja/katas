using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Katas.TheCalcStatsKata
{
    [TestFixture]
    [Category("The CalcStats Kata")]
    public class CalcStatTest
    {
        [Test]
        public void MinValue()
        {
            Assert.AreEqual(-2, CalcStat.CalcStats(new int[] { 1, -1, 2, -2, 6, 9, 15, -2, 92, 11 })["Minimum"]);
        }

        [Test]
        public void MaxValue()
        {
            Assert.AreEqual(92, CalcStat.CalcStats(new int[] { 1, -1, 2, -2, 6, 9, 15, -2, 92, 11 })["Maximum"]);
        }

        [Test]
        public void Count()
        {
            Assert.AreEqual(10, CalcStat.CalcStats(new int[] { 1, -1, 2, -2, 6, 9, 15, -2, 92, 11 })["Number of elements"]);
        }

        [Test]
        public void Average()
        {
            Assert.AreEqual(13.1, CalcStat.CalcStats(new int[] { 1, -1, 2, -2, 6, 9, 15, -2, 92, 11 })["Average value"]);
        }
    }
}