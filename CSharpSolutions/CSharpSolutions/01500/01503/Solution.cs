using System;

namespace CSharpSolutions._01500._01503
{
    public class Solution
    {
        public int GetLastMoment(int n, int[] left, int[] right)
        {
            int max = 0;
            for (int i = 0; i < left.Length; i++)
                max = Math.Max(max, left[i]);
            for (int i = 0; i < right.Length; i++)
                max = Math.Max(max, n - right[i]);

            return max;
        }
    }
}
