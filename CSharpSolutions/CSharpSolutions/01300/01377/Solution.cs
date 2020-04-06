using System.Collections.Generic;

namespace CSharpSolutions._01300._01377
{
    public class Solution
    {
        public class N
        {
            public List<N> subs = new List<N>();
            public int x = 0;
            public bool vis = false;

            public N(int a)
            {
                x = a;
            }
        }

        double prob = 1;
        bool reached = false;
        int steps = 0;
        private void DFS(N root, double p, int t, int secs)
        {
            if (root.vis) return;
            if (t == root.x)
            {
                if (secs == steps || (root.subs.Count == 1 && secs < steps && root.x != 1))
                {
                    reached = true;
                    prob = p;
                }
                return;
            }
            root.vis = true;
            foreach (var c in root.subs)
            {
                int z = 0;
                if (root.x == 1)
                    z = root.subs.Count;
                else
                    z = root.subs.Count - 1;
                DFS(c, p * 1 / z, t, secs + 1);
            }
        }

        public double FrogPosition(int n, int[][] edges, int t, int target)
        {
            if (n == 1) return 1;
            var d = new Dictionary<int, N>();
            var dr = new HashSet<int>();
            for (int i = 0; i < n - 1; i++)
            {
                N e;
                if (d.ContainsKey(edges[i][0]))
                {
                    e = d[edges[i][0]];
                }
                else
                {
                    e = new N(edges[i][0]);
                    d[edges[i][0]] = e;
                }
                N c;
                if (d.ContainsKey(edges[i][1]))
                {
                    c = d[edges[i][1]];
                }
                else
                {
                    c = new N(edges[i][1]);
                    d[edges[i][1]] = c;
                }
                e.subs.Add(c);
                c.subs.Add(e);
                dr.Add(edges[i][1]);
            }
            steps = t;
            DFS(d[1], 1, target, 0);
            if (!reached) prob = 0;
            return prob;
        }
    }
}
