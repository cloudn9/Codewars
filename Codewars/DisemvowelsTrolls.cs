using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    public static class DisemvowelsTrolls
    {
        public static string Solution(string str)
        {
            var vows = new char[] { 'A', 'a', 'O', 'o', 'U', 'u', 'E', 'e', 'I', 'i' };
            var p = str.Where(k => !vows.Contains(k)).Select(k => k);
            return new string(p.ToArray());
        }
    }
}
