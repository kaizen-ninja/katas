using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Katas.NUnit
{
    class BinTests
    {
        BinClass bc = new BinClass(1041);
        BinClass newbc = new BinClass(2222);
        BinClass newbc2 = new BinClass(1401);

        [Test]
        public void BinTest()
        {
            Assert.AreEqual("10000010001", bc.ConvertToBin());
            Assert.AreEqual(5, bc.Solution());
            Assert.IsNotNull(bc);
        }

        [Test]
        public void BinTest2()
        {
            Assert.AreEqual("100010101110", newbc.ConvertToBin());
            Assert.AreEqual(3, newbc.Solution());
            Assert.IsNotNull(newbc);
        }

        [Test]
        public void BinTest3()
        {
            Assert.AreEqual("10101111001", newbc2.ConvertToBin());
            Assert.AreEqual(2, newbc2.Solution());
            Assert.IsNotNull(newbc2);
        }
    }
}
