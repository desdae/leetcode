using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSolutions._01400._01443
{
    public class Solution
    {
        public class Node
        {
            public bool apple;
            public bool childApple;
            public List<Node> children = new List<Node>();

            public void BuildChildApples()
            {
                foreach (var c in children)
                {
                    if (c.apple)
                        childApple = true;
                    c.BuildChildApples();
                }
                foreach (var c in children)
                {
                    if (c.childApple)
                        childApple = true;
                }
            }
        }

        public int MinTime(int n, int[][] edges, IList<bool> hasApple)
        {
            Dictionary<int, Node> nodes = new Dictionary<int, Node>();

            for (int i = 0; i < n; i++)
            {
                nodes[i] = new Node();
            }

            for (int i = 0; i < edges.Length; i++)
            {
                nodes[edges[i][0]].children.Add(nodes[edges[i][1]]);
            }

            int x = 0;
            foreach (var a in hasApple)
            {
                nodes[x].apple = a;
                x++;
            }

            nodes[0].BuildChildApples();

            int r = 0;
            for (int i = 0; i < n; i++)
            {
                if (nodes[i].childApple || nodes[i].apple)
                    r += 2;
            }

            return Math.Max(r - 2, 0);
        }
    }
}
