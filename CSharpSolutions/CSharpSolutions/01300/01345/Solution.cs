using System.Collections.Generic;

namespace CSharpSolutions._01345
{
    public class Solution
    {
        public int MinJumps(int[] arr)
        {
            int len = arr.Length;
            int jumps = 0;
            if (len == 1) return jumps;
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
                        vis[x] = true;
                    }
                }
                vl[arr[v]].Clear();
            }

            return d[len - 1];
        }
    }

}
