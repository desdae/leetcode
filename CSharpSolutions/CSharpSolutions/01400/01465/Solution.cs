using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSolutions._01400._01465
{
    public class Solution
    {
        public int MaxArea(int h, int w, int[] horizontalCuts, int[] verticalCuts)
        {
            long maxH = 0, maxW = 0;

            var H = new List<int>();
            H.Add(0);
            H.AddRange(horizontalCuts);
            H.Add(h);
            H.Sort();
            var W = new List<int>();
            W.Add(0);
            W.AddRange(verticalCuts);
            W.Add(w);
            W.Sort();
            for (int i = 0; i < H.Count - 1; i++)
                maxH = Math.Max(H[i + 1] - H[i], maxH);
            for (int i = 0; i < W.Count - 1; i++)
                maxW = Math.Max(W[i + 1] - W[i], maxW);

            long res = (maxH * maxW) % 1000000007;
            return (int)res;
        }
    }
}
