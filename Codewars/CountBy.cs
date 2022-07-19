using System.Linq;

namespace Codewars
{
    public class CountBy
    {
        public static int[] GetResult(int x, int n)
        {
            int[] z = new int[n];

            z = Enumerable.Range(x, x*n).Where(p => p % x == 0).ToArray();

            return z;
        }

    }
}
