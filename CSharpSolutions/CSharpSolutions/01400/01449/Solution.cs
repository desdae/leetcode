using System.Numerics;

namespace CSharpSolutions._01400._01449
{
    public class Solution
    {
        public string LargestNumber(int[] cost, int target)
        {
            BigInteger[] dp = new BigInteger[target + 1];
            for (int i = 0; i < target + 1; i++)
                dp[i] = -1;
            dp[0] = 0;
            for (int i = 0; i < target + 1; i++)
                for (int j = 0; j < 9; j++)
                {
                    if (i - cost[j] >= 0 && dp[i - cost[j]] >= 0)
                    {
                        var i1 = dp[i - cost[j]] * 10 + j + 1;
                        var i2 = dp[i];
                        dp[i] = i1 > i2 ? i1 : i2;
                    }
                }

            if (dp[target] < 0)
                return "0";
            return dp[target].ToString();
        }
    }
}
