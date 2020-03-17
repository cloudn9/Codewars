using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using System;

namespace Codewars.Test
{
    [TestFixture]
   public class CubeCheckerTest
    {
        [Test]
        public void ShouldReturnTrue()
        {
            CubeChecker cube = new CubeChecker();
            Assert.AreEqual(true, cube.IsCube(1, 1));
            Assert.AreEqual(true, cube.IsCube(8, 2));            
        }
        [Test]
        public void ShouldReturnFalse()
        {
            CubeChecker cube = new CubeChecker();
            Assert.AreEqual(false, cube.IsCube(2, 1));
            Assert.AreEqual(false, cube.IsCube(6, 3));           
            Assert.AreEqual(false, cube.IsCube(0, 0));
            Assert.AreEqual(false, cube.IsCube(200, 4));
            Assert.AreEqual(false, cube.IsCube(-8, -2));
        }
    }
}

