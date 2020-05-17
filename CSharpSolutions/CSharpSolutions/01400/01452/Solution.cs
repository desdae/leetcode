using System.Collections.Generic;
using System.Linq;

namespace CSharpSolutions._01400._01452
{
    public class Solution
    {
        public IList<int> PeopleIndexes(IList<IList<string>> favoriteCompanies)
        {
            var res = new List<int>();

            var h = new List<HashSet<string>>();

            foreach (var c in favoriteCompanies)
                h.Add(c.ToHashSet());

            for (int i = 0; i < h.Count; i++)
            {
                bool b = false;
                for (int j = 0; j < h.Count; j++)
                {
                    if (i != j && h[i].IsSubsetOf(h[j]))
                    {
                        b = true;
                        break;
                    }
                }
                if (!b)
                    res.Add(i);
            }

            return res;
        }
    }
}
