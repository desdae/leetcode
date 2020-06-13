using System;
using System.Collections.Generic;

namespace CSharpSolutions._01400._01477
{
    public class Solution
    {
        private void Add(Dictionary<int, List<int>> d, int key, int val)
        {
            if (!d.ContainsKey(key))
                d[key] = new List<int>();
            d[key].Add(val);
        }

        public int MinSumOfLengths(int[] arr, int target)
        {
            var sums = new Dictionary<int, List<int>>();
            var arrs = new List<Tuple<int, int>>();
            Add(sums, 0, -1);

            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                if (sums.ContainsKey(sum - target))
                {
                    foreach (var e in sums[sum - target])
                    {
                        arrs.Add(new Tuple<int, int>(e + 1, i));
                    }
                }
                Add(sums, sum, i);
            }
            arrs.Sort((t1, t2) =>
            {
                return (t1.Item2 - t1.Item1) - (t2.Item2 - t2.Item1);
            });

            if (arrs.Count == 0)
                return -1;
            var res = 0;
            int min = int.MaxValue;
            bool found = false;
            for (int j = 0; j < 2 && j < arrs.Count; j++)
            {
                res = arrs[j].Item2 - arrs[j].Item1 + 1;
                for (int i = 1; i < arrs.Count; i++)
                {
                    if (arrs[i].Item1 > arrs[j].Item2 || arrs[i].Item2 < arrs[j].Item1)
                    {
                        found = true;
                        res += arrs[i].Item2 - arrs[i].Item1 + 1;
                        min = Math.Min(res, min);
                        break;
                    }
                }
            }
            return found ? res : -1;
        }
    }
}
