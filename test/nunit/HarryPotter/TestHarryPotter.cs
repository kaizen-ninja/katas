using NUnit.Framework;
using System.Collections.Generic;

namespace Katas.TheHarryPotterKata
{
    [TestFixture]
    public class TestHarryPotter
    {
        HarryPotterShop shop = new HarryPotterShop();

        [Test]
        public void Exist()
        {
            Assert.IsNotNull(shop);
        }

        [Test]
        public void Test1()
        {
            double result = shop.HarryPotter(2, 2, 2, 1, 1);
            Assert.AreEqual(51.6, result);
        }

        [Test]
        public void Test2()
        {
            double result = shop.HarryPotter();
            Assert.AreEqual(0, result);
            result = shop.HarryPotter(0);
            Assert.AreEqual(0, result);
            result = shop.HarryPotter(0, 0, 0, 0);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Test3()
        {
            double result = shop.HarryPotter(3);
            Assert.AreEqual(24, result);
        }
    }
}