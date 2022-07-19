using NUnit.Framework;


namespace Codewars.Test
{
    [TestFixture]
    public class OpenOrSeniorTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(new[] { "Open", "Senior", "Open", "Senior" },
                OpenOrSenior.GetResult(new[] {
                    new[] { 45, 12 },
                    new[] { 55, 21 },
                    new[] { 19, 2 },
                    new[] { 104, 20 }
                }));
            Assert.AreEqual(new[] { "Open", "Open", "Open", "Open" },
                OpenOrSenior.GetResult(new[] {
                    new[] { 3, 12 },
                    new[] { 55, 1 },
                    new[] { 91, -2 },
                    new[] { 54, 23 }
                }));
            Assert.AreEqual(new[] { "Senior", "Open", "Open", "Open" },
                OpenOrSenior.GetResult(new[] {
                    new[] { 59, 12 },
                    new[] { 45, 21 },
                    new[] { -12, -2 },
                    new[] { 12, 12 }
                }));
        }
    }
}
