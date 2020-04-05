using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSolutions._00200._00219
{
    public class Solution
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            Dictionary<int, List<int>> minMax = new Dictionary<int, List<int>>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!minMax.ContainsKey(nums[i]))
                {
                    minMax[nums[i]] = new List<int>();
                }
                minMax[nums[i]].Add(i);
            }
            foreach (var x in minMax.Values)
            {
                if (x.Count >= 2)
                {
                    x.Sort();
                    var a = x.ToArray();
                    for (int i = 0; i < a.Length - 1; i++)
                    {
                        if (a[i + 1] - a[i] <= k)
                            return true;
                    }
                }
            }
            return false;
        }
    }
}
