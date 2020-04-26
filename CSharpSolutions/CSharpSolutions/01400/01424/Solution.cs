using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSolutions._01400._01424
{
    public class Solution
    {
        public int[] FindDiagonalOrder(IList<IList<int>> nums)
        {
            SortedDictionary<int, List<int>> d = new SortedDictionary<int, List<int>>();

            for (int j = 0; j < nums.Count(); j++)
            {
                for (int i = 0; i < nums[j].Count(); i++)
                {
                    if (!d.ContainsKey(i + j))
                        d[i + j] = new List<int>();
                    d[i + j].Add(nums[j][i]);
                }
            }

            List<int> res = new List<int>();

            foreach (var k in d.Keys)
            {
                d[k].Reverse();
                foreach (var e in d[k])
                    res.Add(e);
            }
            return res.ToArray();
        }
    }

    //BAD
    public class SolutionBAD
    {
        public class Row
        {
            public int Index;
            public IList<int> Data;
            public bool Remove = false;
        }

        public int[] FindDiagonalOrder(IList<IList<int>> nums)
        {
            List<Row> d = new List<Row>();
            int elc = 0;

            for (int i = nums.Count() - 1; i >= 0; i--)
            {
                Console.WriteLine(i);
                d.Add(new Row() { Index = i, Data = nums[i] });
                elc += nums[i].Count();
            }

            List<int> res = new List<int>();

            int mx = 0;
            int dc = 0;

            while (res.Count() < elc && d.Count() > 0)
            {
                int c = 0;
                if (mx >= d.Count())
                    dc++;
                c += dc;
                int lastIdx = d.First().Index;
                Console.WriteLine("iteration start");
                foreach (var row in d)
                {
                    //Console.WriteLine($"rr {row.Index}");
                    if (row.Data.Count() > c)
                    {
                        if (row.Index <= mx)
                        {
                            res.Add(nums[row.Index][c]);
                            var delta = lastIdx - row.Index;
                            if (delta == 0) delta = 1;
                            Console.WriteLine($"{row.Index} {c} num {nums[row.Index][c]} lasidx {lastIdx} delta {delta}");
                            c += delta;
                            //c ++;
                            lastIdx = row.Index;
                        }
                        else
                        {
                            lastIdx = row.Index;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"remove row {row.Index}");
                        row.Remove = true;
                    }
                }
                mx++;
                d.RemoveAll(row => row.Remove);
            }

            return res.ToArray();
        }
    }
}
