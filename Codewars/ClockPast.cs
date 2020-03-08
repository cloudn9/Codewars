using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    public static class ClockPast
    {
        public static int Solution(int h, int m, int s)
        {
            //0 <= h <= 23, 0 <= m <= 59, 0 <= s <= 59
            return (int)new TimeSpan( h, m, s).TotalMilliseconds;
        }
    }
}
