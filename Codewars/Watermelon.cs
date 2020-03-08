using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    public class Watermelon
    {
        public static bool Divide(int weight)
        {
            //Given an integral number of watermelons w(1 ≤ w ≤ 100; 1 ≤ win Haskell), 
            //check whether Pete and Billy can divide the melons so that each of them gets an even amount.
            //Pete and Billy are great fans of even numbers, that's why they want to divide the number of 
            //watermelons in such a way that each of the two parts consists of an even number of watermelons. 
            //However, it is not obligatory that the parts are equal.

            //Example: the boys can divide a stack of 8 watermelons into 2 + 6 melons, or 4 + 4 melons.
            return (weight > 2 && weight % 2 == 0) ? true : false;
        }

    }
}
