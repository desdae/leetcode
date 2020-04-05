using System.Collections.Generic;

namespace CSharpSolutions._01313
{
    public class Solution
    {
        public int[] DecompressRLElist(int[] nums)
        {
            var r = new List<int>();
            var n = nums.Length / 2;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < nums[i * 2]; j++)
                    r.Add(nums[i * 2 + 1]);
            }
            return r.ToArray();
        }
    }
}
