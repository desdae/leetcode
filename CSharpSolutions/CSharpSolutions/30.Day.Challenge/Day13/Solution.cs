using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSolutions._30.Day.Challenge.Day13
{
    public class Solution
    {
        public int FindMaxLength(int[] nums)
        {
            Dictionary<int, int> d = new Dictionary<int, int>();
            d[0] = -1;
            int maxl = 0;
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                count += nums[i] == 1 ? 1 : -1;
                if (d.ContainsKey(count))
                {
                    maxl = Math.Max(maxl, i - d[count]);
                }
                else
                {
                    d[count] = i;
                }
            }
            return maxl;
        }
    }
}
