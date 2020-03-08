using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Codewars.Test
{
    [TestFixture]
    class ClockPastTest
    {
        [Test]
        public void Test()
        {
            Assert.AreEqual(61000, ClockPast.Solution(0, 1, 1));
        }
    }
}
