using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSolutions._01400._01423
{
    public class Solution
    {
        public int MaxScore(int[] cardPoints, int k)
        {
            int s1 = 0;
            int s2 = cardPoints.Skip(Math.Max(0, cardPoints.Count() - k)).Sum();
            int max = s1 + s2;
            for (int i = 0; i < k; i++)
            {
                s1 += cardPoints[i];
                s2 -= cardPoints[cardPoints.Length - k + i];
                max = Math.Max(max, s1 + s2);
            }
            return max;
        }
    }
}
