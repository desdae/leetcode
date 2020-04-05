using System;

namespace CSharpSolutions._01300._01362
{
    public class Solution
    {
        private int[] CD(int num)
        {
            int s = (int)Math.Sqrt(num);
            int r = s;
            while (s > 0)
            {
                if (num % s == 0)
                {
                    r = num / s;
                    break;
                }
                s--;
            }
            return new int[] { s, r };
        }
        public int[] ClosestDivisors(int num)
        {
            var a = CD(num + 1);
            var b = CD(num + 2);
            if (Math.Abs(a[0] - a[1]) < Math.Abs(b[0] - b[1]))
                return a;
            else
                return b;
        }
    }
}
