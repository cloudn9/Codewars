using NUnit.Framework;

namespace Codewars.Test
{
    [TestFixture]
    public class SmashTest
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual("hello", Smash.Solution(new string[] { "hello" }));
            Assert.AreEqual("hello world", Smash.Solution(new string[] { "hello", "world" }));
            Assert.AreEqual("hello amazing world", Smash.Solution(new string[] { "hello", "amazing", "world" }));
            Assert.AreEqual("this is a really long sentence", Smash.Solution(new string[] { "this", "is", "a", "really", "long", "sentence" }));
            Assert.AreEqual("", Smash.Solution(new string[] { "" }));
        }
    }
}
