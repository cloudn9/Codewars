using NUnit.Framework;
using System;

namespace Codewars.Test
{
    [TestFixture]
    public class WellOfIdeasTest
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual("Fail!", WellOfIdeas.Well(new string[] { "bad", "bad", "bad" }));
            Assert.AreEqual("Publish!", WellOfIdeas.Well(new string[] { "good", "bad", "bad", "bad", "bad" }));
            Assert.AreEqual("I smell a series!", WellOfIdeas.Well(new string[] { "good", "bad", "bad", "bad", "bad", "good", "bad", "bad", "good" }));
            Assert.AreEqual("Fail!", WellOfIdeas.Well(new string[] { "asd", "sddd", "bassd", "bdsdad", "baaaad", "goossssd", "bassd", "badaa", "gossod" }));
            Assert.AreEqual("Publish!", WellOfIdeas.Well(new string[] { "good", "sddd" }));
            Assert.AreEqual("Fail!", WellOfIdeas.Well(new string[] { }));
        }
    }
}
