using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSolutions._00000._00049
{
    public class Solution
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, List<string>> ord = new Dictionary<string, List<string>>();
            foreach (var s in strs)
            {
                var k = s.ToCharArray().ToList();
                k.Sort();
                var ks = new string(k.ToArray());
                if (!ord.Keys.Contains(ks))
                    ord[ks] = new List<string>();
                ord[ks].Add(s);
            }
            var ret = new List<IList<string>>();
            foreach (var v in ord.Values)
            {
                var l = new List<string>();
                foreach (var i in v)
                    l.Add(i);
                ret.Add(l);
            }
            return ret;
        }
    }
}
