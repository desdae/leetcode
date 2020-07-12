using System;
using System.Collections.Generic;

namespace CSharpSolutions._01500._01504
{
    public class Solution
    {
        public int NumSubmat(int[][] mat)
        {
            int res = 0;
            int n = mat.Length;
            int m = mat[0].Length;
            int[,] pref = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = m - 1; j >= 0; j--)
                {
                    if (mat[i][j] == 1)
                    {
                        if (j < m - 1)
                            pref[i, j] += pref[i, j + 1];
                        pref[i, j] += mat[i][j];
                    }
                }
            }


            for (int j = 0; j < m; j++)
            {
                int i = n - 1;
                Stack<Tuple<int, int>> q = new Stack<Tuple<int, int>>();
                int x = 0;
                while (i >= 0)
                {
                    int c = 0;
                    while (q.Count != 0 && q.Peek().Item1 > pref[i, j])
                    {
                        x -= (q.Peek().Item2 + 1) * (q.Peek().Item1 - pref[i, j]);
                        c += q.Peek().Item2 + 1;
                        q.Pop();
                    }
                    x += pref[i, j];
                    res += x;
                    q.Push(new Tuple<int, int>(pref[i, j], c));
                    i--;
                }
            }
            return res;
        }
    }
}
