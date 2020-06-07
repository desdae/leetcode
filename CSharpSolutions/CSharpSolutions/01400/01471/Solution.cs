using System;
using System.Linq;

namespace CSharpSolutions._01400._01471
{
    public class Solution
    {
        public int[] GetStrongest(int[] arr, int k)
        {
            int n = arr.Length;
            int mi = (n - 1) / 2;
            var l = arr.ToList();
            l.Sort();
            int m = l[mi];
            Array.Sort(arr, (a, b) =>
            {
                if (Math.Abs(a - m) == Math.Abs(b - m))
                    return b - a;
                return Math.Abs(b - m) - Math.Abs(a - m);
            });
            return arr.Take(k).ToArray();
        }
    }
}
