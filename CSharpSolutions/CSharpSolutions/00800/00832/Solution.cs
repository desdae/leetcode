using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSolutions._00800._00832
{
    public class Solution
    {
        public int[][] FlipAndInvertImage(int[][] A)
        {
            for (int y = 0; y < A.Length; y++)
            {
                Array.Reverse(A[y]);
                for (int x = 0; x < A[y].Length; x++)
                    A[y][x] = A[y][x] == 0 ? 1 : 0;
            }
            return A;
        }
    }
}
