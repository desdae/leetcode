using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSolutions._30.Day.Challenge.Day18
{
    //this one TLE at bigger grids
    public class SolutionDFS_TLE
    {

        int min = int.MaxValue;
        
        private void DFS(int y, int x, int sum, int[][] grid)
        {
            if (y == grid.Length) return;
            if (x == grid[0].Length) return;
            if (y == grid.Length - 1 && x == grid[0].Length - 1)
            {
                min = Math.Min(min, sum);
            }
            DFS(y + 1, x, sum + grid[y][x], grid);
            DFS(y, x + 1, sum + grid[y][x], grid);
        }
        public int MinPathSum(int[][] grid)
        {
            if (grid.Length == 0) return 0;
            DFS(0, 0, grid[0][0], grid);
            return min;
        }
    }

    //DP
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
                    if (dp[j, i - 1] > dp[j - 1, i])
                    {
                        dp[j, i] = dp[j - 1, i] + grid[j][i];
                    }
                    else
                    {
                        dp[j, i] = dp[j, i - 1] + grid[j][i];
                    }

            return dp[m - 1, n - 1];
        }
    }
}
