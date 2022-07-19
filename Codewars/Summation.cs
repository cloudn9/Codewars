
using System.Linq;

namespace Codewars
{
    public class Summation
    {
        public static int Solution(int num)
        {
            return Enumerable.Range(1, num).Sum();
        }
    }
}
