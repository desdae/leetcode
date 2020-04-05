using System.Collections.Generic;
using System.Linq;

namespace CSharpSolutions._01345
{
    public class Solution
    {
        public class Vertex
        {
            public int value;
            public bool visited = false;
            public int dist = 0;
            public HashSet<Vertex> adj = new HashSet<Vertex>();

            public Vertex(int i)
            {
                value = i;
            }

            public void Add(Vertex v)
            {
                adj.Add(v);
            }

            public void Add(int i)
            {
                adj.Add(new Vertex(i));
            }

            public void BFS()
            {
                var q = new Queue<Vertex>();
                var vis = new HashSet<Vertex>();
                q.Enqueue(this);
                vis.Add(this);
                dist = 0;
                while (q.Count > 0)
                {
                    var v = q.Dequeue();
                    var al = v.adj.ToArray();
                    foreach (var va in al)
                    {
                        if (!vis.Contains(va))
                        {
                            va.dist = v.dist + 1;
                            q.Enqueue(va);
                            vis.Add(va);
                        }
                    }
                }
            }
        }

        public int MinJumps(int[] arr)
        {
            int len = arr.Length;
            int jumps = 0;
            if (len == 1) return jumps;
            //Dictionary<int, Vertex> vt = new Dictionary<int, Vertex>();
            Dictionary<int, List<int>> vl = new Dictionary<int, List<int>>();
            int[] d = new int[50005];


            for (int i = 0; i < len; ++i)
            {
                if (!vl.ContainsKey(arr[i]))
                    vl[arr[i]] = new List<int>();
                vl[arr[i]].Add(i);
                d[i] = 0;
            }

            var q = new Queue<int>();
            bool[] vis = new bool[50005];
            //var vis = new HashSet<int>();
            q.Enqueue(0);
            vis[0] = true;

            while (q.Count > 0)
            {
                var v = q.Dequeue();

                if (v > 0 && !vis[v - 1])
                {
                    d[v - 1] = d[v] + 1;
                    q.Enqueue(v - 1);
                    vis[v - 1] = true;
                }

                if (v < len - 1 && !vis[v + 1])
                {
                    d[v + 1] = d[v] + 1;
                    q.Enqueue(v + 1);
                    vis[v + 1] = true;
                }

                foreach (var x in vl[arr[v]])
                {
                    if (!vis[x])
                    {
                        d[x] = d[v] + 1;
                        q.Enqueue(x);
                        //vis.Add(x);
                        vis[x] = true;
                    }
                }
                vl[arr[v]].Clear();
            }

            //full graph does not work because O(n^2) worst case                
            /* for (int i = 0; i < len; ++i)
             {
                 if (i > 0)
                 {
                     vt[i].Add(vt[i - 1]);
                 }
                 if (i < len - 1)
                 {
                     vt[i].Add(vt[i + 1]);
                 }
                 var qq = vl[arr[i]];
                 Console.WriteLine(qq.Count);

                 foreach (var w in vl[arr[i]])
                     if (i != w)
                         vt[i].Add(vt[w]);
             }
             vt[0].BFS();
            return vt[len - 1].dist;*/
            return d[len - 1];
        }
    }

}
