using NUnit.Framework;


namespace Codewars.Test
{
    [TestFixture]
    public class CountByTest
    {
        [Test]
        public static void CountBy1()
        {
            Assert.AreEqual(new int[] { 1, 2, 3, 4, 5 },
                CountBy.GetResult(1, 5), "Array does not match");
        }

        [Test]
        public static void CountBy2()
        {
            Assert.AreEqual(new int[] { 2, 4, 6, 8, 10 },
                CountBy.GetResult(2, 5), "Array does not match");
        }

        [Test]
        public static void CountBy3()
        {
            Assert.AreEqual(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                CountBy.GetResult(1, 10));
        }

        [Test]
        public static void CountBy4()
        {
            Assert.AreEqual(new int[] { 2, 4, 6, 8, 10 },
                CountBy.GetResult(2, 5));
        }
    }
}
