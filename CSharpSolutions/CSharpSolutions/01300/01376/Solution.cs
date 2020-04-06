using System;
using System.Collections.Generic;

namespace CSharpSolutions._01300._01376
{
    public class Solution
    {
        public class N
        {
            public List<N> subs = new List<N>();
            public int it = 0;
            public int idx = 0;

            public N(int a, int ix)
            {
                it = a;
                idx = ix;
            }
        }

        int max = 0;

        private void DFS(N root, int d)
        {
            max = Math.Max(max, d);
            foreach (var e in root.subs)
            {
                DFS(e, d + root.it);
            }
        }

        public int NumOfMinutes(int n, int headID, int[] manager, int[] informTime)
        {
            Dictionary<int, N> d = new Dictionary<int, N>();
            N h = new N(informTime[headID], headID);
            d[headID] = h;
            for (int i = 0; i < n; i++)
            {
                N m;
                if (manager[i] != -1)
                {
                    if (d.ContainsKey(manager[i]))
                    {
                        m = d[manager[i]];
                    }
                    else
                    {
                        m = new N(informTime[manager[i]], manager[i]);
                        d[manager[i]] = m;
                    }
                }
                else
                {
                    m = h;
                }
                N e;
                if (d.ContainsKey(i))
                {
                    e = d[i];
                }
                else
                {
                    e = new N(informTime[i], i);
                    d[i] = e;
                }
                if (m.idx != e.idx)
                {
                    m.subs.Add(e);
                }
            }
            DFS(d[headID], 0);
            return max;
        }
    }
}
