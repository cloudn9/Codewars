using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    public static class BlueAndRedMarbles
    {
        public static double Solution(uint blueStart, uint redStart, uint bluePulled, uint redPulled)
        {
            //should return the probability of drawing a blue marble, expressed as a float
            float blue = blueStart - bluePulled; // 3 blue remaining
            float red = redStart - redPulled; // 2 red remaining
            var totalRemain = blue + red;
            return blue / totalRemain;
        }
    }
}
