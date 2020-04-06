using System;

namespace CSharpSolutions._01400._01402
{
    public class Solution
    {
        public int MaxSatisfaction(int[] satisfaction)
        {
            Array.Sort(satisfaction);
            int n = satisfaction.Length;
            int max = 0;
            for (int i = 0; i < n; i++)
            {
                int sat = 0;
                int k = 0;
                for (int j = i; j < n; j++)
                {
                    k++;
                    sat += k * satisfaction[j];
                }
                max = Math.Max(sat, max);
            }
            return max;
        }
    }
}
