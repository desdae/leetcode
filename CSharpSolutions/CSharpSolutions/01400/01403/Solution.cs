using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpSolutions._01400._01403
{
    public class Solution
    {
        public IList<int> MinSubsequence(int[] nums)
        {
            Array.Sort(nums);
            Array.Reverse(nums);
            int sum = nums.Sum();
            var r = new List<int>();
            var cs = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                cs += nums[i];
                r.Add(nums[i]);
                if (cs > sum - cs)
                    return r;
            }
            return r;
        }
    }
}
