using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSolutions._01300._01351
{
    public class Solution
    {
        public int CountNegatives(int[][] grid)
        {
            int res = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] < 0) res++;
                }
            }
            return res;
        }
    }

    public class SolutionLinq
    {
        public int CountNegatives(int[][] grid) => grid.Sum(r => r.Count(i => i < 0));
    }
}
