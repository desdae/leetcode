using System.Collections.Generic;
using System.Linq;

namespace CSharpSolutions._01400._01447
{
    public class Solution
    {
        private string Simplify(int x, int y)
        {
            for (int i = 2; i <= x; i++)
            {
                while (x % i == 0 && y % i == 0)
                {
                    x /= i;
                    y /= i;
                }
            }
            return x + "/" + y;
        }

        public IList<string> SimplifiedFractions(int n)
        {
            HashSet<string> res = new HashSet<string>();

            for (int i = 1; i < n; i++)
                for (int j = i + 1; j <= n; j++)
                {
                    var s = Simplify(i, j);
                    if (!res.Contains(s))
                        res.Add(s);
                }
            return res.ToList();
        }
    }
}
