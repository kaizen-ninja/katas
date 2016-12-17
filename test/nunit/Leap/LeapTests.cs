using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Katas.NUnit
{
    class LeapTests
    {
        LeapClass lc = new LeapClass(1992);
        LeapClass newlc = new LeapClass(2000);
        LeapClass newlc2 = new LeapClass(1900);

        [Test]
        public void LeapTest()
        {
            Assert.AreEqual(true, lc.IsLeap());
            Assert.IsNotNull(lc);
        }

        [Test]
        public void LeapTest2()
        {
            Assert.AreEqual(true, newlc.IsLeap());
            Assert.IsNotNull(newlc);
        }

        [Test]
        public void LeapTest3()
        {
            Assert.AreEqual(false, newlc2.IsLeap());
            Assert.IsNotNull(newlc2);
        }
    }
}
