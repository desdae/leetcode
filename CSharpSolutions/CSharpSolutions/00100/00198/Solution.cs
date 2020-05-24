using System;


namespace CSharpSolutions._00100._00198
{
    public class Solution
    {
        public int Rob(int[] nums)
        {
            int n = nums.Length;
            if (n == 0)
                return 0;
            int[] dp = new int[n + 1];
            dp[0] = 0;
            dp[1] = nums[0];
            for (int i = 1; i < n; i++)
                dp[i + 1] = Math.Max(dp[i], dp[i - 1] + nums[i]);
            return dp[n];
        }
    }
}
