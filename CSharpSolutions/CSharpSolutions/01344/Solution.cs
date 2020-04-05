using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSolutions._01344
{
    public class Solution
    {
        public double AngleClock(int hour, int minutes)
        {
            double minAngle = ((double)minutes * 6.0) % 360.0;
            double hourAngle = ((double)hour * 30.0 + (double)minutes * 0.5) % 360.0;

            double res = 500.0;
            res = Math.Min(res, Math.Abs(minAngle - hourAngle));
            res = Math.Min(res, Math.Abs(minAngle + 360.0 - hourAngle));
            res = Math.Min(res, Math.Abs(hourAngle + 360.0 - minAngle));

            return res;
        }
    }
}
