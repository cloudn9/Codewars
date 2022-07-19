
using System.Collections.Generic;

namespace Codewars
{
    public class OpenOrSenior
    {
        public static IEnumerable<string> GetResult(int[][] data)
        {
            // To be a senior, a member must be at least 55 years old and have a handicap greater than 7.
            // In this croquet club, handicaps range from -2 to + 26; the better the player the lower the handicap.
            for (int i = 0; i < data.Length; i++)
            {
                if (IsSenior(data[i][0], data[i][1]))
                {
                    yield return "Senior";
                }
                else yield return "Open";
            }
        }

        private static bool IsSenior(int age, int handicap)
        {
            return age >= 55 && handicap > 7;
        }
    }
}
