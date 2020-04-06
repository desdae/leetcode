using System;

namespace CSharpSolutions._01300._01390
{
    public class Solution
    {
        private int DivSum(int x)
        {
            int sq = (int)Math.Sqrt(x);
            int divc = 0;
            int divs = 0;
            for (int i = 1; i <= sq; i++)
            {
                if (x % i == 0)
                {
                    if (i == x / i)
                    {
                        divc++;
                        divs += i;
                    }
                    else
                    {
                        divc += 2;
                        divs += (i + x / i);
                    }
                }
            }
            if (divc == 4) return divs;
            return 0;
        }
        public int SumFourDivisors(int[] nums)
        {
            int res = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                res += DivSum(nums[i]);
            }
            return res;
        }
    }
}
