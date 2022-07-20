using System;
using VariousKata;
using NUnit.Framework;

namespace VariousTests
{

  [TestFixture]
  public class NthSeriesTests
  {

    [Test]
    public void Test1()
    {
      Assert.AreEqual("0.00", NthSeries.seriesSum(0));
    }
    [Test]
    public void Test2()
    {
      Assert.AreEqual("1.77", NthSeries.seriesSum(9));
    }

  }
}