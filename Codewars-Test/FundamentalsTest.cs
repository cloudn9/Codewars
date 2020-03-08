using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Codewars.Test
{   
    [TestFixture]
    class FirstNonConsecutiveTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(6, FirstNonConsecutive.Solution(new int[] { 1, 2, 3, 4, 6, 7, 8 }));
        }

        [Test]
        public void TestWithNegative()
        {
            Assert.AreEqual(4, FirstNonConsecutive.Solution(new int[] { -1, 0, 1, 4, 6, 7, 8 }));
        }

        [Test]
        public void TestWithNegatives()
        {
            Assert.AreEqual(-4, FirstNonConsecutive.Solution(new int[] { -3, -2, -4, 0, 1, 4, 6, 7, 8 }));
        }

        [Test]
        public void NullTest()
        {
            //If the whole array is consecutive then return null2.
            Assert.AreSame(null, FirstNonConsecutive.Solution(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }));
        }

        [Test]
        public void EmptyArrayTest()
        {
            Assert.IsTrue(FirstNonConsecutive.Solution(new int[] { }) == null);
        }

        [Test]
        public void EmptyArrayTest1()
        {
            Assert.IsTrue(FirstNonConsecutive.Solution(new int[] { 1 }) == null);
        }
    }
}
