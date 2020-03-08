using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Codewars.Test
{
    [TestFixture]
    public class MakeComplementTest
    {

        [Test]
        public void Test1()
        {
            Assert.True("TTTT" == MakeComplement.Solution("AAAA"));
        }
    }
}
