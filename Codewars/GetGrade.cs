using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    public class GetGrade
    {
        public static char Solution(int s1, int s2, int s3)
        {
            //90 <= score <= 100  'A'
            //80 <= score < 90    'B'
            //70 <= score < 80    'C'
            //60 <= score < 70    'D'
            //0 <= score < 60 'F'
            var scores = new List<int> { s1, s2, s3 };
            var res = scores.Average();
            if (90 <= res & res <= 100)
            {
                return 'A';
            }
            else if (80 <= res & res <= 90)
            {
                return 'B';
            }
            else if (70 <= res & res <= 80)
            {
                return 'C';
            }
            else if (60 <= res & res <= 70)
            {
                return 'D';
            }
            else
                return 'F';
        }
    }
}
