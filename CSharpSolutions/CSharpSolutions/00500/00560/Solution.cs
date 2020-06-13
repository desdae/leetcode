using System.Collections.Generic;

namespace CSharpSolutions._00500._00560
{
    public class Solution
    {
        private void Add(Dictionary<int, List<int>> d, int key, int val)
        {
            if (!d.ContainsKey(key))
                d[key] = new List<int>();
            d[key].Add(val);
        }
        public int SubarraySum(int[] nums, int k)
        {
            var sums = new Dictionary<int, List<int>>();
            int sum = 0;
            int res = 0;
            Add(sums, 0, -1);
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i]; 
                if (sums.ContainsKey(sum - k))
                    res+=sums[sum - k].Count;
                Add(sums, sum, i);
            }
            return res;
        }
    }
}
