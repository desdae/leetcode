using System.Collections.Generic;

namespace CSharpSolutions._01400._01492
{
    class Solution
    {
        public int KthFactor(int n, int k)
        {
            var f = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    f.Add(i);
            }
            if (k > f.Count)
                return -1;
            return f[k - 1];
        }
    }
}
