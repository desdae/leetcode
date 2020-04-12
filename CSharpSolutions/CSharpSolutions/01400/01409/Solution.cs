using System.Collections.Generic;

namespace CSharpSolutions._01400._01409
{
    public class Solution
    {
        public int[] ProcessQueries(int[] queries, int m)
        {
            var p = new LinkedList<int>();
            var r = new int[queries.Length];
            for (int i = 1; i <= m; i++)
                p.AddLast(i);

            for (int i = 0; i < queries.Length; i++)
            {
                int j = 0;
                foreach (var x in p)
                {
                    if (queries[i] == x)
                    {
                        r[i] = j;
                        p.Remove(x);
                        p.AddFirst(x);
                        break;
                    }
                    j++;
                }
            }
            return r;
        }
    }
}
