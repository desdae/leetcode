using System;


namespace CSharpSolutions._00100._00174
{

    public class Solution
    {
        public int CalculateMinimumHP(int[][] dungeon)
        {
            int m = dungeon.Length;
            int n = dungeon[0].Length;
            int[,] curHp = new int[m, n];
            int[,] minHp = new int[m, n];
            curHp[0, 0] = dungeon[0][0];
            minHp[0, 0] = Math.Max(1 - curHp[0, 0], 1);
            for (int i = 1; i < m; i++)
            {
                curHp[i, 0] = curHp[i - 1, 0] + dungeon[i][0];
                minHp[i, 0] = Math.Max(minHp[i - 1, 0], 1 - curHp[i, 0]);
            }
            for (int i = 1; i < n; i++)
            {
                curHp[0, i] = curHp[0, i - 1] + dungeon[0][i];
                minHp[0, i] = Math.Max(minHp[0, i - 1], 1 - curHp[0, i]);
            }
            for (int i = 1; i < m; i++)
                for (int j = 1; j < n; j++)
                {
                    curHp[i, j] = Math.Max(curHp[i - 1, j], curHp[i, j - 1]) + dungeon[i][j];
                    minHp[i, j] = Math.Min(
                                    Math.Max(minHp[i - 1, j], 1 - curHp[i - 1, j] - dungeon[i][j]),
                                    Math.Max(minHp[i, j - 1], 1 - curHp[i, j - 1] - dungeon[i][j])
                                  );
                    if (curHp[i, j] == 0)
                        curHp[i, j] = -1;
                }


            /*for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write($"{curHp[i, j]}({minHp[i, j]}) ");
                Console.WriteLine();
            }*/

            return minHp[m - 1, n - 1];
        }
    }
    public class SolutionBad
    {
        public int CalculateMinimumHP(int[][] dungeon)
        {
            int m = dungeon.Length;
            int n = dungeon[0].Length;
            int[,] maxHp = new int[m, n];
            int[,] curHp = new int[m, n];
            maxHp[0, 0] = -Math.Min(dungeon[0][0], 0) + 1;
            curHp[0, 0] = Math.Max(dungeon[0][0], 1);
            for (int i = 1; i < m; i++)
            {
                maxHp[i, 0] = maxHp[i - 1, 0] - Math.Min(dungeon[i][0], 0);
                curHp[i, 0] = Math.Max(curHp[i - 1, 0] + dungeon[i][0], 1);
            }
            for (int i = 1; i < n; i++)
            {
                maxHp[0, i] = maxHp[0, i - 1] - Math.Min(dungeon[0][i], 0);
                curHp[0, i] = Math.Max(curHp[0, i - 1] + dungeon[0][i], 1);
            }
            for (int i = 1; i < m; i++)
                for (int j = 1; j < n; j++)
                {
                    int ii, jj;
                    if (maxHp[i, j - 1] > maxHp[i - 1, j])
                    {
                        ii = i;
                        jj = j - 1;
                    }
                    else
                    {
                        ii = i - 1;
                        jj = j;
                    }
                    maxHp[i, j] = maxHp[ii, jj] - Math.Min(dungeon[i][j], 0);
                    curHp[i, j] = Math.Max(curHp[ii, jj] + dungeon[i][j], 1);
                }


            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write($"{maxHp[i, j]}({curHp[i, j]}) ");
                Console.WriteLine();
            }

            return 1;
        }
    }
}
