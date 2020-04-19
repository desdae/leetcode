using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSolutions._01400._01418
{
    public class Solution
    {
        public IList<IList<string>> DisplayTable(IList<IList<string>> orders)
        {
            HashSet<string> items = new HashSet<string>();
            SortedDictionary<int, Dictionary<string, int>> tables = new SortedDictionary<int, Dictionary<string, int>>();
            foreach (var order in orders)
            {
                int t = int.Parse(order[1]);
                var item = order[2];
                items.Add(item);
                if (!tables.ContainsKey(t))
                    tables[t] = new Dictionary<string, int>();
                if (!tables[t].ContainsKey(item))
                    tables[t][item] = 0;
                tables[t][item]++;
            }
            var res = new List<IList<string>>();
            var hdr = new List<string>();
            hdr.Add("Table");
            var itemsList = new List<string>(items);
            itemsList.Sort(StringComparer.Ordinal);
            foreach (var item in itemsList)
                hdr.Add(item);
            res.Add(hdr);
            foreach (var t in tables.Keys)
            {
                var row = new List<string>();
                row.Add(t.ToString());
                foreach (var item in itemsList)
                {
                    if (tables[t].ContainsKey(item))
                        row.Add(tables[t][item].ToString());
                    else
                        row.Add("0");
                }
                res.Add(row);
            }
            return res;
        }
    }
}
