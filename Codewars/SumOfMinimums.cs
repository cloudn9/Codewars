using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    public class SumOfMinimums
    {
        public static int Solution(int[,] numbers)
        {
            var rows = numbers.GetLength(0);
            var cols = numbers.GetLength(1);
            var total = 0;
            for (int i = 0; i < rows ; i++)
            {
                var result = new List<int>();
                for (int j = 0; j < cols ; j++)
                {
                    result.Add((int)numbers[i, j]);
                }
                total += result.Min();
            }
            return total;
        }
    }
}
