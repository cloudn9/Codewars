using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Codewars.Test
{
    [TestFixture]
    public class DisemvowelTest
    {
        [Test]
        public void ShouldRemoveAllVowels()
        {
            Assert.AreEqual("Ths wbst s fr lsrs LL!", DisemvowelsTrolls.Solution("This website is for losers LOL!"));
        }
    }
}
