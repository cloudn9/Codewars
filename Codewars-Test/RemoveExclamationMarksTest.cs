using NUnit.Framework;

namespace Codewars.Test
{
    [TestFixture]
    public class RemoveExclamationMarksTest
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual("", RemoveExclamationMarks.Solution(""), "Input: Empty string");
            Assert.AreEqual("", RemoveExclamationMarks.Solution("!"), "Input: " + "!");
            Assert.AreEqual("", RemoveExclamationMarks.Solution("!!"), "Input: " + "!!");
            Assert.AreEqual("Hi", RemoveExclamationMarks.Solution("Hi!"), "Input: " + "Hi!");
            Assert.AreEqual("?", RemoveExclamationMarks.Solution("!?!"), "Input: " + "!?!");
            Assert.AreEqual("YyVSInU&%AOV%ouripIrUx%*pTFL(Eq@SWYXwlc", 
                RemoveExclamationMarks.Solution("YyVSIn!U&%AOV%ouripIrUx%!*pTFL(Eq!@SWYXwlc"), 
                "Input: " + "YyVSIn!U&%AOV%ouripIrUx%!*pTFL(Eq!@SWYXwlc");
        }
    }
}
