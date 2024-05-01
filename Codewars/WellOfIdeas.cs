
using System.Linq;

namespace Codewars
{
    public class WellOfIdeas
    {
        public static string Well(string[] x)
        {
            return Check(x);
        }

        private static string Check(string[] x)
        {
            var res = "Fail!";
            var good = x.Count(p => string.Equals(p, "good", System.StringComparison.InvariantCultureIgnoreCase));
            if (good >= 1 || good > 2)
            {
                return good > 2 ? "I smell a series!" : "Publish!";
            }

            return res;
        }
    }
}
