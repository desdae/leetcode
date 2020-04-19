using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSolutions._30.Day.Challenge.Day17
{
    public class Solution
    {
        
        public void Fill(int y, int x, char[][] grid)
        {
            if (x < 0 || y < 0 || y >= grid.Length || x >= grid[0].Length)
                return;
            if (grid[y][x] == '0' || grid[y][x] == '2')
                return;
            grid[y][x] = '2';
            Fill(y - 1, x, grid);
            Fill(y + 1, x, grid);
            Fill(y, x - 1, grid);
            Fill(y, x + 1, grid);
        }
        public int NumIslands(char[][] grid)
        {
            int m = grid.Length;
            if (m == 0) return 0;
            int n = grid[0].Length;
            int res = 0;

            for (int j = 0; j < m; j++)
                for (int i = 0; i < n; i++)
                {
                    if (grid[j][i] == 1)
                    {
                        res++;
                        Fill(j, i, grid);
                    }
                }

            return res;
        }
    }
}
