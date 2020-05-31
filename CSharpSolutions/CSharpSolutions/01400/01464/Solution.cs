using System;


namespace CSharpSolutions._01400._01464
{
    public class Solution
    {
        public int MaxProduct(int[] nums)
        {
            int max = int.MinValue;
            for (int i = 0; i < nums.Length; i++)
                for (int j = 0; j < nums.Length; j++)
                    if (i != j)
                        max = Math.Max((nums[i] - 1) * (nums[j] - 1), max);
            return max;
        }
    }
}
