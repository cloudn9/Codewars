using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    public class ReverseString
    {
        public static string Solution(string str)
        {
            //string result = "";
            //for (int i = str.Length - 1; i >= 0; i--)
            //{
            //    result += str[i];
            //}
            //return result;
            return new string(str.Reverse().ToArray());
        }
    }
}
