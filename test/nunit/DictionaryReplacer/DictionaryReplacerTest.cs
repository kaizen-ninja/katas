using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Katas.DictionaryReplacer
{
    [TestFixture]
    [Category("Dictionary Replacer")]
    class DictionaryReplacerTest
    {
        DictionaryReplacer dr = new DictionaryReplacer();
        [Test]
        public void Exist()
        {
            Assert.IsNotNull(dr);
        }

        [Test]
        public void SolutionTest()
        {
            string text = "$temp$ here comes the name $name$";
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("temp", "temporary");
            dict.Add("name", "John Doe");

            Assert.AreEqual("temporary here comes the name John Doe", dr.RunDictionaryReplacer(text, dict));
        }
    }
}
