using System.Collections.Generic;

namespace CSharpSolutions._01400._01466
{
    public class Solution
    {
        private int res;
        public class Edge
        {
            public List<Edge> incP = new List<Edge>();
            public List<Edge> outP = new List<Edge>();
            public bool vis = false;
            public int val;
        }

        public void Traverse(Edge x)
        {
            if (x.vis) return;
            x.vis = true;
            foreach (var e in x.incP)
            {
                Traverse(e);
            }
            foreach (var e in x.outP)
            {
                if (!e.vis) res++;
                Traverse(e);
            }
        }

        public int MinReorder(int n, int[][] connections)
        {
            res = 0;
            Dictionary<int, Edge> G = new Dictionary<int, Edge>();
            for (int i = 0; i < connections.Length; i++)
            {
                if (!G.ContainsKey(connections[i][0]))
                    G[connections[i][0]] = new Edge { val = connections[i][0] };
                if (!G.ContainsKey(connections[i][1]))
                    G[connections[i][1]] = new Edge { val = connections[i][1] };
                G[connections[i][0]].outP.Add(G[connections[i][1]]);
                G[connections[i][1]].incP.Add(G[connections[i][0]]);
            }

            Traverse(G[0]);

            return res;
        }
    }
}
