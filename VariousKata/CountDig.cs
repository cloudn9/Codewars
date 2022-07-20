using System;
using System.Collections.Generic;
using System.Linq;

namespace VariousKata
{
  public class CountDig
  {
    public static int NbDig(int n, int d)
    {
      var doubleValues = new List<string>();
      for (var i = 0; i <= n; i++)
      {
        doubleValues.Add((i * i).ToString());
      }

      var thisDigit = d.ToString();
      var total = 0;
      //foreach (var item in doubleValues)
      //{
      //  total += item.Count(s => s.ToString() == thisDigit);
      //}

      total = doubleValues.Aggregate(0, (result, item) => result + item.Count(s => s.ToString() == thisDigit));
      return total;
    }

    private static string CountTheDigits(string arg1, string arg2, char digit)
    {
      var p = (arg1.Count(s => s == digit) + arg2.Count(s => s == digit)).ToString();
      return p;
    }
  }
}
