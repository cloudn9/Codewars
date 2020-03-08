using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Codewars.Test
{
    [TestFixture]
    public class BlueAndRedMarblesTest
    {
        private const double Delta = 0.0000001;

        [Test]
        public void MyTest()
        {
            Assert.AreEqual(BlueAndRedMarbles.Solution(5, 5, 2, 3), 0.6, Delta);
            Assert.AreEqual(BlueAndRedMarbles.Solution(5, 7, 4, 3), 0.2, Delta);
            Assert.AreEqual(BlueAndRedMarbles.Solution(12, 18, 4, 6), 0.4, Delta);
        }
    }
}
