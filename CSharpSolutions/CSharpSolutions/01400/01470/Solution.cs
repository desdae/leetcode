using System.Collections.Generic;

namespace CSharpSolutions._01400._01470
{
    public class Solution
    {
        public int[] Shuffle(int[] nums, int n)
        {
            List<int> res = new List<int>();
            for (int i = 0; i < n; i++)
            {
                res.Add(nums[i]);
                res.Add(nums[n + i]);
            }
            return res.ToArray();
        }
    }
}
