using System;
using System.Linq;
using System.Collections.Generic;
namespace VariousKata
{
  public partial class Katas
  {
    public static bool IsIsogram(string str)
    {
      var result = str.ToLower().GroupBy(s => s).Select(g => new
      {
        Letter = g,
        Times = g.Count()
      }).ToList();

      return result.Count == 0 || result.All(k => k.Times == 1);
    }
  }
}