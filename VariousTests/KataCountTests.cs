using NUnit.Framework;

using System.Collections.Generic;

using VariousKata;

namespace VariousTests
{
  [TestFixture]
  public class Tests
  {
    [Test]
    public static void FixedTest_aaaa()
    {
      Dictionary<char, int> d = new Dictionary<char, int>();
      d.Add('a', 4);
      Assert.AreEqual(d, Katas.Count("aaaa"));
    }

    [Test]
    public static void FixedTest_aabb()
    {
      Dictionary<char, int> d = new Dictionary<char, int>();
      d.Add('a', 2);
      d.Add('b', 2);
      Assert.AreEqual(d, Katas.Count("aabb"));
    }
  }
}