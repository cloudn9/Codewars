using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars.Test
{
    [TestFixture]
    public class WaterMelonTest
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(Watermelon.Divide(4), true);
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(Watermelon.Divide(2), false);
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual(Watermelon.Divide(5), false);
        }

        [Test]
        public void Test4()
        {
            Assert.AreEqual(Watermelon.Divide(88), true);
        }

        [Test]
        public void Test5()
        {
            Assert.AreEqual(Watermelon.Divide(100), true);
        }

        [Test]
        public void Test6()
        {
            Assert.AreEqual(Watermelon.Divide(67), false);
        }

        [Test]
        public void Test7()
        {
            Assert.AreEqual(Watermelon.Divide(90), true);
        }

        [Test]
        public void Test8()
        {
            Assert.AreEqual(Watermelon.Divide(10), true);
        }

        [Test]
        public void Test9()
        {
            Assert.AreEqual(Watermelon.Divide(99), false);
        }

        [Test]
        public void Test10()
        {
            Assert.AreEqual(Watermelon.Divide(32), true);
        }
    }
}
