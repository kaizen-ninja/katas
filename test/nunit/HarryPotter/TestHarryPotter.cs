using NUnit.Framework;
using System.Collections.Generic;

namespace Katas.TheHarryPotterKata
{
    [TestFixture]
    [Category("HarryPoterKata")]
    public class TestHarryPotter
    {
        readonly float[] Discounts = { 1.00f, 0.95f, 0.90f, 0.80f, 0.75f };
        const float BookPrice = 8f;

        HarryPotterShop shop;

        [SetUp]
        public void Harry_Setup()
        {
            shop = new HarryPotterShop(BookPrice, Discounts);
        }

        [Test]
        public void Harry_TestOne()
        {
            float sum = shop.GetBasketSum(2, 2, 2, 1, 1);
            Assert.AreEqual(51.6f, sum);
        }

        [Test]
        public void Harry_TestTwo()
        {
            float sum = shop.GetBasketSum();
            Assert.AreEqual(0.0f, sum);
            sum = shop.GetBasketSum(0);
            Assert.AreEqual(0.0f, sum);
            sum = shop.GetBasketSum(0, 0, 0, 0);
            Assert.AreEqual(0.0f, sum);
        }

        [Test]
        public void Harry_TestThree()
        {
            float sum = shop.GetBasketSum(2);
            Assert.AreEqual(16.0f, sum);
        }

        [Test]
        public void Harry_TestDiscounts()
        {
            var discountTests = new Dictionary<int, float>()
            {
                {-1, 0f     },
                { 0, 0f     },
                { 1, 1f     },
                { 2, 0.95f  },
                { 3, 0.90f  },
                { 4, 0.80f  },
                { 5, 0.75f  },
                { 6, 0.75f  },
                { 25, 0.75f }
            };
            foreach (var pair in discountTests)
            {
                Assert.AreEqual(pair.Value, shop.GetDiscount(pair.Key));
            }
        }
    }
}