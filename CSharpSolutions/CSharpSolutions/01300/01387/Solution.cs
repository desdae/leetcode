using System.Collections.Generic;

namespace CSharpSolutions._01300._01387
{
    public class Solution
    {
        private Dictionary<int, int> pows = new Dictionary<int, int>();
        private int Pow(int x)
        {
            if (pows.ContainsKey(x)) return pows[x];
            int res = 0;
            List<int> vals = new List<int>();
            while (x > 1)
            {
                if (x % 2 == 0) x = x / 2;
                else x = 3 * x + 1;
                vals.Add(x);
                res++;
            }
            int i = 1;
            foreach (var e in vals)
            {
                pows[e] = res - i;
                i++;
            }
            return res;
        }
        public int GetKth(int lo, int hi, int k)
        {
            List<int> p = new List<int>();
            for (int i = lo; i <= hi; i++)
            {
                p.Add(i);
            }
            p.Sort((int a, int b) => {
                int pa = Pow(a);
                int pb = Pow(b);
                if (pa > pb) return 1;
                if (pa < pb) return -1;
                if (a > b) return 1;
                if (a < b) return -1;
                return 0;
            });
            return p[k - 1];
        }
    }
}
