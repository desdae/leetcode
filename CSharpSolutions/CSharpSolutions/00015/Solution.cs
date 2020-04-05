using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSolutions._00015
{
    public class Solution
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var ex = new Dictionary<string, int>();
            var res = new List<IList<int>>();
            var s1 = new Dictionary<int, int>();
            var n = nums.Length;
            var uq = new List<int>();
            for (int i = 0; i < n; i++)
            {
                if (uq.Where(s => s == nums[i]).Count() < 3)
                    uq.Add(nums[i]);
            }
            var nums1 = uq.ToArray();
            n = nums1.Length;

            for (int i = 0; i < n; i++)
                s1[nums1[i]] = i;

            for (int i = 0; i < n; i++)
                for (int j = i + 1; j < n; j++)
                {
                    if (s1.ContainsKey(-nums1[i] - nums1[j]))
                    {
                        var r = new List<int>();
                        var t = s1[-nums1[i] - nums1[j]];
                        if (t != i && t != j)
                        {
                            r.Add(nums1[i]);
                            r.Add(nums1[j]);
                            r.Add(nums1[t]);
                            r.Sort();
                            var s = r[0] + "_" + r[1] + "_" + r[2];
                            if (!ex.ContainsKey(s))
                            {
                                ex[s] = 1;
                                res.Add(r);
                            }
                        }
                    }
                }
            return res;
        }
    }
}
