using System;
using VariousKata;
using NUnit.Framework;

namespace VariousTests
{
  [TestFixture]
  public static class NbDigTests
  {

    public static void testing(int actual, int expected)
    {
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public static void test1()
    {
      Console.WriteLine("Fixed Tests NbDig");
      testing(CountDig.NbDig(10, 1), 4);
      testing(CountDig.NbDig(25, 1), 11);

      testing(CountDig.NbDig(5750, 0), 4700);
      testing(CountDig.NbDig(11011, 2), 9481);
      testing(CountDig.NbDig(12224, 8), 7733);
      testing(CountDig.NbDig(11549, 1), 11905);
    }
  }
}