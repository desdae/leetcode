using System.Collections.Generic;
using System.Linq;

namespace CSharpSolutions._01300._01399
{
    public class Solution
    {
        private int SumDig(int n)
        {
            int r = 0;
            while (n >= 1)
            {
                int d = n % 10;
                n /= 10;
                r += d;
            }
            return r;
        }
        public int CountLargestGroup(int n)
        {
            Dictionary<int, int> d = new Dictionary<int, int>();

            for (int i = 1; i <= n; i++)
            {
                int s = SumDig(i);
                if (!d.ContainsKey(s))
                    d[s] = 0;
                d[s]++;
            }
            int max = d.Values.Max();
            return d.Values.Count(x => x == max);

        }
    }
}
