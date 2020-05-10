using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSolutions._01400._01441
{
    public class Solution
    {
        public IList<string> BuildArray(int[] target, int n)
        {
            var r = new List<string>();
            for (int i = 1; i <= n && i <= target[target.Length - 1]; i++)
            {
                r.Add("Push");
                if (!target.Contains(i))
                {
                    r.Add("Pop");
                }
            }
            return r;
        }
    }
}
