using System.Collections.Generic;

namespace CSharpSolutions._00200._00202
{
    public class Solution
    {
        private int SumSqDig(int n)
        {
            int r = 0;
            while (n >= 1)
            {
                int d = n % 10;
                n /= 10;
                r += d * d;
            }
            return r;
        }

        public bool IsHappy(int n)
        {
            var d = new HashSet<int>();
            while (true)
            {
                n = SumSqDig(n);
                if (n == 1) return true;
                if (d.Contains(n)) return false;
                d.Add(n);
            }
        }
    }
}
