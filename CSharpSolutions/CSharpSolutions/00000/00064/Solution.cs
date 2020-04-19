using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSolutions._00000._00064
{
    public class Solution
    {
        public int MinPathSum(int[][] grid)
        {
            if (grid.Length == 0)
                return 0;

            int m = grid.Length;
            int n = grid[0].Length;


            int[,] dp = new int[m, n];
            dp[0, 0] = grid[0][0];

            for (int i = 1; i < n; i++)
            {
                dp[0, i] = dp[0, i - 1] + grid[0][i];
            }

            for (int j = 1; j < m; j++)
            {
                dp[j, 0] = dp[j - 1, 0] + grid[j][0];
            }

            for (int j = 1; j < m; j++)
                for (int i = 1; i < n; i++)
                    dp[j, i] = Math.Min(dp[j - 1, i], dp[j, i - 1]) + grid[j][i];

            return dp[m - 1, n - 1];
        }
    }
}
