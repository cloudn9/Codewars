using System;
using System.Linq;

namespace Codewars
{
    public class FindNeedle
    {
        public static string Solution(object[] haystack)
        {
            //for (int i = 0; i < haystack.Length; i++)
            //{
            //    if (haystack[i]?.ToString().ToLower() == "needle")
            //    {
            //        return $"found the needle at position {i}";
            //    }
            //}

            var h = haystack.Where(k => k != null && k.ToString().ToLower() == "needle").Select(k => k);

            return $"found the needle at position {Array.IndexOf(haystack, h.SingleOrDefault()).ToString()}";
        }
    }
}