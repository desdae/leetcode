using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpSolutions._01400._01458
{
    public class Solution
    {
        public int MaxDotProduct(int[] nums1, int[] nums2)
        {
            int m = nums1.Length;
            int n = nums2.Length;
            int[,] dp = new int[m + 1, n + 1];

            for (int i = 0; i <= m; i++)
                for (int j = 0; j <= n; j++)
                    dp[i, j] = -5000000;

            for (int i = 1; i <= m; i++)
                for (int j = 1; j <= n; j++)
                    dp[i, j] = (new List<int>() { nums1[i - 1] * nums2[j - 1] + Math.Max(0, dp[i - 1, j - 1]), dp[i, j - 1], dp[i - 1, j], }).Max();

            return dp[m, n];

        }
    }
}
