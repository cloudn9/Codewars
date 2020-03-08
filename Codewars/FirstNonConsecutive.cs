using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    public class FirstNonConsecutive
    {
        public static object Solution(int[] arr)
        {
            if (arr is null || arr.Length <= 1)
            {
                return null;
            }
            //for (int i = 0; i < arr.Length - 1; i++)
            //{
            //    if (arr[i] + 1 == arr[i + 1])
            //    {
            //        continue;
            //    }
            //    else return arr[i + 1];
            //}
            //return null;

            return arr.Skip(1).SkipWhile((x, i) => x == ++arr[i]).Cast<int?>().FirstOrDefault();
        }
    }
}

