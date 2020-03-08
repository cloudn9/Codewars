using NUnit.Framework;
using Codewars;

namespace Codewars.Test
{
    public class DnaStrandTest
    {
        [Test]
        public void test01()
        {
            Assert.AreEqual("TTTT", DnaStrand.Solution("AAAA"));
        }
        [Test]
        public void test02()
        {
            Assert.AreEqual("TAACG", DnaStrand.Solution("ATTGC"));
        }
        [Test]
        public void test03()
        {
            Assert.AreEqual("CATA", DnaStrand.Solution("GTAT"));
        }
    }
}