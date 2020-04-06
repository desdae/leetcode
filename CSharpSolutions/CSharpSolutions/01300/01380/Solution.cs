using System;
using System.Collections.Generic;

namespace CSharpSolutions._01300._01380
{
    public class Solution
    {
        public IList<int> LuckyNumbers(int[][] matrix)
        {
            HashSet<int> md = new HashSet<int>();
            for (int j = 0; j < matrix.Length; j++)
            {
                int m = int.MaxValue;
                for (int i = 0; i < matrix[0].Length; i++)
                {
                    m = Math.Min(m, matrix[j][i]);
                }
                md.Add(m);
            }
            var res = new List<int>();
            for (int i = 0; i < matrix[0].Length; i++)
            {
                int m = int.MinValue;
                for (int j = 0; j < matrix.Length; j++)
                {
                    m = Math.Max(m, matrix[j][i]);
                }
                if (md.Contains(m))
                    res.Add(m);
            }
            return res;
        }
    }
}
