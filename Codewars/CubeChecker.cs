using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    public class CubeChecker
    {
        public bool IsCube(double volume, double side)
        {
            return side <= 0 ? false : Math.Pow(side, 3) == volume;
        }
    }
}
