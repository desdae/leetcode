using System.Collections.Generic;

namespace CSharpSolutions._01400._01496
{
    public class Solution
    {
        private long P(int x, int y)
        {
            return y * 10000 + x;
        }
        public bool IsPathCrossing(string path)
        {
            var p = new HashSet<long>();
            int x = 0;
            int y = 0;
            p.Add(P(x, y));
            for (int i = 0; i < path.Length; i++)
            {
                switch (path[i])
                {
                    case 'N':
                        y--;
                        break;
                    case 'S':
                        y++;
                        break;
                    case 'E':
                        x++;
                        break;
                    case 'W':
                        x--;
                        break;
                }
                if (p.Contains(P(x, y)))
                    return true;
                p.Add(P(x, y));
            }
            return false;
        }
    }
}
