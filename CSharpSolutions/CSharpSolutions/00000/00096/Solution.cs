using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSolutions._00000._00096
{
    
    public class Solution
    {
        public int NumTrees(int n)
        {
            int[] dp = new int[n + 1];
            dp[0] = 1;
            dp[1] = 1;

            for (int i = 2; i <= n; i++)
                for (int j = 1; j <= i; j++)
                    dp[i] += dp[j - 1] * dp[i - j];

            return dp[n];
        }
    }
    
    public class SolutionBad
    {
        
        private int T(int n)
        {
            int res;
            if (n == 1)
                res = 1;
            if (n == 2)
                res = 2;
            else
                res = T(n - 1) * 2 + D(n - 1) * 4;
            return res;
        }

        private int D(int n)
        {
            int res;
            if (n < 3)
                res = 0;
            if (n == 3)
                res = 1;
            else
                res = T(n - 2) + D(n - 2) * 2;
            return res;
        }

        public int NumTrees(int n)
        {
            if (n == 0)
                return 1;
            return T(n) + D(n);
        }
    }
}
