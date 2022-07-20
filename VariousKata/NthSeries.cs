using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VariousKata
{
  public class NthSeries
  {
    public static string seriesSum(int n)
    {
      //Examples:
      //SeriesSum(1) => 1 = "1.00"
      //SeriesSum(2) => 1 + 1 / 4 = "1.25"
      //SeriesSum(5) => 1 + 1 / 4 + 1 / 7 + 1 / 10 + 1 / 13 = "1.57"
      var denominator = 1;
      var nominator = 1;
      var result = 0;
      for (int i = 1; i < n; i++)
      {
        result += nominator / (denominator += 3);
      }

      return string.Format("{0:0.00}", result);
    }
  }
}
