using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Codewars.Test
{
    [TestFixture]
    class ReverseStringTest
    {
        [Test]
        public void Solution()
        {
            Assert.AreEqual("dlrow", ReverseString.Solution("world"));
        }
    }
}
