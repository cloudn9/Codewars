using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars.Test
{
    [TestFixture]
    public class SummationTest
    {
        [Test]
        public static void BasicTests()
        {
            Assert.AreEqual(1, Summation.Solution(1));
            Assert.AreEqual(36, Summation.Solution(8));
            Assert.AreEqual(253, Summation.Solution(22));
            Assert.AreEqual(5050, Summation.Solution(100));
            Assert.AreEqual(22791, Summation.Solution(213));
        }
    }
}
