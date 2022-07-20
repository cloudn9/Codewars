using System;
using System.Linq;
using System.Collections.Generic;
namespace VariousKata
{
  public partial class Katas
  {
    public static Dictionary<char, int> Count(string str)
    {
      var p = str.GroupBy(k => k).Select(g => new
      {
        Letter = g.Key,
        Times = g.Count()
      }).ToList();

      var result = new Dictionary<char, int>();
      foreach (var item in p)
      {
        result.Add(item.Letter, item.Times);
      }
      return result;
    }
  }
}