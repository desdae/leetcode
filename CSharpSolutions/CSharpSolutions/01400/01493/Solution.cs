using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpSolutions._01400._01493
{
    public class Solution
    {
        public int LongestSubarray(int[] nums)
        {
            var r = new List<int>();
            r.Add(0);
            int curr = nums[0];
            int csum = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != curr)
                {
                    r.Add(curr == 1 ? csum : -csum);
                    curr = nums[i];
                    csum = 1;
                }
                else
                {
                    csum++;
                }
            }
            r.Add(curr == 1 ? csum : -csum);
            r.Add(0);
            int max = 0;
            bool hasNeg1 = false;
            bool hasNeg = false;
            for (int i = 1; i < r.Count - 1; i++)
            {
                if (r[i] == -1)
                {
                    max = Math.Max(r[i - 1] + r[i + 1], max);
                    hasNeg1 = true;
                }
                else if (r[i] < 0)
                {
                    hasNeg = true;
                }
                else if (r[i] > 0)
                {
                    max = Math.Max(r[i], max);
                }
            }
            if (!hasNeg1)
            {
                if (hasNeg)
                    max = r.Max();
                else
                    max = Math.Max(r.Max() - 1, 0);
            }
            return max;
        }
    }
}
